
using System.Web.Mvc;
using RojasB86981ExamenInge.Models;

namespace RojasB86981ExamenInge.Controllers
{
    public class PizzaController : Controller
    {
        public JsonContentParser Json_ContentParser = new JsonContentParser();
        
        // GET: Pizza
        public ActionResult NewPizza()
        {
            return View("");
        }

        [HttpPost]
        public ActionResult SubmitPizza(PersonalPizzaModel personalPizzaOrder)
        {
            ActionResult view = RedirectToAction("NewPizza", "Pizza");
            personalPizzaOrder.Ingredients = Request.Form["Ingredients"];
            personalPizzaOrder.Extras = Request.Form["Extras"];
            personalPizzaOrder.tag = personalPizzaOrder.name;
            personalPizzaOrder.inCart = 0;
            ViewBag.SuccessOnCreation = false;
            try
            {
                ViewBag.SuccessOnCreation = Json_ContentParser.WriteToJsonFile<PersonalPizzaModel>("personalOrders.json", personalPizzaOrder, Json_ContentParser.GetPersonalPizzaFromJson);
                if (ViewBag.SuccessOnCreation)
                {
                    view = RedirectToAction("Index", "Home");
                    ViewBag.Message = "La pizza fue agregado con éxito";
                    ModelState.Clear();
                }
            }
            catch
            {
                ViewBag.Message = "Algo salió mal y no fue posible crear la pizza";
            }
            return view;
        }
    }
}