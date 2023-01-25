using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingLists.Class
{
    public class Buyers
    {
        public Buyers()
        {
            this.Stock = new HashSet<Stock>();
        }

        public int BuyersId { get; set; }
        public string Name { get; set; }
        public DateTime DateBirthday { get; set; }
        public int CityId { get; set; }

        public virtual City City { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
