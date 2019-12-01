using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CoffeeLibrary
{
    public class TypeItem_CL:DataContext
    {
        public List<type_item> LoadTypeItem()
        {
            return _Coffee.type_items.Select(t => t).ToList<type_item>();
        }
        public int MaxID()
        {
            DataTable check = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from type_item ", Properties.Settings.Default.DB_CoffeeConnectionString);
            dt.Fill(check);
            return check.Rows.Count;
        }
        public bool AddNewType(int pId, string pName_Type)
        {
            try
            {
                type_item ti = new type_item();
                ti.ID = MaxID() + 1;
                ti.NAME_TYPE = pName_Type;
                ti.STATUS = "1";
                _Coffee.type_items.InsertOnSubmit(ti);
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
