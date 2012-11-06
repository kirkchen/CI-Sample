using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CI_Sample.WebSite.Controllers
{
    public class CalculateController : Controller
    {
        public IPriceDiscountService DiscountService { get; set; }

        public CalculateController()
        {
            this.DiscountService = new PriceDiscountService();
        }

        public ActionResult Index()
        {
            this.ViewBag.Enviroment = ConfigurationManager.AppSettings["Enviroment"];
            return View();
        }

        // FIX: Login Only
        public JsonResult CalculateDiscount(double totalPrice)
        {
            var result = this.DiscountService.Calculate(totalPrice);

            return Json(new { DiscountPrice = result });
        }
    }
}