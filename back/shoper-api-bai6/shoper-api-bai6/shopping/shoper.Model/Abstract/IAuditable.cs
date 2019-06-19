using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Model.Abstract
{
    public interface  IAuditable
    { // cac  truong name nay co trong table product
        DateTime? CreattedDate { set; get; }
        string CreatedBy { set; get; }
        DateTime? UpdateDate { set; get; }
        string UpdatedBy { set; get; }
        string MetaKeyword { set; get; }
        string MetaDescription { set; get; }
        bool Status { set; get; }
    }
}
