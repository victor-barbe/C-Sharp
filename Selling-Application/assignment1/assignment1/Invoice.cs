using System;
using System.Collections;
using System.Xml.Serialization;

namespace assignment1
{
    public class Invoice
    {
        private int number;
        private DateTime date;
        private ArrayList purchaseArray;

        // default constructor
        public Invoice()
        {
            this.number = 1;
            this.date = new DateTime();
            this.purchaseArray = new ArrayList();
        }

        // parameterized constructor
        public Invoice(int nb, ArrayList pArray)
        {
            this.number = nb;
            this.date = new DateTime();
            this.purchaseArray = pArray;
        }

        // copying constructor 
        public Invoice(Invoice i)
        {
            this.number = i.number;
            this.date = new DateTime();
            this.purchaseArray = i.purchaseArray;
        }


        // Add method, adds a purchase to the purchaseCollection, displays an error message if it already exists
        public void Add(Purchase a)
        {
            int counter = 0;
            for (int i = 0; i < purchaseArray.Count; ++i)
            {
                if (purchaseArray[i] != a)
                {
                    counter += 1;
                }
            }
            if (counter == purchaseArray.Count)
                purchaseArray.Add(a);
            else Console.WriteLine("Error : this purchase already exists");
        }

        //InvoiceAmount method, returns the total price of the invoice using the price of each purchase
        public double InvoiceAmount()
        {
            double total = 0;
            foreach (Purchase p in purchaseArray)
            {
                total += p.Item.Price * p.QuantityPurchased;
            }
            return total;
        }

        /*
        public void Save_Purchases(string filename)
        {
            FileStream f = File.Open(filename, FileMode.Open);
        }
        */

        public override string ToString()
        {
            string t = "";
            string listOfPurchases = "";

            foreach (Purchase p in purchaseArray)
            {
                listOfPurchases += ("Designation : " + p.Item.Designation + "   Discount % :    Price : " + p.Item.Price + "    Quantity : " + p.QuantityPurchased + "    Total Price : " + p.Item.Price * p.QuantityPurchased + "\n");
            }
            t = ("Invoice Number : " + number + "; Invoice date : " + date + "; \n " + listOfPurchases + "\n" + "   Invoice Amount : ");

            return t;
        }

        //properties for number
        public int Number
        {
            get { return number; }
            set { number = value; }
        }

        //properties for date
        public DateTime Date
        {
            get { return date; }
            set { date = value; }
        }

        //properties for purchaseArray
        public ArrayList PurchaseArray
        {
            get { return purchaseArray; }
            set { purchaseArray = value; }
        }
    }
}
