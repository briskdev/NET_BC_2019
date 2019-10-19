using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace WebShop.Logic.Tests
{
    [TestClass]
    public class CategoryTests
    {
        [TestMethod]
        public void TestGetAll()
        {
            var manager = new CategoryManager();
            manager.Seed();
            var categories = manager.GetAll();

            Assert.AreEqual("Electronics", categories[0].Title);
            Assert.AreEqual(3, categories.Count);
        }

        [TestMethod]
        public void TestGet()
        {
            var manager = new CategoryManager();
            manager.Seed();
            var category1 = manager.Get(1);
            var category2 = manager.Get(2);
            var category3 = manager.Get(56);

            Assert.AreEqual("Electronics", category1.Title);
            Assert.AreEqual("Phones", category2.Title);
            Assert.IsNull(category3);
        }
    }
}
