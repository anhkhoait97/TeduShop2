using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Models
{
    [Table("Footers")]
    public class Footer
    {
        [Key]
        [Column(TypeName = "varchar")]
        [MaxLength(50)]
        public string ID { set; get; }
        [Required]
        public string Content { get; set; }
    }
}
