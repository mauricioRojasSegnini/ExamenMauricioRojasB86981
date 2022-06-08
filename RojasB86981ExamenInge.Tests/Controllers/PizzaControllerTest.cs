using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using RojasB86981ExamenInge.Controllers;
using RojasB86981ExamenInge.Models;
namespace RojasB86981ExamenInge.Tests.Controllers
{
    [TestClass]
    public class PizzaControllerTest
    {
        public PizzaController PizzaController { get; set; }

        public PizzaControllerTest()
        {
            PizzaController = new PizzaController();
        }

        [TestMethod]
        public void TestPizzaFormViewResultNotNull()
        {
            ActionResult pizzaForm = PizzaController.NewPizza();
            Assert.IsNotNull(pizzaForm);
        }

        [TestMethod]
        public void TestNewPizza() {
            ViewResult view = PizzaController.NewPizza() as ViewResult;
            Assert.AreEqual("New pizza", view.ViewName);
        }
    }
}
