using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.TagHelpers;

namespace _01.introduction.controllers
{

    [Route("api/{controller}")]
    [ApiController]
    public class BooksController : Controller
    {
        [Route("{id:int:min(10):max(100)}")]  // can also use range(10,100)
        public string GetById(int id)
        {
            return "hlo id : " + id;
        }

        [Route("{name:minlength(5):maxlength(20):alpha}")]   // can also use length(10) for fix size of 10
        public string GetByName(string name)
        {
            return "hlo name : " + name;
        }

        [Route("byauthor/{userName:regex(a(b|c))}")]  
        public string GetByUserName(string userName)
        {
            return "hlo author : " + userName;
        } 
    }
}
