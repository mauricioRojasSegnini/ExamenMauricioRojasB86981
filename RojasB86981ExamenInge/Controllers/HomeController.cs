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
            List<PizzaMenuModel> pizzaMenu = Json_ContentParser.GetContentsFromJson<PizzaMenuModel>("pizzaMenu.json", Json_ContentParser.GetProductsOnMenuFromJson);
            List<PizzaMenuModel> burgerMenu = Json_ContentParser.GetContentsFromJson<PizzaMenuModel>("burgersOnMenu.json", Json_ContentParser.GetProductsOnMenuFromJson);
            List<PizzaMenuModel> drinks = Json_ContentParser.GetContentsFromJson<PizzaMenuModel>("drinksOnMenu.json", Json_ContentParser.GetProductsOnMenuFromJson);

            List<PersonalPizzaModel> personalPizza = Json_ContentParser.GetContentsFromJson<PersonalPizzaModel>("personalOrders.json", Json_ContentParser.GetPersonalPizzaFromJson);

            ViewBag.PersonalPizza = personalPizza;
            ViewBag.PizzasOnMenu = pizzaMenu;
            ViewBag.BurgersOnMenu = burgerMenu;
            ViewBag.DrinksOnMenu = drinks;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

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
    }
}