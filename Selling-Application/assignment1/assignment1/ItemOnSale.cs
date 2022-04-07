using System;
namespace assignment1
{
    public class ItemOnSale : Item
    {
        private double discount;

        //parameterized constructor
        public ItemOnSale(int code, string designation, double price, string category, double discount) : base (code, designation, price, category)
        {
            this.discount = discount;
        }

        //copying constructor
        public ItemOnSale(ItemOnSale itemOnSale) 
        {
            this.code = itemOnSale.code;
            this.designation = itemOnSale.designation;
            this.price = itemOnSale.price;
            this.category = itemOnSale.category;
            this.discount = itemOnSale.discount;
        }

        //default constructor
        public ItemOnSale ()
        {
            this.discount = 0;
        }

        //overiding property so we get the real price of the discount
        public override double Price
        {
            get { return price - price * discount; }
            set { price = value; }
        }
    }
}
