using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Composition
{
    internal class BillDetail
    {
        public Guid Id { get; set; }
        public Product Product { get; set; } = new Product(); // to get some details about the product
        public int Quantity { get; set; }
        public double Price { get; set; }
        public BillDetail() { 
            Id = Guid.NewGuid();
            Product = new Product();
            Quantity = 0;
            Price = 0.0;
        }

        public BillDetail(Guid id, Product product, int quantity, double price)
        {
            Id = id;
            Product = product;
            if (product.StockQuantity < quantity && quantity<0)
            {
                throw new ArgumentException("Quantity cannot be greater than stock quantity or less than zero.");
            }
            Quantity = quantity;
            Price = price;
        }

    }
}
