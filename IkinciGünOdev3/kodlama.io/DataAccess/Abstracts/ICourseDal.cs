using kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io.DataAccess.Abstracts
{
    public interface ICourseDal
    {
        List<Course> GetAll();
        void Create(Course course);
        void Update(Course course);
        void Delete(Course course);
    }
}
