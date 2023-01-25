using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingLists.Class
{
    public class Stock
    {
        public Stock()
        {
            this.LineStock = new HashSet<LineStock>();
            this.Buyers = new HashSet<Buyers>();
        }

        public int StockId { get; set; }
        public string Name { get; set; }
        public DateTime DateBegin { get; set; }
        public DateTime DateEnd { get; set; }
        public int CountryId { get; set; }
        public int GroupProductId { get; set; }

        public virtual Country Country { get; set; }
        public virtual GroupProduct GroupProduct { get; set; }
        public virtual ICollection<LineStock> LineStock { get; set; }
        public virtual ICollection<Buyers> Buyers { get; set; }
    }
}
