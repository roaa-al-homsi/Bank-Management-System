using BankSystemBusiness;
using System;

namespace ConsoleBankSystem
{
    internal class Program
    {

        static public void Trans(float amount, string souAcc, string Toacc)
        {
            Client souClient = Client.Find(souAcc);
            Client ToClient = Client.Find(Toacc);
            if (souClient != null)
            {
                if (souClient.Transfer(amount, ToClient))
                {
                    Console.WriteLine("Su");
                }
                else
                {
                    Console.WriteLine("Failed");
                }
            }

        }


        static void Main(string[] args)
        {
            Trans(1000, "A102", "A103");


        }
    }
}
