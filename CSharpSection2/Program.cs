using System;
using CSharpSection2.Classes;

namespace CSharpSection2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SimpleMath.Division(432.23f, 54265.2f));

            BankAccount bankAccount1 = new BankAccount(1234.24f, "Jane Doe");
            Console.WriteLine(bankAccount1.Balance);
            
          

            BankAccount bankAccount2 = new BankAccount(1321.21f, "John Doe");
            
            Console.WriteLine(bankAccount1.AddBalance(10210f));
            Console.WriteLine(bankAccount2.AddBalance(100f));

            Console.ReadLine(); 
           
        }
    }

    class SimpleMath
    {
        public static float Add(float n1, float n2)
        {
            return n1 + n2;
        }

        public static float Substract(float n1, float n2)
        {
            return n1 - n2;
        }

        public static float Multiplication(float n1, float n2)
        {
            return (n1 * n2);
        }


        public static float Division(float n1, float n2)
        {
            return n1 / n2;
        }

    }
}
