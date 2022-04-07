using System;
using System.Collections;
namespace assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Item i = new Item(10, "Book", 20, "Computer Science");
            Item i2 = new Item(10, "Book", 20, "Computer Science");
            string t = i.ToString();
            Console.WriteLine(t);
            i.Equals(i2);

            Purchase p1 = new Purchase(i, 10, 37842);
            Purchase p2 = new Purchase(i2, 30, 238917);

            ArrayList array = new ArrayList();
            array.Add(p1);
            array.Add(p2);

            Invoice Invoice1 = new Invoice(1, array);

            string text = Invoice1.ToString();
            Console.WriteLine(text);



        }
    }
}
