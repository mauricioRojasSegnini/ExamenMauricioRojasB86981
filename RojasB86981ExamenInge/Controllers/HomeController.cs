using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RojasB86981ExamenInge.Models;
namespace RojasB86981ExamenInge.Controllers
{
    public class HomeController : Controller
    {
        public JsonContentParser Json_ContentParser { get; set; }

        public HomeController() {
            Json_ContentParser = new JsonContentParser();
        }
        public ActionResult Index()
        {
            ViewBag.Title = "Segninis pizza";
            ViewBag.PizzasOnMenu = Json_ContentParser.GetContentsFromJson<PizzaMenuModel>("pizzaMenu.json", Json_ContentParser.GetProductsOnMenuFromJson);  
            ViewBag.PersonalPizza = Json_ContentParser.GetContentsFromJson<PersonalPizzaModel>("personalOrders.json", Json_ContentParser.GetPersonalPizzaFromJson); ;
            ViewBag.BurgersOnMenu = Json_ContentParser.GetContentsFromJson<PizzaMenuModel>("burgersOnMenu.json", Json_ContentParser.GetProductsOnMenuFromJson); ;
            ViewBag.DrinksOnMenu = Json_ContentParser.GetContentsFromJson<PizzaMenuModel>("drinksOnMenu.json", Json_ContentParser.GetProductsOnMenuFromJson); ;
            ViewBag.ValorInicialParaTest = 12;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Nuestro restaurante";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Nuestros contactos";

            return View();
        }

        public ActionResult Location()
        {
            return View();
        }

        public ActionResult OurHistory()
        {
            return View();
        }

        public ActionResult Confirmation() {
            return View();
        }
    }
}