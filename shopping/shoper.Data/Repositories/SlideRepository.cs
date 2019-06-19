using shoper.Data.Infrastucture;
using shoper.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Data.Repositories
{
    public class SlideRepository : RepositoryBase<Slide>, ISLideRepository
    {
        public SlideRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface ISLideRepository  : IRepository<Slide>
    {
    }
}
