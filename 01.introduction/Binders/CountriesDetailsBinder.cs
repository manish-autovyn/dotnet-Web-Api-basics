using _01.introduction.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Data;
using System.Threading.Tasks;

namespace _01.introduction.Binders
{
    public class CountriesDetailsBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            var modelName = bindingContext.ModelName;
            var value = bindingContext.ValueProvider.GetValue(modelName);
            var result = value.FirstValue;

            if(!int.TryParse(result, out var id))
            {
                return Task.CompletedTask;
            }

            var model = new CountryModel()
            {
                Id = id,
                Area = 400,
                Name = "India",
                Population = 900
            };

            bindingContext.Result = ModelBindingResult.Success(model);

            return Task.CompletedTask;
        }
    }
}
