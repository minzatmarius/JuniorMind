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

        [TestMethod]
        public void CheapestProductShouldBeApple()
        {
            Item[] items = new Item[] { new Item("Apple", 2), new Item("Milk", 4), new Item("Bread", 3) };
            Assert.AreEqual(items[0], FindTheCheapest(items));
        }

        [TestMethod]
        public void CheapestProductShouldBeCandy()
        {
            Item[] items = new Item[] { new Item("Apple", 2), new Item("Milk", 4), new Item("Bread", 3), new Item("Candy", 1) };
            Assert.AreEqual(items[3], FindTheCheapest(items));
        }

        [TestMethod]
        public void SwapAppleWithMilk()
        {
            Item[] items = new Item[] { new Item("Apple", 2), new Item("Milk", 4), new Item("Bread", 3), new Item("Candy", 1) };
            Swap(ref items[0], ref items[1]);
            CollectionAssert.AreEqual( new Item[] { new Item("Milk", 4), new Item("Apple", 2), new Item("Bread", 3), new Item("Candy", 1) }, items);
        }

        [TestMethod]
        public void EliminateMilk()
        {
            Item[] items = new Item[] { new Item("Apple", 2), new Item("Milk", 4), new Item("Bread", 3), new Item("Candy", 1) };
            CollectionAssert.AreEqual(new Item[] { new Item("Apple", 2), new Item("Candy", 1), new Item("Bread", 3)}, EliminateExpensive(items));
           
        }

        [TestMethod]
        public void AddEggs()
        {
            Item[] items = new Item[] { new Item("Apple", 2), new Item("Milk", 4), new Item("Bread", 3), new Item("Candy", 1) };
            CollectionAssert.AreEqual(new Item[] { new Item("Apple", 2), new Item("Milk", 4), new Item("Bread", 3), new Item("Candy", 1) , new Item("Eggs", 5) }, AddItem(items, new Item("Eggs", 5)));
        }

        [TestMethod]
        public void AveragePrice()
        {
            Item[] items = new Item[] { new Item("Apple", 2), new Item("Milk", 4), new Item("Bread", 3), new Item("Candy", 1) };
            Assert.AreEqual(10m / 4, CalculateAveragePrice(items));
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

        Item FindTheCheapest(Item[] items)
        {
            Item minimum = items[0];
            for(int i = 1; i< items.Length; i++)
            {
                minimum = (minimum.price > items[i].price) ? items[i] : minimum;
            }
            return minimum;
        }
        
        void Swap(ref Item first, ref Item second)
        {
            Item aux = first;
            first = second;
            second = aux;
            
        }

        Item[] EliminateExpensive(Item[] items)
        {
            Item maximum = items[0];
            int position = 0;
            for (int i = 1; i < items.Length; i++)
            {
                if(maximum.price < items[i].price)
                {
                    maximum = items[i];
                    position = i;
                }

            }
            Swap(ref items[position], ref items[items.Length - 1]);
            Array.Resize<Item>(ref items, items.Length - 1);
            return items;
        }

        Item[] AddItem(Item[] items, Item newItem)
        {
            Array.Resize<Item>(ref items, items.Length + 1);
            items[items.Length - 1] = newItem;
            return items; 
        }

        decimal CalculateAveragePrice(Item[] items)
        {
            return CalculateTotalPrice(items) / items.Length;
        }
    }
}
