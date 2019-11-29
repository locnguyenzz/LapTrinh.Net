using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class Table_CL:DataContext
    {
        public List<table> LoadTable()
        {
            return _Coffee.tables.Select(t => t).ToList();
        }
    }
}
