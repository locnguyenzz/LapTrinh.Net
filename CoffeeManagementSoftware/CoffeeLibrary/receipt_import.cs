using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public partial class receipt_import
    {
        string name;
        int? id;

        public int? ID_ITEM
        {
            get { return id; }
            set { id = value; }
        }
        public string NAME_ITEM
        {
            get { return name; }
            set { name = value; }
        }
        double? price;

        public double? PRICE_PURCHASE
        {
            get { return price; }
            set { price = value; }
        }
        int? num;

        public int? NUMBER
        {
            get { return num; }
            set { num = value; }
        }
    }
}
