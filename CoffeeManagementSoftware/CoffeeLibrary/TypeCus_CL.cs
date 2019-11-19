using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class TypeCus_CL:DataContext
    {
        public List<type_customer> LoadTypeCus()
        {
            return _Coffee.type_customers.Select(t => t).ToList<type_customer>();
        }
    }
}
