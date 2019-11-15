using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeLibrary
{
    public class Custumer_CL:DataContext
    {
        public List<profile> LoadCustumer()
        {
            //var query = from p in _Coffee.profiles
            //            join pC in _Coffee.profile_customers on p.ID equals pC.ID_PROFILE
            //            select new
            //            {
            //                p.ID,
            //                p.ID_ACCOUNT,
            //                p.IDENTIFICATION,
            //                p.LAST_NAME,
            //                p.FIRST_NAME,
            //                p.PHONE,
            //                p.ADDRESS,
            //                p.SEX,
            //                pC.SCORE,
            //                pC.STATUS,
            //                pC.ID_TYPE_CUSTOMER
            //            };
            //return query.ToList<profile>();
            return _Coffee.profiles.Select(t => t).ToList<profile>(); 
        }
    }
}
