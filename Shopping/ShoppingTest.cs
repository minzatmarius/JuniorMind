using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Shopping
{
    [TestClass]
    public class ShoppingTest
    {
        [TestMethod]
        public void TotalShouldBe9()
        {
            Item[] items = new Item[] { new Item("Apple", 2), new Item("Milk", 4), new Item("Bread", 3) };
            Assert.AreEqual(9, CalculateTotalPrice(items));
        }

        struct Item
        {
            public string name;
            public decimal price;

            public Item(string name, decimal price)
            {
                this.name = name;
                this.price = price;
            }
        }


        decimal CalculateTotalPrice(Item[] items)
        {
            decimal total = 0;
            for(int i = 0; i < items.Length; i++)
            {
                total += items[i].price;
            }
            return total;
        }


    }
}
