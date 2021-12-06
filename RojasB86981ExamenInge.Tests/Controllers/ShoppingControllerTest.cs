using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using RojasB86981ExamenInge.Controllers;

namespace RojasB86981ExamenInge.Tests.Controllers
{
    [TestClass]
    public class ShoppingControllerTest
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void TestCartViewResultNotNull()
        {
            ShoppingCartController shoppingController = new ShoppingCartController();
            ActionResult vista = shoppingController.Cart();
            Assert.IsNotNull(vista);
        }

        [TestMethod]
        public void TestShippingViewResultNotNull()
        {
            ShoppingCartController shoppingController = new ShoppingCartController();
            ActionResult vista = shoppingController.Shipping();
            Assert.IsNotNull(vista);
        }

        [TestMethod]
        public void TestPayMethodViewResultNotNull()
        {
            ShoppingCartController shoppingController = new ShoppingCartController();
            ActionResult vista = shoppingController.PayMethod();
            Assert.IsNotNull(vista);
        }

        [TestMethod]
        public void TestDeliveryViewResultNotNull()
        {
            ShoppingCartController shoppingController = new ShoppingCartController();
            ActionResult vista = shoppingController.Delivery();
            Assert.IsNotNull(vista);
        }

        [TestMethod]
        public void TestCart()
        {
            ShoppingCartController shoppingController = new ShoppingCartController();
            ViewResult view = shoppingController.Cart() as ViewResult;
            Assert.AreEqual("Carrito de compras", view.ViewName);
        }

        [TestMethod]
        public void TestShipping()
        {
            ShoppingCartController shoppingController = new ShoppingCartController();
            ViewResult view = shoppingController.Shipping() as ViewResult;
            Assert.AreEqual("Formulario de entrega a domicilio", view.ViewName);
        }
        [TestMethod]
        public void TestPayMethod()
        {
            ShoppingCartController shoppingController = new ShoppingCartController();
            ViewResult view = shoppingController.PayMethod() as ViewResult;
            Assert.AreEqual("Sistema de pago", view.ViewName);
        }
        [TestMethod]
        public void TestDelivery()
        {
            ShoppingCartController shoppingController = new ShoppingCartController();
            ViewResult view = shoppingController.Delivery() as ViewResult;
            Assert.AreEqual("Método de entrega", view.ViewName);
        }
    }
}
