using System;
namespace assignment1
{
    public class Purchase
    {

        private Item item;
        private int quantityPurchased;
        private int codeOfPurchase;

        // default constructor
        public Purchase()
        {
            this.item = null;
            this.quantityPurchased = 0;
            this.CodeOfPurchase = 0;
        }

        //parameterized constructor
        public Purchase(Item item, int quantityPurchased, int codeOfPurchase)
        {
            this.item = item;
            this.quantityPurchased = quantityPurchased;
            this.codeOfPurchase = codeOfPurchase;
        }

        //copying constructor
        public Purchase(Purchase purchase)
        {
            this.item = purchase.item;
            this.quantityPurchased = purchase.quantityPurchased;
            this.codeOfPurchase = purchase.codeOfPurchase;
        }

        //properties for item
        public Item Item
        {
            get { return item; }
            set { item = value; }
        }

        //properties for quantityPurchased
        public int QuantityPurchased
        {
            get { return quantityPurchased; }
            set { quantityPurchased = value; }
        }

        //properties for codeOfPurchase
        public int CodeOfPurchase
        {
            get { return codeOfPurchase; }
            set { codeOfPurchase = value; }
        }

        //CompareTo method, takes an other purchase as a parameter and checks if it is equal to the one we currently use
        public void CompareTo(Purchase purchase1)
        {
            if (this.item == purchase1.item && this.quantityPurchased == purchase1.quantityPurchased)
            {
                Console.WriteLine("These 2 purchases are the same");
            }
            else
            {
                Console.WriteLine("These 2 purchases are not the same");
            }
        }

    }

}
