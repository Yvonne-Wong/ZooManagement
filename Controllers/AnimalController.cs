using Microsoft.AspNetCore.Mvc;
// using ZooManagement.Models.Request;
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

        public AnimalController(IAnimalsRepo animals)
        {
            _animals = animals;
        }

        [HttpGet("{id}")]
        public ActionResult<AnimalResponse> GetById([FromRoute] int id)
        {
            var animal = _animals.GetById(id);
            return new AnimalResponse(animal);
        }
    }
}