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
            if (Convert.ToInt64(height) <= 5)
            {
                while (true)
                {
                    System.Windows.Forms.MessageBox.Show("L short");
                }
            }
            else if (Convert.ToInt64(height) >= 6) 
            {
                while (true)
                {
                    Console.WriteLine("Wow you're " + height + " tall??? thats crazy, L short people");
                }
            }

        }
    }
}