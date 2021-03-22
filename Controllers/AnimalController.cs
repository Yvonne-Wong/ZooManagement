using Microsoft.AspNetCore.Mvc;
using ZooManagement.Models.Database;
using ZooManagement.Models.Request;
using ZooManagement.Models.Response;
using ZooManagement.Repositories;
using System;
using System.Text;

namespace ZooManagement.Controllers 
{
    [ApiController]
    [Route("/animals")]
    public class AnimalController : ControllerBase 
    {
        private readonly IAnimalsRepo _animals;

        private readonly IEnclosuresRepo _enclosures;

        public AnimalController(IAnimalsRepo animals, IEnclosuresRepo enclosures)
        {
            _animals = animals;
            _enclosures = enclosures;
        }

        [HttpGet("")]
        public ActionResult<AnimalListResponse> Search([FromQuery] AnimalSearchRequest searchRequest) 
        {
            var animals = _animals.Search(searchRequest);
            var animalCount = _animals.Count(searchRequest);
            return AnimalListResponse.Create(searchRequest, animals, animalCount);
        }

        [HttpGet("{id}")]
        public ActionResult<AnimalResponse> GetById([FromRoute] int id)
        {
            var animal = _animals.GetById(id);
            return new AnimalResponse(animal);
        }

        [HttpPost("add")]
        public ActionResult<Animal> Add([FromBody] AddAnimalRequest newAnimal)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            
            // can the specified enclosure take that type of animal? Enclosure.AnimalTypes
            // if so, how many animals exist in the enclosure attached to newAnimal.EnclosureId 
            // how many Animals have that EnclosureId
            // is this number < Enclosure.MaxCapacity
            // if so, add the animal

            if (_enclosures.EnclosureCanTakeAnimal(newAnimal.EnclosureId, newAnimal.AnimalTypeId))
            {
                var animal = _animals.Add(newAnimal);
                return animal;
            }

            return BadRequest(ModelState);          
            
        }

        // [HttpPost("addType")]
        // public ActionResult<AnimalType> Add([FromBody] AddAnimalTypeRequest newAnimalType)
        // {
        //     if (!ModelState.IsValid)
        //     {
        //         return BadRequest(ModelState);
        //     }
            
        //     var animalType = _animals.Add(newAnimalType);

        //     return animalType;
        // }
    }
}