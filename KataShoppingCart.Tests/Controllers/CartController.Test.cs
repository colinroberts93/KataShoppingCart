using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;

using KataShoppingCart;
using KataShoppingCart.Controllers;

namespace KataShoppingCart.Tests.Controllers
{
    [TestClass]
    public class CartControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            CartController controller = new CartController();
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
