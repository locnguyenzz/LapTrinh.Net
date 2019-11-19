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
                            q.NUMBER,                          
                            
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
        public bool AddNewInventory(int pID_item)
        {
            try
            {
                inventory sp = new inventory();
                sp.ID = MaxID() + 1;
                sp.ID_ITEM = pID_item;
                
                _Coffee.inventories.InsertOnSubmit(sp);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteInventory(int pId)
        {
            try 
            {
                inventory sp = _Coffee.inventories.Where(t => t.ID.Equals(pId)).FirstOrDefault();
                _Coffee.inventories.DeleteOnSubmit(sp);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
           
        }

       public bool EditInventory(int pId,int pID_item)
        {
           try
           {
               inventory sp = _Coffee.inventories.Where(t => t.ID.Equals(pId)).FirstOrDefault();
               sp.ID_ITEM = pID_item;
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
