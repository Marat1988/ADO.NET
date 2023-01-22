using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BECodeFirst
{
    /*Класс игр*/
    public class Game
    {
        public int GameId { get; set; }
        [MaxLength(100)]
        [Required]
        [Column(TypeName = "VARCHAR")]
        [Index(name:"IX_Game_Name",IsClustered =false,IsUnique =true)]
        public string Name { get; set; }
        [Required]
        [Column(TypeName = "DATETIME")]
        public DateTime ReleaseDate { get; set; }
        //fully defined relationship
        [Required]
        public int StyleGameId { get; set; }
        [Required]
        public int CompanyId { get; set; }
        [ForeignKey("StyleGameId")]
        public virtual StyleGame StyleGame { get; set; }
        [ForeignKey("CompanyId")]
        public virtual Company Company { get; set; }
    }
}
