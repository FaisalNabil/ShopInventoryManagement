using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop_Inventory_Management
{
    class Product
    {

        private string productId, productType, productName, lotNumber, receiveDate, expiaryDate;
        private int totalUnits, lowRunLimit;
        private double unitPrice;
        public Product()
        {
            this.productId = "";
            this.productType = "";
            this.productName = "";
            this.totalUnits = 0;
            this.unitPrice = 0.0;
            this.lotNumber = "";
            this.receiveDate = "";
            this.expiaryDate = "";
            this.lowRunLimit = 0;
        }

        public Product(string productId, string productType, string productName, string lotNumber, string receiveDate, string expiaryDate, int totalUnits, int lowRunLimit, double unitPrice)
        {
            this.productId = productId;
            this.productType = productType;
            this.productName = productName;
            this.totalUnits = totalUnits;
            this.unitPrice = unitPrice;
            this.lotNumber = lotNumber;
            this.receiveDate = receiveDate;
            this.expiaryDate = expiaryDate;
            this.lowRunLimit = lowRunLimit;
        }

        public string ProductId
        {
            set { this.productId = value; }
            get { return productId; }
        }

        public string ProductType
        {
            set { this.productType = value; }
            get { return productType; }
        }

        public string ProductName
        {
            set { this.productName = value; }
            get { return productName; }
        }

        public string LotNumber
        {
            set { this.lotNumber = value; }
            get { return lotNumber; }
        }

        public int TotalUnits
        {
            set { this.totalUnits = value; }
            get { return totalUnits; }
        }

        public int LowRunLimit
        {
            set { this.lowRunLimit = value; }
            get { return lowRunLimit; }
        }

        public double UnitPrice
        {
            set { this.unitPrice = value; }
            get { return unitPrice; }
        }

        public string ReceiveDate
        {
            set { this.receiveDate = value; }
            get { return receiveDate; }
        }

        public string ExpiaryDate
        {
            set { this.expiaryDate = value; }
            get { return expiaryDate; }
        }
    }
}
