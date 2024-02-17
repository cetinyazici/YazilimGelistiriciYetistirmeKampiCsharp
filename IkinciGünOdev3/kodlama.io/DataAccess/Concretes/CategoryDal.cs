using kodlama.io.DataAccess.Abstracts;
using kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io.DataAccess.Concretes
{
    public class CategoryDal : ICategoryDal
    {
        List<Category> _categories;
        public CategoryDal()
        {
            Category category1 = new Category();
            category1.Id = 1;
            category1.CategoryName = "Yazılım";

            Category category2 = new Category();
            category2.Id = 2;
            category2.CategoryName = "Bilişim";

            _categories = new List<Category> { category1, category2 };
        }
        public void Create(Category category)
        {
            _categories.Add(category);
            Console.WriteLine("Kategori başarıyla eklendi.");
        }

        public void Delete(Category category)
        {
            var deletedCategory = _categories.First(c => c.Id == category.Id);
            _categories.Remove(deletedCategory);
            Console.WriteLine("Kategori başarıyla silindi.");

        }

        public void Update(Category category)
        {
            var updatedCategory = _categories.First(c => c.Id == category.Id);
            updatedCategory.Id = category.Id;
            updatedCategory.CategoryName = category.CategoryName;
            Console.WriteLine("Kategori başarıyla güncellendi.");

        }

        public List<Category> GetAll()
        {
            return _categories;
        }
    }
}
