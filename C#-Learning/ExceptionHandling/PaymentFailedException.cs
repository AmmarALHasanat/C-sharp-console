using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.ExceptionHandling
{
    internal class PaymentFailedException : Exception
    {
        public PaymentFailedException() : base("Payment processing failed.")
        {

        }
        public PaymentFailedException(string message) : base(message)
        {

        }
        public PaymentFailedException(string message, Exception innerException) : base(message, innerException)
        {
            
        }

        // how to add 
        //Source: 
        //Target Site: 
        //Stack Trace:
    }
}
