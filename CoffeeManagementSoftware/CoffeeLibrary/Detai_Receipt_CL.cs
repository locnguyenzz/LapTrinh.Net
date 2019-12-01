using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class Detai_Receipt_CL:DataContext
    {
        Item_CL dll = new Item_CL();
        public List<detail_receipt> LoadDetail(int pID)
        {
            return _Coffee.detail_receipts.Where(t => t.ID_RECEIPT.Equals(pID)).ToList();
        }
        //Cap nhat ctpn
        public bool CapNhatCTPX(int pMaPX,int pMaSp, int pNum)
        {
            try
            {
                detail_receipt check = _Coffee.detail_receipts.Where(t => t.ID_RECEIPT.Equals(pMaPX) && t.ID_ITEM.Equals(pMaSp)).FirstOrDefault();
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
                detail_receipt check = _Coffee.detail_receipts.Where(t => t.ID_RECEIPT.Equals(pMaPX) && t.ID_ITEM.Equals(pMaSp)).FirstOrDefault();
                if (check != null)
                {
                    return false;
                }
                else
                {
                    detail_receipt add = new detail_receipt();
                    add.ID_RECEIPT = pMaPX;
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
        public bool XoaCTNP(int pMaPX, int pMaSp)
        {
            try
            {
                detail_receipt check = _Coffee.detail_receipts.Where(t => t.ID_RECEIPT.Equals(pMaPX) && t.ID_ITEM.Equals(pMaSp)).FirstOrDefault();
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
                detail_receipt check = _Coffee.detail_receipts.Where(t => t.ID_RECEIPT.Equals(pMaPX) && t.ID_ITEM.Equals(pMaSp)).FirstOrDefault();
                
                if (check != null)
                {
                    int numchang = pNum - check.NUMBER;
                    check.ID_ITEM = pMaSp;
                    check.NUMBER = pNum;
                    check.PRICE_SELL = pDonGia;
                    dll.DeleteNumber(pMaSp, numchang);
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
