using kodlama.io.DataAccess.Abstracts;
using kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io.DataAccess.Concretes
{
    internal class InstructorDal : IInstructorDal
    {
        List<Instructor> _instructors;
        public InstructorDal()
        {
            Instructor ınstructor1 = new Instructor();
            ınstructor1.Id = 1;
            ınstructor1.FirstName = "Engin";
            ınstructor1.LastName = "Demiroğ";

            Instructor ınstructor2 = new Instructor();
            ınstructor2.Id = 2;
            ınstructor2.FirstName = "Çetin";
            ınstructor2.LastName = "Yazıcı";

            _instructors= new List<Instructor> {ınstructor1, ınstructor2 };
        }
        public void Create(Instructor ınstructor)
        {
            _instructors.Add(ınstructor);
        }

        public void Delete(Instructor ınstructor)
        {
            var deletedInstructor = _instructors.First(i=>i.Id==ınstructor.Id);
            _instructors.Remove(deletedInstructor);
        }

        public void Update(Instructor ınstructor)
        {
            var updatedInstructor = _instructors.First(i=>i.Id==ınstructor.Id);
            updatedInstructor.Id=ınstructor.Id;
            updatedInstructor.FirstName=ınstructor.FirstName;
            updatedInstructor.LastName=ınstructor.LastName;
        }

        public List<Instructor> GettAll()
        {
            return _instructors;
        }
    }
}
