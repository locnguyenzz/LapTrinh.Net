using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public partial class inventory
    {
        string name_item;
        string unit;

        public string UNIT
        {
            get { return unit; }
            set { unit = value; }
        }
        public string NAME_ITEM
        {
            get { return name_item; }
            set { name_item = value; }
        }
    }
}
