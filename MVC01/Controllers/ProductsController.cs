using Microsoft.AspNetCore.Mvc;
namespace MVC01.Controllers
{
    public class ProductsController : Controller
    {
        //public string Test()
        //        {
        //            return $"Hello From Test";
        //        }
        //  [HttpGet]
        //   public IActionResult Test()
        //  {
        //ContentResult result = new ContentResult();
        //result.ContentType = "text/html";
        //result.Content = $"Hello From Test </br> Bye";
        //result.StatusCode = StatusCodes.Status200OK;
        //return result;
        //Helper Method=========

        //if (true)
        //    return Content(content: $"Hello From Test </br> Bye", contentType: "text/html");
        //else
        //    return NotFound();
        //       }

        [HttpGet]
        public IActionResult Index()
        {
            return View(); 
        }
    }
}

