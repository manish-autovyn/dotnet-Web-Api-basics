using Microsoft.AspNetCore.Mvc;

namespace _01.introduction.controllers
{
    [ApiController]
    [Route("{controller}/{action}")]
    public class HomeController : Controller
    {
        //[Route("/get-all")]
        //[Route("index")]
        public string GetAll()
        {
            return "helo from get all";
        }

        //[Route("/get-all-authors")]
        public string GetAllAuthors()
        {
            return "hlo from get all authors";
        }

        //[Route("books/{id}")]
        [Route("{id}")]
        public string GetBook(int id)
        {
            return "hlo " + id;
        }

        //[Route("books/{id}/author/{authorId}")]
        [Route("{id}/author/{authorId}")]
        public string GetBookAuthor(int id, int authorId)
        {
            return "hlo book : " + id + "/ author :" + authorId;
        }

        //[Route("search")]
        [Route("~/search")]
        public string Search(int id, string name)
        {
            return "Hlo \nid :" + id + "\nname :" + name;
        }
    }
}
