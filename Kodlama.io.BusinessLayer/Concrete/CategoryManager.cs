using Kodlama.io.BusinessLayer.Abstract;
using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.BusinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDAL _categoryDAL;

        public CategoryManager(ICategoryDAL categoryDAL)
        {
            _categoryDAL = categoryDAL;
        }

        public void Add(Category t)
        {
            _categoryDAL.Add(t);
        }

        public void Delete(Category t)
        {
            _categoryDAL.Delete(t);
        }

        public List<Category> GetAll()
        {
            return _categoryDAL.GetAll();
        }

        public Category GetById(int id)
        {
            return _categoryDAL.GetByID(id);
        }

        public void Update(Category t)
        {
            _categoryDAL.Update(t);
        }
    }
}
