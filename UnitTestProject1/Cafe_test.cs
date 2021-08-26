using Cafe;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;


namespace UnitTestProject1
{
    [TestClass]
    public class Cafe_test
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
        public void Addcontent()
        {

            Menu newMeal = new Menu(10, "www", "description", "food, food", 10d);
            Assert.IsFalse(_repo.IfItemInMenu(10));
            _repo.AddMenuItem(newMeal);
            Assert.IsTrue(_repo.IfItemInMenu(10));
        }


        [TestMethod]
        public void RemoveItem()
        {
            Menu newMeal = new Menu(10, "www", "description", "food, food", 10d);
            _repo.AddMenuItem(newMeal);
            Assert.AreEqual(true, _repo.IfItemInMenu(10));
            _repo.DeleteItem(10);
            Assert.AreEqual(false, _repo.IfItemInMenu(10));

        }



    }
}
