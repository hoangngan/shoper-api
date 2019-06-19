using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Model.Model
{
    [Table("ProductImages")]
    public class ProductImage
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public int ProductID { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product product { set; get; }
        [MaxLength(250)]
        public string Path { set; get; }
        [MaxLength(250)]
        public string Caption { set; get; }
    }
}
