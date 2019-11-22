using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CoffeeLibrary
{
    public class Staff_CL : DataContext
    {
        public List<profile_staff> Getdata()
        {
            return _Coffee.profile_staffs.Select(t => t).ToList<profile_staff>();
        }

        public List<profile_staff> LoadStaff()
        {
            var query = from p in _Coffee.profile_staffs
                        join tc in _Coffee.timekeepings on p.ID_TIMEKEEPING equals tc.ID
                        select new
                        {
                            p.ID,
                            p.ID_TIMEKEEPING,
                            p.NAME_STAFF,
                            tc.SHIFT,
                            p.STATUS,
                        };
            var kq = query.ToList().ConvertAll(t => new profile_staff
            {
                ID = t.ID,
                ID_TIMEKEEPING = t.ID_TIMEKEEPING,
                NAME_STAFF = t.NAME_STAFF,
                SHIFT = t.SHIFT,
                STATUS = t.STATUS,
            });
            return kq.ToList<profile_staff>();
        }
        public int MaxID()
        {
            DataTable check = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from profile_staff ", Properties.Settings.Default.DB_CoffeeConnectionString);
            dt.Fill(check);
            return check.Rows.Count;
        }
        public bool AddNewStaff(string pName, int pCa)
        {
            try
            {
                profile_staff p = new profile_staff();
                p.ID = MaxID() + 1;
                p.NAME_STAFF = pName;
                p.STATUS = 1;
                p.ID_TIMEKEEPING = pCa;
                _Coffee.profile_staffs.InsertOnSubmit(p);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteStaff(int pMa)
        {
            try
            {
                profile_staff p = _Coffee.profile_staffs.Where(t => t.ID.Equals(pMa)).FirstOrDefault();
                _Coffee.profile_staffs.DeleteOnSubmit(p);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool EditStaff(int pMa, string pName, string pCa,int pStatus)
        {
            try
            {
                profile_staff p = _Coffee.profile_staffs.Where(t => t.ID.Equals(pMa)).FirstOrDefault();         
                p.NAME_STAFF = pName;
                p.STATUS = 1;
                p.SHIFT = pCa;
                p.STATUS = pStatus;
                
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
