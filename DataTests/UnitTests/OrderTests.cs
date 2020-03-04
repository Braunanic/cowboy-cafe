using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;
using CowboyCafe.Data;
using System.Collections;

namespace CowboyCafe.DataTests
{

    public class MockOrderItem : IOrderItem
    {
        public double Price { get; set; }

        public IEnumerable<string> SpecialInstructions {get; set;}

     
    }
    /// <summary>
    /// Tests for the Order Class.
    /// </summary>
    public class OrderTests
    {

        /* Adding something to the order should
         * have it appear in the Items property.
         */
        [Fact]
        public void AddedIOrderItemsAppearInItemsPropety()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
        }

        [Fact]
        public void RemoveOrderItemDoesNotAppearInItemsProperty()
        {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        [Theory]
        [InlineData(new double[] {0})]
        [InlineData(new double[]{ 10, 15, 18 })]
        [InlineData(new double[]{ 20, -4, 3.6, 8 })]
        [InlineData(new double[] {})]
    [InlineData(new double[] { -100, -5 })]
    public void SubtotalShouldBeTheSumOfOrderItemPrices(double[] Prices)
        {
            double total = 0;
            var order = new Order();
            foreach(var price in Prices)
            {
                total += price;
                //initializing object and field in one line.
                order.Add(new MockOrderItem() { Price = price });
            }
            Assert.Equal(total, order.Subtotal);
        }

        

        [Fact]
        public void ItemsShouldContainOnlyAddedItems()
        {
            var items = new IOrderItem[]
            {
                new MockOrderItem() {Price = 3 },
                new MockOrderItem() {Price = 4 },
                new MockOrderItem() {Price = 7 },
            };
            var order = new Order();
            foreach( var item in items)
            {
                order.Add(item);
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach(var item in items)
            {
                Assert.Contains(item, order.Items);
            }
        }
        /* 
         * Removing something from the order should
         * remove it from the Items Property.
         * 
         * Get the Price - needs to be correct Price.
         *    (For all the Items we have added.
         * 
         */
    }
}
