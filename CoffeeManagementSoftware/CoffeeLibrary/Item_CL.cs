using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class Item_CL:DataContext
    {
        public List<item> LoadItem()
        {
            return _Coffee.items.Select(t => t).ToList<item>();
        }
    }
}
