using System;
namespace assignment1
{
    public class Item
    {
        protected int code;
        protected string designation;
        protected double price;
        protected string category;

        // default constructor
        public Item()
        {
            this.code = 0;
            this.designation = "";
            this.price = 0;
            this.category = "";
        }

        // parameterized constructor
        public Item(int code, string designation, double price, string category)
        {
            this.code = code;
            this.designation = designation;
            this.price = price;
            if (category == "Computer Science" || category == "Office Automation")
                this.category = category;
            else this.category = "";
        }

        //copying constructor
        public Item(Item item)
        {
            this.code = item.code;
            this.designation = item.designation;
            this.price = item.price;
            this.category = item.category;
        }

        // getter and setter for code
        public virtual int Code
        {
            get { return code; }
            set { code = value; }
        }

        // getter and setter for designation
        public virtual string Designation
        {
            get { return designation; }
            set { designation = value; }
        }

        // getter and setter for category
        public virtual string Category
        {
            get { return category; }
            set
            {
                if (value == "Computer Science" || value == "Office Automation")
                    category = value;
                else category = ""; 
            }
        }

        // getter and setter for price
        public virtual double Price
        {
            get { return price; }
            set {
                try {
                    price = value;
                }
                catch(Exception e)
                {
                    Console.WriteLine("Price is invalid");
                    Console.Error.WriteLine(e);
                    price = 0;
                }
            }
        }

        // ToString method, prints in the console the item's attributes
        public override string ToString()
        {
            return "Code = " + code + "; Designation = " + designation + "; Price = " + price + "; Category =" + category;
        }

        //Equals method, takes as a parameter an item and checks if it is equal to the item we currently use
        public virtual void Equals(Item item)
        {
            if (this.code == item.code && this.designation == item.designation && this.price == item.price && this.category == item.category)
            {
                Console.WriteLine("These 2 articles are the same");
            }
            else
            {
                Console.WriteLine("These 2 articles are not the same");
            }
        }
    }
}
