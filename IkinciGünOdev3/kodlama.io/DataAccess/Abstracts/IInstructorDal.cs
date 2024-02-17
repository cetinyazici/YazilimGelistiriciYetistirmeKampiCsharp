using kodlama.io.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kodlama.io.DataAccess.Abstracts
{
    public interface IInstructorDal
    {
        List<Instructor> GettAll();
        void Create(Instructor ınstructor);
        void Delete(Instructor ınstructor);
        void Update(Instructor ınstructor);
    }
}
