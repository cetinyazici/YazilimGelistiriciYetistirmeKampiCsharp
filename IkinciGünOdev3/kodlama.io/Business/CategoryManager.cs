using kodlama.io.DataAccess.Abstracts;
using kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io.Business
{
    public class CategoryManager
    {
        private readonly ICategoryDal _categoryManager;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryManager = categoryDal;
        }

        public void Create(Category category)
        {
            _categoryManager.Create(category);
        }

        public void Delete(Category category)
        {
            _categoryManager.Delete(category);
        }

        public void Update(Category category)
        {
            _categoryManager.Update(category);
        }

        public List<Category> GetAll()
        {
            return _categoryManager.GetAll();
        }

    }
}
