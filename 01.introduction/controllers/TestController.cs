using Microsoft.AspNetCore.Mvc;

namespace _01.introduction.controllers
{
    [ApiController]
    [Route("/")]
    public class TestController : ControllerBase
    {
        public string Root()
        {
            return "hello from root !";
        }

        [Route("/home")]
        public string Home()
        {
            return "hello from home route !";
        }
    }
}
