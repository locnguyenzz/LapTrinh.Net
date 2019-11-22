using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class TimeKeeping_CL:DataContext
    {
        public List<timekeeping> LoadShift()
        {
            return _Coffee.timekeepings.Select(t => t).ToList<timekeeping>();
        }

        
    }
}
