using _01.introduction.Binders;
using _01.introduction.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace _01.introduction.controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [BindProperties(SupportsGet = true)]
    public class CountriesController : ControllerBase
    {
        //[BindProperty(SupportsGet = true)]
        public CountryModel Country { get; set; }

        [HttpGet("")]
        public IActionResult GetCountry()
        {
            return Ok($"Name = {this.Country.Name}, \nPopulation = {this.Country.Population}, \nArea = {this.Country.Area}");
        }

        //[HttpPost("")]
        //public IActionResult AddCountry()
        //{
        //    return Ok($"Name = {this.Country.Name}, \nPopulation = {this.Country.Population}, \nArea = {this.Country.Area}");
        //}



        // get data from queryonly
        //[HttpPost("{name}")]
        //public IActionResult AddCountry([FromQuery] string name)
        //{
        //    return Ok($"Name = {name}");
        //}

        //[HttpPost("")]
        //public IActionResult AddCountry([FromQuery] CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}, \nPopulation = {country.Population}, \nArea = {country.Area}");
        //}


        // get data from route
        //[HttpPost("{Name}/{Population}/{Area}")]
        //public IActionResult AddCountry([FromRoute] CountryModel country)
        //{
        //    return Ok($"Name = {country.Name}, \nPopulation = {country.Population}, \nArea = {country.Area}");
        //}



        // get data from both query and route
        [HttpPost("{Name}/{Population}/{Area}")]
        public IActionResult AddCountry([FromRoute] CountryModel country, [FromQuery] int id)
        {
            return Ok($"Id = {id}, \nName = {country.Name}, \nPopulation = {country.Population}, \nArea = {country.Area}");
        }

        // similarly we can use FromBody FromForm FromHeader also



        // using Custom Binder
        /* http://localhost:60977/api/v1/countries/search/?countries=India|China|USA|Russia */

        [HttpPost("search")]
        public IActionResult searchCountries([ModelBinder(typeof(CountriesBinder))] string[] countries)
        {
            return Ok(countries);
        }


        [HttpGet("{id}")]
        public IActionResult CountryDetails([ModelBinder(Name = "Id")] CountryModel country)
        {
            return Ok(country);
        }
    }
}
