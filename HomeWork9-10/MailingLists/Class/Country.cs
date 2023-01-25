using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingLists.Class
{
    public class  Country
    {
        public Country()
        {
            this.City = new HashSet<City>();
            this.Stock = new HashSet<Stock>();
        }

        public int CountryId { get; set; }
        public string Name { get; set; }
        public string OKSM { get; set; }

        public virtual ICollection<City> City { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
