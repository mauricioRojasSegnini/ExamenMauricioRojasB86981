using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RojasB86981ExamenInge;
using RojasB86981ExamenInge.Controllers;

namespace RojasB86981ExamenInge.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        public HomeController MenuController { get; set; }

        public HomeControllerTest()
        {
            MenuController = new HomeController();
        }

        [TestMethod]
        public void Index()
        {
            // Act
            ViewResult result = MenuController.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Nuestro restaurante", result.ViewBag.Message);
        }

        [TestMethod]
        public void TestAboutViewNotNull()
        {
            ActionResult aboutView = MenuController.About();
            Assert.IsNotNull(aboutView);
        }

        [TestMethod]
        public void Contact()
        {
            // Act
            ViewResult result = MenuController.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void TestMenuViewResultNotNull() {
            ActionResult vista = MenuController.Index();

            Assert.IsNotNull(vista);
        }

        [TestMethod]
        public void TestLocationViewResultNotNull()
        {
            ActionResult vista = MenuController.Location();

            Assert.IsNotNull(vista);
        }

        [TestMethod]
        public void TestConfirmationViewResultNotNull()
        {
            ActionResult vista = MenuController.Confirmation();

            Assert.IsNotNull(vista);
        }

        

        [TestMethod]
        public void TestIndexViewBagTitleIsNotNull() {

            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.AreNotEqual(null, result.ViewBag.Title as string);

        }

        [TestMethod]

        public void TestNumberOfProductsOnMenu() {
            int numberOfProductsOnMenu = 12;
            ViewResult view = MenuController.Index() as ViewResult;
            Assert.AreEqual(numberOfProductsOnMenu, view.ViewBag.ValorInicialParaTest);
        }

        





    }
}
