using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Composition
{
    internal class Product
    {
        public Guid Id { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public int StockQuantity { get; set; }
        public Product() { 
            Id = Guid.NewGuid();
            Barcode = "0000000000"; 
            Name = "Default Product";
            Description = "Default Description";
            Price = 0.0;
            StockQuantity = 0;
        }

        public Product(Guid id, string barcode, string name, string description, double price, int stockQuantity)
        {
            Id = id;
            Barcode = barcode;
            Name = name;
            Description = description;
            Price = price;
            StockQuantity = stockQuantity;
        }
        public override string ToString()
        {
            return $"{Name} - {Description} - ${Price} (Stock: {StockQuantity})";
        }
    }
}
