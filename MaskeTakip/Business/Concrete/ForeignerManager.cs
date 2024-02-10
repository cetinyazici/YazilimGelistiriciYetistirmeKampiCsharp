using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IAplicantService
    {
        //SonarQube: yazılım kalitesi için bakılır.
        public void ApplyForMaske(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Person> GetList()
        {
            throw new NotImplementedException();
        }

        public bool isCheckPerson(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
