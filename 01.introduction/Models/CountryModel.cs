using _01.introduction.Binders;
using Microsoft.AspNetCore.Mvc;

namespace _01.introduction.Models
{
    [ModelBinder(typeof(CountriesDetailsBinder))]
    public class CountryModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Population { get; set; }
        public int Area { get; set; }
    }
}
