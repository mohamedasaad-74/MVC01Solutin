using Microsoft.AspNetCore.Mvc;
using MVC01.Models;
namespace MVC01.Controllers
{
    public class ProductsController : Controller
    {
        #region Action


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

        //[HttpGet]
        //public IActionResult Index()
        //{
        //    return View(); 
        //}
        //        [HttpGet]
        //        public IActionResult GetProducts()
        //        {
        //            var Products = new List<Product>()
        //            {
        //new Product() {Id = 1 , Name = "Mobile "},
        //new Product() {Id = 2, Name = "Tap "}
        //            };
        //            return Json(Products);
        //        }
        //        [NonAction]
        //        public IActionResult Test()
        //        {
        //            return View();
        //        }
        //public IActionResult GetProductById(int id)
        //{
        //    if (id < 0)
        //        return BadRequest();
        //    else if (id == 0)
        //        return RedirectToAction(nameof(GetProducts));
        //    else if (id < 10)
        //        return NotFound();
        //    else
        //        return Json(new Product() { Id = id, Name = "Tap" });

        //}
        //        [HttpGet]
        //public IActionResult RedirectAction()
        //        {
        //            return Redirect("Url");
        //        }
        #endregion
        #region Routing

        //public IActionResult TestRouting()
        //        {
        //            return Json($"Hello from TestRouting");
        //        }

        //[HttpGet("TestingRoute/Test{id:int}")]
        //public IActionResult TestRouting(int id)
        //{
        //    return Json($"Hello With Id ; {id} ");
        //}

        //public IActionResult testRouting (int id , string name)
        //{
        //    return Json($"Hello from tstRouting: ID ->{id},Name ->{name} ");
        //}

        //[HttpGet("Json")]
        //public IActionResult JesonAction()
        //{
        //    return Json("hello from action ");
        //}

        //[HttpGet("productCode/{code:int}")]
        //public IActionResult GetProductBycode (int code)
        //{
        //    return Json(new Product() { Id = code, Name = "Mobile" });
        //}

        #endregion
        #region Model binding
     //simple data
        //public IActionResult GetById(int id , int autherId)
        //{
        //    return Json(new { id, autherId });
        //}
        //complex data
        //[HttpGet]
        //public IActionResult Search(ProductFilter filter)
        //{
        //    return Content("Dearch Completed");
        //}
        //collection
       // [HttpGet]
        //public IActionResult GetByIds(int[] ids)
        //{
        //    return Json(new
        //    {
        //        ids
        //    }
        //        );
        //}
        #endregion
    }
}

