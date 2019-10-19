using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class C_Account
    {
       

        public int GetIDAccount(string pUserName)//Lay ra ID cua tai khoan
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from account a where a.USERNAME ='" + pUserName + "'", Properties.Settings.Default.DB_CoffeeConnectionString);
            dt.Fill(tb);
            return Int32.Parse(tb.Rows[0][0].ToString());
        }

        public int IsAccount(string pUserName)//Kiểm tra tài khoản có tồn tại chưa
        {
            DataTable tb = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select USERNAME from account a where USERNAME = N'" + pUserName + "'", Properties.Settings.Default.DB_CoffeeConnectionString);
            dt.Fill(tb);
            return tb.Rows.Count;
        }

        public bool ChangePass(string pUserName, string pPassNew, string pPassOld)
        {
            try
            {
                DBC_CoffeeDataContext dbc = new DBC_CoffeeDataContext();
                var query = from acc in dbc.accounts
                            where string.Equals(acc.USERNAME, pUserName) == true
                            select acc;

                foreach (account item in query)
                {
                    if (string.Equals(item.PASSWORD, pPassOld))
                    {
                        item.PASSWORD = pPassNew;
                    }
                    else
                    {
                        return false;
                    }
                }
                dbc.SubmitChanges();
                return true;//Cap nhat thanh cong
            }
            catch
            {
                return false;
            }
        }
    }
}
