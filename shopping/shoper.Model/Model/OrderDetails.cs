using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Model.Model
{
    [Table("OrderDetails")]
    public   class OrderDetails
    {
        [Key]
        [Column(Order=1)]
        public int OrderId { set; get; }
        [Key]
        [Column(Order=2)]
        public int ProductID { set; get; }
        public int Quantity { set; get; }
        public Decimal Price { set; get; }
        public int ColorId { set; get; }
        public int SizeId { set; get; }
        [ForeignKey("OrderID")]
        public virtual Order order { set; get; }
        [ForeignKey("ProductID")]
        public virtual Product Product { set; get; }
        [ForeignKey("SizeID")]
        public virtual Size Size { set; get; }

    }
}
