using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public partial class detail_receipt_import
    {
        double? pricePur;

        public double? PRICE_PURCHASE
        {
            get { return pricePur; }
            set { pricePur = value; }
        }
    }
}
