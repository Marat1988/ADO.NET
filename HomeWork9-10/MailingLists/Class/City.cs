using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingLists.Class
{
    public class City
    {
        public City()
        {
            this.Buyers = new HashSet<Buyers>();
        }

        public int CityId { get; set; }
        public string Name { get; set; }
        public int CountryId { get; set; }

        public virtual ICollection<Buyers> Buyers { get; set; }
        public virtual Country Country { get; set; }
    }
}
