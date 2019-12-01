using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class Receipt_CL:DataContext
    {
        public List<receipt> LoadReceipt()
        {
            return _Coffee.receipts.Select(t => t).ToList();
        }
        public receipt LoadTTPX(int pID)
        {
            try
            {
                receipt check = _Coffee.receipts.Where(t => t.ID.Equals(pID)).FirstOrDefault();
                return check;
            }
            catch
            {
                return null;
            }
        }
        //Tao phieu nhap
        public bool TaoPhieuXuat(int pID, string pNgayXuat)
        {
            try
            {
                receipt check = _Coffee.receipts.Where(t => t.ID.Equals(pID)).FirstOrDefault();
                if (check != null)
                {
                    return false;//ton tai ma pn
                }
                else
                {
                    
                    receipt add = new receipt();
                    add.ID = pID;
                    add.ID_ACCOUNT = 1;
                    add.CREATE_AT = Convert.ToDateTime(pNgayXuat);
                    _Coffee.receipts.InsertOnSubmit(add);
                    _Coffee.SubmitChanges();
                    return true;
                }
            }
            catch
            {
                return false;
            }
        }
        //Cap nhat thanh tien
        public bool CapNhatThanhTien(int pID, double pSum)
        {
            try
            {
                receipt_import check = _Coffee.receipt_imports.Where(t => t.ID.Equals(pID)).FirstOrDefault();
                check.SUM_MONEY = pSum;
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
