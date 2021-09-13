using Microsoft.VisualStudio.TestTools.UnitTesting;
using CoffeeShopConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopTestProject
{
    [TestClass()]
    public class AmericanoTests
    {
        //[TestMethod()]
        //public void PriceTest()
        //{
        //    var coffee = new Americano();

        //    var price = coffee.Price();

        //    Assert.AreEqual(30, price);
        //}

        //[DataTestMethod]
        //[DataRow(3, 27)]
        //[DataRow(1, 29)]
        //public void Price_WithValidDiscount_Test(int discount, int expectedValue)
        //{
        //    var coffee = new Americano(discount);

        //    var price = coffee.Price();

        //    Assert.AreEqual(expectedValue, price);
        //}

        //[TestMethod()]
        //public void StrengthTest()
        //{
        //    var flat = new Americano();

        //    var str = flat.Strength();

        //    Assert.AreEqual("Strong", str);
        //}

        //[DataTestMethod]
        //[DataRow(-1)]
        //[DataRow(6)]
        //public void ConstructorWithInvalidDiscount_ThrowsException_Test(int discount)
        //{
        //    Assert.ThrowsException<ArgumentException>(() => new Americano(discount));
        //}
    }
}