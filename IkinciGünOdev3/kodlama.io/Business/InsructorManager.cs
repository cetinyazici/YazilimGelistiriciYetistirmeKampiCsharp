using kodlama.io.DataAccess.Abstracts;
using kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io.Business
{
    public class InsructorManager
    {
        private readonly IInstructorDal _ınstructorManager;

        public InsructorManager(IInstructorDal ınstructorDal)
        {
            _ınstructorManager = ınstructorDal;
        }

        public void Create(Instructor ınstructor)
        {
            _ınstructorManager.Create(ınstructor);
        }

        public void Deleted(Instructor ınstructor)
        {
            _ınstructorManager.Delete(ınstructor);
        }

        public void Update(Instructor ınstructor)
        {
            _ınstructorManager.Update(ınstructor);
        }

        public List<Instructor> GetAll()
        {
            return _ınstructorManager.GettAll();
        }
    }
}
