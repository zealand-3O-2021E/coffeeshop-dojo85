using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopConsoleApp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace CoffeeShopTestProject
{
    [TestClass]
    public class CombinedTests
    {
        [DataTestMethod]
        [DataRow(-1)]
        [DataRow(6)]
        public void Discount_InvalidValue_ThrowsException_Test(int discount)
        {
            // Arrange
            var mock = new Mock<Coffee>();
            var coffee = mock.Object;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => coffee.Discount = discount);
        }

        //If your data cannot be set into an attribute parameter(non-constant values or complex objects),
        //you can use the[DynamicData] attribute.
        //This attribute allows getting the values of the parameters from a method or a property.
        //The method or the property must return an IEnumerable<object[]>.
        //Each row corresponds to the values of a test.

        // Test of Price() method
        [DataTestMethod]
        [DynamicData(nameof(GetPriceTestData), DynamicDataSourceType.Method)]
        public void PriceMethod_ForEachCoffeeSort_Test(Coffee coffee, int expectedValue)
        {
            var actual = coffee.Price();

            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> GetPriceTestData()
        {
            yield return new object[] { new BlackCoffee(), 20};
            yield return new object[] { new Americano(), 30};
            yield return new object[] { new FlatWhite(), 35};
            yield return new object[] { new Cortado(), 25};
            yield return new object[] { new Latte(), 40};
        }


        // Test of Strength() method
        [DataTestMethod]
        [DynamicData(nameof(GetStrengthTestData), DynamicDataSourceType.Method)]
        public void StrengthMethod_ForEachCoffeeSort_Test(Coffee coffee, string expectedValue)
        {
            var actual = coffee.Strength();

            Assert.AreEqual(expectedValue, actual);
        }

        public static IEnumerable<object[]> GetStrengthTestData()
        {
            yield return new object[] { new BlackCoffee(), "Strong" };
            yield return new object[] { new Americano(), "Strong" };
            yield return new object[] { new FlatWhite(), "Weak" };
            yield return new object[] { new Cortado(), "Medium" };
            yield return new object[] { new Latte(), "Weak" };
        }
    }
}
