using Kodlama.io.DataAccessLayer.Abstract;
using Kodlama.io.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kodlama.io.DataAccessLayer.Concrete
{
    public class CategoryDAL : ICategoryDAL
    {
        List<Category> categories;
        public CategoryDAL()
        {
            Category category1 = new Category
            {
                CategoryID = 1,
                CategoryName = "Tümü"
            };

            Category category2 = new Category
            {
                CategoryID = 2,
                CategoryName = "Programlama"
            };

            categories = new List<Category> { category1, category2 };
        }
        public void Add(Category t)
        {
            categories.Add(t);
        }

        public void Delete(Category t)
        {
            categories.Remove(t);
        }

        public List<Category> GetAll()
        {
            return categories;
        }

        public Category GetByID(int id)
        {
            return categories.FirstOrDefault(c => c.CategoryID == id);
        }

        public void Update(Category t)
        {
            Category existingCategory = categories.FirstOrDefault(c => c.CategoryID == t.CategoryID);

            if (existingCategory != null)
            {
                existingCategory.CategoryID = t.CategoryID;
                existingCategory.CategoryName = t.CategoryName;
            }
            else
            {
                throw new ArgumentException("Güncellenecek kategori bulunamadı.");
            }
        }
    }
}
