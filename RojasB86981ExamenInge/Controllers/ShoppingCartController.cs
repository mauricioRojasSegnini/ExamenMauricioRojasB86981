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
            return View("Carrito de compras");
        }

        public ActionResult Shipping() {
            return View("Formulario de entrega a domicilio");
        }
        public ActionResult PayMethod()
        {
            return View("Sistema de pago");
        }

        public ActionResult Delivery() {
            return View("Método de entrega");
        }


    }
}