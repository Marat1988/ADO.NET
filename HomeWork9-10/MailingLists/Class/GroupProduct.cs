using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingLists.Class
{
    public class GroupProduct
    {
        public GroupProduct()
        {
            this.Product = new HashSet<Product>();
            this.Stock = new HashSet<Stock>();
        }

        public int GroupProductId { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Product> Product { get; set; }
        public virtual ICollection<Stock> Stock { get; set; }
    }
}
