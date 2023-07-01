using Microsoft.VisualStudio.TestTools.UnitTesting;
using l10z1.Models;
namespace l10z1.Tests
{
    [TestClass]
    public class Testing
    {

        [TestMethod]
        public void TestCatgoryName()
        {
            Category cat = new Category(1, "Bułki");
            Assert.AreEqual(cat.Name, "Bułki");
        }
        [TestMethod]
        public void TestCategoryArticles()
        {
            Category cat = new Category(1, "Bułki");
            Assert.AreEqual(cat.Articles, null);
        }
        [TestMethod]
        public void TestArticlePrice()
        {
            Category cat = new Category(1, "Bułki");
            Article art = new Article();
            art.Name = "Bułka";
            art.Category = cat;
            art.CategoryId = 1;
            art.Id = 1;
            art.Price = 2.5;
            Assert.AreEqual(art.Price , 2.5);
        }
        [TestMethod]
        public void TestArticleName()
        {
            Category cat = new Category(1, "Bułki");
            Article art = new Article();
            art.Name = "Bułka";
            art.Category = cat;
            art.CategoryId = 1;
            art.Id = 1;
            art.Price = 2.5;
            Assert.AreEqual(art.Name, "Bułka");
        }
    }
}