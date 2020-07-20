using System;

namespace SpeedOfBuilds
{
    public class Order
    {


        private int quantity;

        private String orderDesc;

        public Order(int quantity, String orderDesc)
        {

            this.quantity = quantity;
            this.orderDesc = orderDesc;
        }

        public override String ToString()
        {
            return "Order [quantity=" + quantity + ", orderDesc=" + orderDesc + "]";
        }

        public int Quantity
        {
            get => quantity;
            set => this.quantity = value;
        }


        public String OrderDesc
        {
            get => orderDesc;
            set => this.orderDesc = value;
        }

    }
}