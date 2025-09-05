using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Example
{
    internal class Order
    {
        public int Id { get; set; }
        public decimal Amount { get; set; }

        private readonly IPaymentService _paymentService;
        public Order(IPaymentService paymentService)
        {
            _paymentService = paymentService;
        }
        public bool ProcessOrder()
        {
            return _paymentService.Pay(this);
        }

    }
}
