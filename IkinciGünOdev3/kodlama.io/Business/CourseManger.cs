using kodlama.io.DataAccess.Abstracts;
using kodlama.io.DataAccess.Concretes;
using kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io.Business
{
    public class CourseManger
    {
        private readonly ICourseDal _courseDal;

        public CourseManger(ICourseDal courseDal)
        {
            _courseDal = courseDal;
        }

        public void Create(Course course)
        {
            _courseDal.Create(course);
        }

        public void Delete(Course course)
        {
            _courseDal.Delete(course);
        }

        public void Update(Course course)
        {
            _courseDal.Update(course);
        }

        public List<Course> GetAll()
        {
            return _courseDal.GetAll();
        }

    }
}
