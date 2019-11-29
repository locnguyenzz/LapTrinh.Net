using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class Detail_Receip_Import_CL:DataContext
    {
        public List<detail_receipt_import> LoadPN_MaPN(int pMaPN)
        {
            return _Coffee.detail_receipt_imports.Where(t => t.ID.Equals(pMaPN)).ToList();
        }

        //Cap nhat ctpn
        public bool CapNhatCTPN(int pMaPN, int pNum)
        {
            try
            {
                detail_receipt_import check = _Coffee.detail_receipt_imports.Where(t => t.ID.Equals(pMaPN)).FirstOrDefault();
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
        public bool ThemMoiCTPN(int pMaPN, int pMaSp, double pDonGia, int pNum)
        {
            try
            {
                detail_receipt_import check = _Coffee.detail_receipt_imports.Where(t => t.ID.Equals(pMaPN)).FirstOrDefault();
                if (check != null)
                {
                    return false;
                }
                else
                {
                    detail_receipt_import add = new detail_receipt_import();
                    add.ID = pMaPN;
                    add.ID_ITEM = pMaSp;
                    add.PRICE_PURCHASE = pDonGia;
                    add.NUMBER = pNum;

                    _Coffee.detail_receipt_imports.InsertOnSubmit(add);
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
        public bool XoaCTNP(int pMaPN)
        {
            try
            {
                detail_receipt_import check = _Coffee.detail_receipt_imports.Where(t => t.ID.Equals(pMaPN)).FirstOrDefault();
                if (check != null)
                {
                    _Coffee.detail_receipt_imports.DeleteOnSubmit(check);
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
        public bool SuaCTNP(int pMaPN, int pMaSp, double pDonGia, int pNum)
        {
            try
            {
                detail_receipt_import check = _Coffee.detail_receipt_imports.Where(t => t.ID.Equals(pMaPN)).FirstOrDefault();
                if (check != null)
                {
                    check.ID_ITEM = pMaSp;
                    check.NUMBER = pNum;
                    check.PRICE_PURCHASE = pDonGia;
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
