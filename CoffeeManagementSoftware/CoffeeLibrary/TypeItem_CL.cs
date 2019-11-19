using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class TypeItem_CL:DataContext
    {
        public List<type_item> LoadTypeItem()
        {
            return _Coffee.type_items.Select(t => t).ToList<type_item>();
        }
    }
}
