using System;

namespace LinkedList.Code
{
    public class Program
    {
        static void Main(string[] args)
        {
            var list = new ListForm(); //Creating the list
            list.AddValue("Oi");//Calling the addValue method adding elements to the list
            list.AddValue(5);
            list.AddValue(new DateTime(2005, 1, 01, 14, 00, 00));
            list.AddValue(1.5);
            list.AddValue("Tchau");
            list.Print();//Printing the linked list

            Console.WriteLine("-=-=-=-===-=-=-==-=-=-=-");

            list.InvertList();//Calling InvertList method, and inverting the linked list
            list.Print();//Printing the inverted linked list 
        }
    }
}

