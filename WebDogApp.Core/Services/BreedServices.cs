using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDogApp.Core.Contacts;
using WebDogApp.Infrastracture.Data;
using WebDogApp.Infrastracture.Data.Domain;

namespace WebDogApp.Core.Services
{
    public class BreedServices:IBreedService
    {
        private readonly ApplicationDbContext _context;

        public BreedServices(ApplicationDbContext context)
        {
            _context = context;
        }

        public Breed GetBreedById(int breedId)
        {
            return _context.Breeds.Find(breedId);
        }

        public List<Breed> GetBreeds()
        {
            List<Breed> breeds = _context.Breeds.ToList();
            return breeds;
        }

        public List<Dog> GetDogsByBreed(int breedId)
        {
            return _context.Dogs
                .Where(x => x.BreedId == breedId)
                .ToList();
        }
    }
}
