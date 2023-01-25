using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailingLists.Class
{
    public class LineStock
    {
        public int LineStockId { get; set; }
        public int ProductId { get; set; }
        public int StockId { get; set; }
        public decimal Price { get; set; }

        public virtual Product Product { get; set; }
        public virtual Stock Stock { get; set; }
    }
}
