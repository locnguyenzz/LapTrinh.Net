using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CoffeeLibrary
{
    public class Supplier_CL:DataContext
    {
        public List<supplier> LoadSupplier()
        {
            return _Coffee.suppliers.Select(t => t).ToList<supplier>();
        }
        //Lấy ID lớn nhất
        public int MaxID()
        {
            DataTable check = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from supplier", Properties.Settings.Default.DB_CoffeeConnectionString);
            dt.Fill(check);
            return check.Rows.Count;
        }
        public bool AddNewSupp(string pName, string pPhone, string pAddress,string pEmail)
        {
            try
            {
                supplier sp = new supplier();
                sp.ID = MaxID() + 1;
                sp.NAME = pName;
                sp.PHONE = pPhone;
                sp.EMAIL = pEmail;
                sp.ADDRESS = pAddress;
                sp.STATUS = 1;
                _Coffee.suppliers.InsertOnSubmit(sp);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteSupp(int pID)
        {
            try
            {
                supplier sp = _Coffee.suppliers.Where(t => t.ID.Equals(pID)).FirstOrDefault();
                _Coffee.suppliers.DeleteOnSubmit(sp);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditSupp(int pId,string pName, string pPhone, string pAddress,string pEmail,int pStatus)
        {
            try
            {
                supplier sp = _Coffee.suppliers.Where(t => t.ID.Equals(pId)).FirstOrDefault();
                sp.NAME = pName;
                sp.PHONE = pPhone;
                sp.EMAIL = pEmail;
                sp.ADDRESS = pAddress;
                sp.STATUS = pStatus;
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
