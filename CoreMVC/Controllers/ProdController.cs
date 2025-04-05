using CoreMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace CoreMVC.Controllers
{
    public class ProdController : Controller
    {
        Product product = new Product(2, "Robert", 23, "Laptop");

        public JsonResult getResponse()
        {
            return Json(product);
        }
    }
}
