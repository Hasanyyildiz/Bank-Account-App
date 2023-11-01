using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace BankaHesabi
{
    internal class BankaHesabı
    {
        public string accountName = "undefined";
        public string accountCredit = "undefined";
 
    }

    class VadesizHesap : BankaHesabı
    {
        public void IbanNo() 
        {
            Console.WriteLine("IBAN number: 4544 2417 2724 4894");
        }

    }

    class TasarufHesabı:BankaHesabı
    {
        private double deposit;
        private double interestRate;

        public double Deposit
        {
            get
            {
                return deposit;
            }
            set
            {
                deposit = value;
            }
        }

        public double InterestRate
        {
            get
            {
                return interestRate;
            }
            set
            {
                interestRate = value;
            }
        }
        public double CalculateInterest()
        {
            return deposit = deposit * (1 + interestRate);
        }



    }
}
