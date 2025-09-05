using C__Learning.OOP.Abstraction;

namespace C__Learning.OOP.Composition
{
    internal class Program : ProgramBase
    {
        // Mean class has a ather class or more as a property
        public override void Run()
        {
            Console.WriteLine("///////////////////////");

            Console.WriteLine("Composition Program");
            Product product1 = new Product(Guid.NewGuid(), "1234567890", "Laptop", "High performance laptop", 1500.00, 10);
            Product product2 = new Product(Guid.NewGuid(), "0987654321", "Smartphone", "Latest model smartphone", 800.00, 20);
            Product product3 = new Product(Guid.NewGuid(), "1122334455", "Tablet", "Portable tablet device", 300.00, 15);
            Bill bill = new Bill(Guid.NewGuid(), "Retail", "BILL-001", 0.0, 0.0);
            bill.BillDetails.Add(new BillDetail(Guid.NewGuid(), product1, 1, product1.Price));
            bill.BillDetails.Add(new BillDetail(Guid.NewGuid(), product2, 3, product2.Price * 3));
            bill.BillDetails.Add(new BillDetail(Guid.NewGuid(), product3, 2, product3.Price * 2));
            bill.TotalAmount = bill.BillDetails.Sum(detail => detail.Price);
            bill.Discount = bill.TotalAmount * 0.05;
            Console.WriteLine($"Bill ID: {bill.Id}");
            Console.WriteLine($"Bill Number: {bill.BillNumber}");
            Console.WriteLine($"Receipt Date: {bill.BillDate:dd/MM/yyyy HH:mm:ss}");
            Console.WriteLine($"Total Amount: {bill.TotalAmount:N3}");
            Console.WriteLine($"Discount: {bill.Discount:N3}");
            Console.WriteLine($"Net Amount: {bill.NetAmount:N3}");
            Console.WriteLine("Bill Details:");
            foreach (var detail in bill.BillDetails)
            {
                Console.WriteLine($"- Product: {detail.Product.Name}, Quantity: {detail.Quantity}, Price: {detail.Price:N3}");
            }
        }

    }
}
