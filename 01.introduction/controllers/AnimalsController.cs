using _01.introduction.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace _01.introduction.controllers
{

    [Route("api/v1/[controller]")]
    [ApiController]
    public class AnimalsController : ControllerBase
    {
        private List<AnimalModel> animals;
        public AnimalsController()
        {
            animals = new List<AnimalModel>()
            {
                new AnimalModel() {Id = 1, Name = "Dog" },
                new AnimalModel() {Id = 2, Name = "Cat" },
            };
        }

        [Route("", Name = "All")]
        public ActionResult<List<AnimalModel>> GetAnimals()
        {
            return Ok(animals);
        }

        [Route("test")]
        public IActionResult GetAnimalsTest()
        {
            //return Accepted("~/api/v1/animals");
            //return AcceptedAtRoute("All");
            //return LocalRedirect("~/api/v1/animals");
            return LocalRedirectPermanent("~/api/v1/animals");
        }

        [Route("{name}")]
        public IActionResult GetAnimalsByName(string name)
        {
            if (name.Contains("abc"))
            {
                return BadRequest();
            }

            return Ok(new AnimalModel() { Id = 100, Name = name });
        }

        [Route("{name}")]
        public IActionResult GetAnimalsById(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }

            return Ok(animals.FirstOrDefault(x => x.Id == id));
        }

        [HttpPost("")]
        public IActionResult GetAnimals(AnimalModel animal)
        {
            animals.Add(animal);

            //return Created("GetAnimalsById" + animal.Id, animal);
            return CreatedAtAction("GetAnimalsById", new { id = animal.Id }, animal);
        }
    }
}
