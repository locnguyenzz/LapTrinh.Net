using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CoffeeLibrary
{
   public class Inventory_CL : DataContext
    {
        public List<inventory> LoadInventory()
        {
            var query = from q in _Coffee.inventories
                        join i in _Coffee.items on q.ID_ITEM equals i.ID
                        select new
                        {
                            q.ID,
                            i.NAME_ITEM,
                            i.UNIT,
                            i.NUMBER,                                           
                        };
            var kq = query.ToList().ConvertAll(t => new inventory
            {
                ID = t.ID,
                NAME_ITEM = t.NAME_ITEM,
                UNIT = t.UNIT,
                NUMBER = t.NUMBER,
            });
            return kq.ToList<inventory>();
        }
        public int MaxID()
        {
            DataTable check = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from inventory", Properties.Settings.Default.DB_CoffeeConnectionString);
            dt.Fill(check);
            return check.Rows.Count;
        }
        
    }
}
