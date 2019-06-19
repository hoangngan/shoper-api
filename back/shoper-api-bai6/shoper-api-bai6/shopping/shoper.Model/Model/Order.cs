using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Model.Model
{
    [Table("Orders")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }
      
        [MaxLength(256)]
        public string CustomerEmail { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerPhone { set; get; }
        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }
        [MaxLength(256)]
        public string PaymentMenthod { set; get; }

        public DateTime? CreatedDate { set; get; }
        public string CreatedBy { set; get; }
        public string PaymentStatus { set; get; }
        public bool Status { set; get; }
        // con thieu bang user 
        //lk bang  productdetails

        public  virtual ICollection<OrderDetails> OrderDetails { set; get; }
    }
}
