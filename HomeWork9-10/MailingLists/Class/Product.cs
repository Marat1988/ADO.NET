using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingLists.Class
{
    public class Product
    {
        public Product()
        {
            this.LineStock = new HashSet<LineStock>();
        }

        public int ProductId { get; set; }
        public string Name { get; set; }
        public int GroupProductId { get; set; }

        public virtual GroupProduct GroupProduct { get; set; }
        public virtual ICollection<LineStock> LineStock { get; set; }
    }
}
