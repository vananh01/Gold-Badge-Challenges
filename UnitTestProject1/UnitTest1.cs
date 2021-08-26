using Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        private MenuRepository _repo;
        private Menu _meal;

        [TestInitialize]
        public void Arrange()
        {
            _repo = new MenuRepository();
            _meal = new Menu(1, "Pizza", "Best Pizza Ever", "Flour, pepperoni, cheese", 10.99d);
            _repo.AddMenuItem(_meal);
        }


        [TestMethod]
        public void AddContent()
        {
            MenuRepository repo = new MenuRepository();
            Menu meal = new Menu();
            meal.MealName = "Icecream";
            bool addItem = repo.AddMenuItem(meal);
            Assert.IsTrue(addItem);

        }
    }
}
