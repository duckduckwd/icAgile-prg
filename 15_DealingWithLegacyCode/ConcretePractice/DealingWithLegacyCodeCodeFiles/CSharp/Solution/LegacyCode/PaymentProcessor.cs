using System;
using System.Collections.Generic;

namespace LegacyCode
{
    public  class PaymentProcessor
    {
        IProcessPayment directdebit;
        IProcessPayment standingOrder;

        public PaymentProcessor(IProcessPayment directdebit, IProcessPayment standingOrder)
        {
            this.directdebit = directdebit; 
            this.standingOrder = standingOrder;
        }
        public void ProcessAccount(CurrentAccount account)
        {
            foreach(var payee in account.DirectDebits)
            {
                directdebit.Process(payee);
            }
            foreach (var payee in account.StandingOrders)
            {
                standingOrder.Process(payee);
            }

        }

    }
}
