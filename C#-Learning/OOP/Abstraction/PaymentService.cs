using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Abstraction
{
    internal class PaymentService
    {
        // Public method that hides the complexity of the payment process.
        public void ProcessPayment(double amount)
        {
            ConnectToPaymentGateway();
            Authenticate();
            ProcessTransaction(amount);
            Disconnect();
            System.Console.WriteLine("Payment processed successfully.");
        }

        // The following methods handle the internal logic of the payment process
        // They are private, meaning other classes don't need to know the details.
        private void ConnectToPaymentGateway()
        {
            System.Console.WriteLine("Connecting to payment gateway...");
        }

        private void Authenticate()
        {
            System.Console.WriteLine("Authenticating payment details...");
        }

        private void ProcessTransaction(double amount)
        {
            System.Console.WriteLine($"Processing transaction for amount: {amount}...");
        }

        private void Disconnect()
        {
            System.Console.WriteLine("Disconnecting from payment gateway...");
        }
    }
}
