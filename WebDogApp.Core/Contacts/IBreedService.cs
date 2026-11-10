using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDogApp.Infrastracture.Data.Domain;

namespace WebDogApp.Core.Contacts
{
    public interface IBreedService
    {
        List<Breed> GetBreeds();
        Breed GetBreedById(int BreedId);
        List<Dog> GetDogsByBreed(int BreedId);
    }
}
