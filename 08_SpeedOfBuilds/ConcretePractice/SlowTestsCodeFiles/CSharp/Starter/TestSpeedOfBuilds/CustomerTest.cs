using SpeedOfBuilds;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestSpeedOfBuilds
{
    public class CustomerTest
    {


        private Customer customer;

        private List<Order> orders;




        public CustomerTest()
        {

            orders = new List<Order>();

            for (int i = 1; i <= 3000; i++)
                orders.Add(new Order(i, "Order " + i));

            customer = new Customer(orders); // Initialises Fixture with some orders
        }

        [Trait("Speed", "Slow")]
        [Fact]
        public void testFindBiggestOrder()
        {

            Order biggestOrder = customer.FindBiggestOrder();

            int expectedQty = 3000;

            Assert.Equal(expectedQty, biggestOrder.Quantity);
        }

        [Trait("Speed", "Fast")]
        [Fact]
        public void testFindOrderByIndex0()
        {

            Order order = customer.FindOrderByIndex(0);

            int qty = 1;

            Assert.Equal( qty, order.Quantity);
        }



    }
}
