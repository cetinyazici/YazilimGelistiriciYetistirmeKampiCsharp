using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {
        private IAplicantService _aplicantService;

        //Constructor->oluşturucu new lendiğinde çalışır.
        public PttManager(IAplicantService aplicantService)
        {
            _aplicantService = aplicantService;
        }

        public void GiveMask(Person person)
        {
            if (_aplicantService.isCheckPerson(person)==true)
            {
                Console.WriteLine(person.firsName + " için baske verildi.");
            }
            else
            {
                Console.WriteLine(person.firsName + " için baske verilmedi.");
            }
        }
    }
}
