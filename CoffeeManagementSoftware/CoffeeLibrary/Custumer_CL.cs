using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CoffeeLibrary
{
    public class Custumer_CL:DataContext
    {
        public List<profile> LoadCustumer()
        {
            var query = from p in _Coffee.profiles
                        join tc in _Coffee.type_customers on p.ID_TYPE_CUSTOMER equals tc.ID
                        select new
                        {
                            p.ID,
                            p.ID_ACCOUNT,
                            p.IDENTIFICATION,
                            p.LAST_NAME,
                            p.FIRST_NAME,
                            p.PHONE,
                            p.ADDRESS,
                            p.SEX,
                            p.EMAIL,
                            tc.NAME_TYPE,
                            tc.STATUS
                        };
            var kq = query.ToList().ConvertAll(t => new profile
            {
                ID = t.ID,
                ID_ACCOUNT = t.ID_ACCOUNT,
                IDENTIFICATION = t.IDENTIFICATION,
                LAST_NAME = t.LAST_NAME,
                FIRST_NAME = t.FIRST_NAME,
                PHONE = t.PHONE,
                ADDRESS = t.ADDRESS,
                SEX = t.SEX,
                EMAIL = t.EMAIL,
                NAME_TYPE = t.NAME_TYPE,
                STATUS = t.STATUS
            });
            return kq.ToList<profile>();           
        }
        //Lấy ID lớn nhất
        public int MaxID()
        {
            DataTable check = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from profile ", Properties.Settings.Default.DB_CoffeeConnectionString);
            dt.Fill(check);
            return check.Rows.Count;
        }
        public bool AddNewProfile(string pLName,string pFName, string pPhone, string pAddress,string pEmail, int pType_Name)
        {
            try
            {
                profile p = new profile();
                p.ID = MaxID() + 1;
                p.LAST_NAME = pLName;
                p.FIRST_NAME = pFName;
                p.PHONE = pPhone;
                p.ADDRESS = pAddress;
                p.EMAIL = pEmail;
                p.ID_TYPE_CUSTOMER = pType_Name;
                p.STATUS = 1;
                _Coffee.profiles.InsertOnSubmit(p);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteCus(int pID)
        {
            try
            {
                profile sp = _Coffee.profiles.Where(t => t.ID.Equals(pID)).FirstOrDefault();
                _Coffee.profiles.DeleteOnSubmit(sp);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool EditCus(int pId, string pLName, string pFName, string pPhone, string pAddress, string pEmail, int pType_Name, int pStatus)
        {
            try
            {
                profile sp = _Coffee.profiles.Where(t => t.ID.Equals(pId)).FirstOrDefault();
                sp.LAST_NAME = pLName;
                sp.FIRST_NAME = pFName;
                sp.PHONE = pPhone;
                sp.EMAIL = pEmail;
                sp.ADDRESS = pAddress;
                sp.STATUS = pStatus;
                sp.ID_TYPE_CUSTOMER = pType_Name;
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
