using Business.Abstract;
using Entities.Concrete;
using MernisServiceReference;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
    {
        // Encapsulation
        public void ApplyForMask(Person person)
        {
        }

        public List<Person> GetList()
        {
            return null;
        }

        public bool CheckPerson(Person person)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            Task<TCKimlikNoDogrulaResponse> tcKimlikTask = client.TCKimlikNoDogrulaAsync(person.NationalIdentity,person.FirstName,person.LastName,person.DateOfBirthYear);
            return tcKimlikTask.Result.Body.TCKimlikNoDogrulaResult;
        }
    }
}
