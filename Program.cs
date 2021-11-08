using System;

namespace looping
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Banking!");

            // string AccountNo;
            // AccountNo = Convert.ToString(12345678);
            //var pie = 3.14;
            Console.WriteLine("Enter your name \n");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your Email \n");
            string email = Console.ReadLine();
            Console.WriteLine("Enter your mobileno \n");
            var mobileno =Convert.ToInt32(Console.ReadLine());
           // int mobileno = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Accholder name is" + name + "Emailid is" + email + "Acholder mobileno" + mobileno + "Welcome to IBank");
           





        }
    }
}
