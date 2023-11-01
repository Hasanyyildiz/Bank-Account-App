using System;

namespace BankaHesabi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankaHesabı bankahesabi = new BankaHesabı();
            Console.Write("Account Name: ");
            bankahesabi.accountName = Console.ReadLine();

            Console.Write("Credit Card : ");
            bankahesabi.accountCredit = Console.ReadLine();

            if (bankahesabi.accountCredit.Length > 8 || bankahesabi.accountCredit.Length != 8)
            {
                Console.WriteLine();
                Console.WriteLine("User Not Found, Try Again...");
                Console.WriteLine("(Kullanıcı Bulunamadı, Tekrar Deneyiniz)");
                Console.WriteLine();
                return;

            }

            VadesizHesap hesap = new VadesizHesap();
            hesap.IbanNo();
            Console.WriteLine("");
            Console.WriteLine("Welcome To {0}", bankahesabi.accountName);
            Console.WriteLine("");
            Console.WriteLine("--------------------------");
            Console.WriteLine("");
            TasarufHesabı tasaruf = new TasarufHesabı();
            Console.Write("Enter The Deposit: ");
            tasaruf.Deposit = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter the Interest Rate: ");
            tasaruf.InterestRate = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Account Result: {0}", tasaruf.CalculateInterest());

            Console.ReadKey();
        }




    }
}
