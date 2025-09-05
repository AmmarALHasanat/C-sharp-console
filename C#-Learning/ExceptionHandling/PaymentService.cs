using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.ExceptionHandling
{
    internal class PaymentService
    {
        public void ProcessPayment()
        {
            bool paymentSuccess = false;

            if (!paymentSuccess)
            {
                throw new PaymentFailedException("Unable to process payment due to insufficient funds.");
            }
        }
    }
}
