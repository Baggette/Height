using System;

namespace height
{
    class Height
    {
        static void Main()
        {
            string height;
            Console.Write("Enter your height in feet: ");
            height = Console.ReadLine();
            System.Windows.Forms.MessageBox.Show("You are " + height + " feet tall.");
            Console.ReadKey(); 
        }
    }
}