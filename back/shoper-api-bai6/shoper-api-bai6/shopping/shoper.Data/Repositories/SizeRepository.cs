using shoper.Data.Infrastucture;
using shoper.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Data.Repositories
{
    public class SizeRepository : RepositoryBase<Size>, ISizeRepository
    {
        public SizeRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    internal interface ISizeRepository : IRepository<Size>
    {
    }
}
