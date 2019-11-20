using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CoffeeLibrary
{
    public class Item_CL:DataContext
    {
        public List<item> LoadItem()
        {
            var query = from p in _Coffee.items
                        join tc in _Coffee.type_items on p.ID_TYPE_ITEM equals tc.ID
                        select new
                        {
                            p.ID,
                            p.NAME_ITEM,
                            p.PRICE_SELL,
                            p.PRICE_PURCHASE,
                            p.UNIT,
                            p.NUMBER,
                            tc.NAME_TYPE,
                            p.STATUS
                        };
            var kq = query.ToList().ConvertAll(t => new item
            {
                ID = t.ID,
                NAME_ITEM = t.NAME_ITEM,
                UNIT = t.UNIT,
                NUMBER = t.NUMBER,
                PRICE_SELL = t.PRICE_SELL,
                PRICE_PURCHASE = t.PRICE_PURCHASE,
                NAME_TYPE = t.NAME_TYPE,
                STATUS = t.STATUS
            });
            return kq.ToList<item>();  
        }

        //Lấy ID lớn nhất
        public int MaxID()
        {
            DataTable check = new DataTable();
            SqlDataAdapter dt = new SqlDataAdapter("select * from item", Properties.Settings.Default.DB_CoffeeConnectionString);
            dt.Fill(check);
            return check.Rows.Count;
        }
        public bool AddNewItem(string pName, string pUnit,double pPrice_Sell, double pPrice_Pur,int pNum, int pItem)
        {
            try
            {
                item sp = new item();
                sp.ID = MaxID() + 1;
                sp.NAME_ITEM = pName;
                sp.UNIT = pUnit;
                sp.PRICE_SELL = pPrice_Sell;
                sp.PRICE_PURCHASE = pPrice_Pur;
                sp.ID_TYPE_ITEM = pItem;
                sp.NUMBER = pNum;
                sp.STATUS = 1;
                _Coffee.items.InsertOnSubmit(sp);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool DeleteItem(int pID)
        {
            try
            {
                item sp = _Coffee.items.Where(t => t.ID.Equals(pID)).FirstOrDefault();
                _Coffee.items.DeleteOnSubmit(sp);
                _Coffee.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool EditItem(int pId, string pName, string pUnit, double pPrice_Sell, double pPrice_Pur,int pNum, int pItem, int pStatus)
        {
            try
            {
                item sp = _Coffee.items.Where(t => t.ID.Equals(pId)).FirstOrDefault();
                sp.NAME_ITEM = pName;
                sp.UNIT = pUnit;
                sp.PRICE_SELL = pPrice_Sell;
                sp.PRICE_PURCHASE = pPrice_Pur;
                sp.ID_TYPE_ITEM = pItem;
                sp.NUMBER = pNum;
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
