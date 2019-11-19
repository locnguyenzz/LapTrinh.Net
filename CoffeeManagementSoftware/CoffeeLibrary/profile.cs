using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public partial class profile
    {
        string name_type;
        int? status;

        public int? STATUS
        {
            get { return status; }
            set { status = value; }
        }

       
        public string NAME_TYPE
        {
            get { return name_type; }
            set { name_type = value; }
        }
    }
}
