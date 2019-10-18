﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    class UserManager
    {
        //Kiểm tra cấu hình
        public int Check_Config()        {
            if (Properties.Settings.Default.DB_CoffeeConnectionString == string.Empty)
            {
                return 1;//Chuỗi cấu hình không tồn tại
            }
            SqlConnection sqlConn = new SqlConnection(Properties.Settings.Default.DB_CoffeeConnectionString);
            try
            {
                if (sqlConn.State == System.Data.ConnectionState.Closed)
                    sqlConn.Open();
                return 0;//Kết nối thành công
            }
            catch
            {
                return 2;//Chuỗi cấu hình không phù hợp
            }
        }

        //Kiểm tra tài khoản, trả về số
        public int Check_User(string pUser, string pPass)
        {
            SqlDataAdapter daUser = new SqlDataAdapter("select * from user where USER_NAME='" + pUser + "' and PASSWORD ='" + pPass + "'", Properties.Settings.Default.DB_CoffeeConnectionString);
            DataTable dt = new DataTable();
            daUser.Fill(dt);
            if (dt.Rows.Count == 0)
            {
                return 1;//Không tồn tại
            }
            else
            {
                if (dt.Rows[0][2] == null || dt.Rows[0][3].ToString() == "0")
                    return 2;//Không hoạt động
            }
            return 3;//Đăng nhập thành công
        }

        //Đọc tên Server
        public DataTable GetServerName()
        {
            SqlDataSourceEnumerator instance = SqlDataSourceEnumerator.Instance;
            System.Data.DataTable table = instance.GetDataSources();
            return table;
        }

        //Đọc danh sách database,đầu vào là tên sever, tên user, mật khẩu trả về danh sách database
        public List<string> GetDatabaseName(string pServerName, string pUser, string pPass)
        {
            List<string> list = new List<string>();
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("select name from sys.databases",
                    "Data Source=" + pServerName + ";Initial Catalog=" + "master" + ";User ID=" + pUser + ";pwd=" + pPass + "");
                da.Fill(dt);
                foreach (System.Data.DataRow r in dt.Rows)
                {
                    foreach (System.Data.DataColumn c in dt.Columns)
                    {
                        list.Add(r[c].ToString());
                    }
                }
            }
            catch
            {
                return null;
            }
            return list;
        }


        //Lưu cấu hình
        public void ChangConnectionString(string pServerName, string pDataBase, string pUser, string pPass)
        {
            CoffeeLibrary.Properties.Settings.Default["DB_CoffeeConnectionString"] = "Data Source=" + pServerName + ";Initial Catalog=" + pDataBase + ";User ID=" + pUser + ";Password=" + pPass + "";
            Properties.Settings.Default.Save();
        }

        //Lấy chuỗi cấu hình
        public string GetStringConfig()
        {
            return CoffeeLibrary.Properties.Settings.Default.DB_CoffeeConnectionString;
        }

    }
}
