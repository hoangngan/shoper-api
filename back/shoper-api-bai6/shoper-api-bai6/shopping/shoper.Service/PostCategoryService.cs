using shoper.Data.Infrastucture;
using shoper.Data.Repositories;
using shoper.Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace shoper.Service
{
    public interface IPostCategoryService
    {
        void Add(PostCategory postCategory);
        void Update(PostCategory postCategory);
        void Delete(int id);
        IEnumerable<PostCategory> getAll();
        IEnumerable<PostCategory> GetAllByParentId(int Parentid);
        PostCategory GetById(int id);
        void Save();
    }
    public class PostCategoryService : IPostCategoryService
    {
        IPostCategoryRepository _postcategoryRepository;
        IUnitOfWork _unitOfWork;
        public PostCategoryService(IPostCategoryRepository postCategoryRepository, IUnitOfWork unitOfWork)
        {
            this._postcategoryRepository = postCategoryRepository;
            this._unitOfWork = unitOfWork;
        }
        public void Add(PostCategory postCategory)
        {
            _postcategoryRepository.Add(postCategory);
        }

        public void Delete(int id)
        {
            _postcategoryRepository.Delete(id);
        }

        public IEnumerable<PostCategory> getAll()
        {
            return _postcategoryRepository.GetAll();
        }

        public IEnumerable<PostCategory> GetAllByParentId(int Parentid)
        {
           return _postcategoryRepository.GetMulti(x => x.Status && x.ParentID == Parentid);
        }

        public PostCategory GetById(int id)
        {
            return _postcategoryRepository.GetSingleById(id);
        }

        public void Save()
        {
            _unitOfWork.Commit();
        }

        public void Update(PostCategory postCategory)
        {
            _postcategoryRepository.Update(postCategory);
        }
    }


}
