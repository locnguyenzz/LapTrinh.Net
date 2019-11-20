using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace CoffeeLibrary
{
   public class WareHousing_CL:DataContext
    {
       public List<receipt_import> LoadsWare()
       {
           var query = from q in _Coffee.receipt_imports
                       join dt in _Coffee.detail_receipt_imports on q.ID equals dt.ID_RECEIPT_IMPORT
                       join i in _Coffee.items on dt.ID_ITEM equals i.ID
                       select new
                       {
                           q.ID,
                           dt.ID_ITEM,
                           i.NAME_ITEM,
                           i.PRICE_PURCHASE,
                           q.SUM_MONEY,
                           dt.NUMBER,
                           q.CREATE_AT,
                       };
           var kq = query.ToList().ConvertAll(t => new receipt_import
           {
               ID = t.ID,
               ID_ITEM = t.ID_ITEM,
               NAME_ITEM = t.NAME_ITEM,
               PRICE_PURCHASE = t.PRICE_PURCHASE,
               SUM_MONEY = t.SUM_MONEY,
               NUMBER = t.NUMBER,
               CREATE_AT = t.CREATE_AT,
           });
           return kq.ToList<receipt_import>();
       }
       //Lấy ID lớn nhất
       public int MaxID()
       {
           DataTable check = new DataTable();
           SqlDataAdapter dt = new SqlDataAdapter("select * from receipt_import", Properties.Settings.Default.DB_CoffeeConnectionString);
           dt.Fill(check);
           return check.Rows.Count;
       }
       public bool AddNewImport(int pItem,string pCreate, int pNum)
       {
           try
           {
               receipt_import sp = new receipt_import();
               sp.ID = MaxID() + 1;
               sp.SUM_MONEY = sp.NUMBER * sp.PRICE_PURCHASE;
               sp.NUMBER = pNum;
               sp.ID_ITEM = pItem;
               sp.CREATE_AT = Convert.ToDateTime(pCreate);
               sp.STATUS = 1;
               _Coffee.receipt_imports.InsertOnSubmit(sp);
               _Coffee.SubmitChanges();
               return true;
           }
           catch
           {
               return false;
           }
       }
       public bool DeleteImport(int pID)
       {
           try
           {
               receipt_import sp = _Coffee.receipt_imports.Where(t => t.ID.Equals(pID)).FirstOrDefault();
               _Coffee.receipt_imports.DeleteOnSubmit(sp);
               _Coffee.SubmitChanges();
               return true;
           }
           catch
           {
               return false;
           }
       }
       public bool EditImport(int pId, int pItem, string pCreate, int pNum)
       {
           try
           {
               receipt_import sp = _Coffee.receipt_imports.Where(t => t.ID.Equals(pId)).FirstOrDefault();
               sp.SUM_MONEY = sp.NUMBER * sp.PRICE_PURCHASE;
               sp.NUMBER = pNum;
               sp.ID_ITEM = pItem;
               sp.CREATE_AT = Convert.ToDateTime(pCreate);
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
