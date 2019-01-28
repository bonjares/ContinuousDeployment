using Microsoft.VisualStudio.TestTools.UnitTesting;
using ContinuousWeb.Controllers;

namespace ContinuousWeb.Tests
{
    [TestClass]
    public class HomeControllerTests
    {
        [TestMethod]
        public void PrivacyPageTest()
        {
            var homeController = new HomeController();
            var result = homeController.Privacy();
        }
    }
}
