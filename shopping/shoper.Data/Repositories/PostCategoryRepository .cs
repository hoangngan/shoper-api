using shoper.Data.Infrastucture;
using shoper.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Data.Repositories
{
    public class PostCategoryRepository : RepositoryBase<PostCategory> , IPostCategoryRepository
    {
        public PostCategoryRepository(IDbFactory dbFactory) : base(dbFactory)
        {
        }
    }

    public interface IPostCategoryRepository : IRepository<PostCategory>
    {
    }
}
