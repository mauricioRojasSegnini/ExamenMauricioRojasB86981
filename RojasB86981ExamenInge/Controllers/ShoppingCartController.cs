using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RojasB86981ExamenInge.Controllers
{
    public class ShoppingCartController : Controller
    {
        // GET: ShoppingCart
        public ActionResult Cart()
        {
            return View();
        }

        public ActionResult Shipping() {
            return View();
        }
        public ActionResult PayMethod()
        {
            return View();
        }

        public ActionResult Delivery() {
            return View();
        }


    }
}