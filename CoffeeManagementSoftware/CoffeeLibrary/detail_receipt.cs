using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public partial class detail_receipt
    {
        double? priceSell;

        public double? PRICE_SELL
        {
            get { return priceSell; }
            set { priceSell = value; }
        }
    }
}
