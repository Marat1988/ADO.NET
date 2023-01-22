using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECodeFirst
{
    /*Стили игры (экшен, аркада, стратегия и прочее )*/
    public class StyleGame
    {
        public int StyleGameId { get; set; }
        [MaxLength(50)]
        [Required]
        [Column(TypeName = "VARCHAR")]
        [Index(name: "IX_Game_Name", IsClustered = false, IsUnique = true)]
        public string Name { get; set; }

        public virtual ICollection<Game> Games { get; set; }
    }
}
