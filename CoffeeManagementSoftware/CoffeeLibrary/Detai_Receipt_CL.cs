using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class Detai_Receipt_CL:DataContext
    {
        public List<detail_receipt> LoadDetail(int pID)
        {
            return _Coffee.detail_receipts.Where(t => t.ID.Equals(pID)).ToList();
        }
        //Cap nhat ctpn
        public bool CapNhatCTPX(int pMaPX, int pNum)
        {
            try
            {
                detail_receipt_import check = _Coffee.detail_receipt_imports.Where(t => t.ID.Equals(pMaPX)).FirstOrDefault();
                check.NUMBER = pNum;
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //them moi chi tiet phieu nhap
        public bool ThemMoiCTPX(int pMaPX,int pTable, int pMaSp, double pDonGia, int pNum)
        {
            try
            {
                detail_receipt check = _Coffee.detail_receipts.Where(t => t.ID.Equals(pMaPX)).FirstOrDefault();
                if (check != null)
                {
                    return false;
                }
                else
                {
                    detail_receipt add = new detail_receipt();
                    add.ID = pMaPX;
                    add.ID_TABLE = pTable;
                    add.ID_ITEM = pMaSp;
                    add.PRICE_SELL = pDonGia;
                    add.NUMBER = pNum;

                    _Coffee.detail_receipts.InsertOnSubmit(add);
                    _Coffee.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }

        //Xoa chi tiet pn
        public bool XoaCTNP(int pMaPX)
        {
            try
            {
                detail_receipt check = _Coffee.detail_receipts.Where(t => t.ID.Equals(pMaPX)).FirstOrDefault();
                if (check != null)
                {
                    _Coffee.detail_receipts.DeleteOnSubmit(check);
                    _Coffee.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        //Sua chi tiet pn
        public bool SuaCTNP(int pMaPX, int pMaSp, double pDonGia, int pNum)
        {
            try
            {
                detail_receipt check = _Coffee.detail_receipts.Where(t => t.ID.Equals(pMaPX)).FirstOrDefault();
                if (check != null)
                {
                    check.ID_ITEM = pMaSp;
                    check.NUMBER = pNum;
                    check.PRICE_SELL = pDonGia;
                    _Coffee.SubmitChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }
    }
}
