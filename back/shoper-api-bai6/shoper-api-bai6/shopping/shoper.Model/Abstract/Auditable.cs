using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        public   DateTime? CreattedDate { set; get; }
        public string CreatedBy { set; get; }
        public DateTime? UpdateDate { set; get; }
        public  string UpdatedBy { set; get; }
        public string MetaKeyword { set; get; }
        public string MetaDescription { set; get; }
        public bool Status { set; get; }
    }
}
