using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Learning.OOP.Composition
{
    internal class Bill
    {
        public Guid Id { get; set; }
        public string BillType { get; set; }
        public string BillNumber { get; set; }
        public DateTime BillDate { get; set; }

        public double TotalAmount { get; set; }
        public double Discount { get; set; }
        public double NetAmount => TotalAmount - Discount;
        public List<BillDetail> BillDetails { get; set; } = new List<BillDetail>();

        public Bill()
        {
            Id = Guid.NewGuid();
            BillType = "Default Type";
            BillNumber = "0000";
            TotalAmount = 0.0;
            Discount = 0.0;
            BillDate = DateTime.Now;

        }
        public Bill(Guid id, string billType, string billNumber, double totalAmount, double discount)
        {
            Id = id;
            BillType = billType;
            BillNumber = billNumber;
            TotalAmount = totalAmount;
            Discount = discount;
            BillDate = DateTime.Now;
        }

    }
}
