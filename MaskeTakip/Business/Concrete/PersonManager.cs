using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    //Çıplak class kalmasın
    public class PersonManager : IAplicantService
    {
        //encapulation
        //maske başvuru oluşturmak için 
        public void ApplyForMaske(Person person)
        {

        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool isCheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);

            return client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest(
                    new TCKimlikNoDogrulaRequestBody(person.nationalIdentity,person.firsName, person.lastName, person.dateOfBirthYear)))
                .Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
