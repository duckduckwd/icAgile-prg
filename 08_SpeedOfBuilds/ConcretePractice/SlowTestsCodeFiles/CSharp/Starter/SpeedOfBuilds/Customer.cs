using System;
using System.Collections.Generic;
using System.Threading;

namespace SpeedOfBuilds
{
    public class Customer
    {


        private List<Order> orders = new List<Order>();




        public Customer(List<Order> orders)
        {

            this.orders = orders;

        }

        public Order FindBiggestOrder()
        {

            Order biggestOrder = orders[0];

            foreach (Order nextOrder in orders)
            {
                if (CompareOrder(nextOrder, biggestOrder) > 0)
                {
                    biggestOrder = nextOrder;

                    try
                    {
                        Thread.Sleep(1);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e);
                    }
                }
            }

            return biggestOrder;
        }




        public Order FindOrderByIndex(int index)
        {

            return orders[index];
        }


        public int CompareOrder(Order first, Order other)
        {
            if (first.Quantity > other.Quantity)
            {

                return 1;
            }
            else if (first.Quantity > other.Quantity)
            {
                return -1;
            }
            else
            {
                return 0;
            }

        }





    }
}