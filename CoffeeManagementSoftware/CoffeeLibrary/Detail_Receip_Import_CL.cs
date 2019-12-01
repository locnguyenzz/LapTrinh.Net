using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class Detail_Receip_Import_CL:DataContext
    {
        Item_CL dll = new Item_CL();
        public List<detail_receipt_import> LoadPN_MaPN(int pMaPN)
        {
            return _Coffee.detail_receipt_imports.Where(t => t.ID_RECEIPT_IMPORT.Equals(pMaPN)).ToList();
        }

        //Cap nhat ctpn
        public bool CapNhatCTPN(int pMaPN,int pMaSp, int pNum)
        {
            try
            {
                detail_receipt_import check = _Coffee.detail_receipt_imports.Where(t => t.ID_RECEIPT_IMPORT.Equals(pMaPN) && t.ID_ITEM.Equals(pMaSp)).FirstOrDefault();
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
                detail_receipt_import check = _Coffee.detail_receipt_imports.Where(t => t.ID_RECEIPT_IMPORT.Equals(pMaPN) && t.ID_ITEM.Equals(pMaSp)).FirstOrDefault();
                if (check != null)
                {
                    return false;
                }
                else
                {
                    detail_receipt_import add = new detail_receipt_import();
                    add.ID_RECEIPT_IMPORT = pMaPN;
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
        public bool XoaCTNP(int pMaPN, int pMaSp)
        {
            try
            {
                detail_receipt_import check = _Coffee.detail_receipt_imports.Where(t => t.ID_RECEIPT_IMPORT.Equals(pMaPN) && t.ID_ITEM.Equals(pMaSp)).FirstOrDefault();
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
                detail_receipt_import check = _Coffee.detail_receipt_imports.Where(t => t.ID_RECEIPT_IMPORT.Equals(pMaPN) && t.ID_ITEM.Equals(pMaSp)).FirstOrDefault();
                if (check != null)
                {
                    int numchang = pNum - check.NUMBER;
                    check.ID_ITEM = pMaSp;
                    check.NUMBER = pNum;
                    check.PRICE_PURCHASE = pDonGia;
                    dll.UpdateNumber(pMaSp, numchang);
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
