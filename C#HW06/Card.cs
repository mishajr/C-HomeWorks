using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_HW06
{
     class Card
    {
        private string cardNumber;
        private string cardHolderName;
        private string cvc;
        private DateTime expirationDate;

       
        public string CardNumber
        {
            get { return cardNumber; }
            set
            {
                if (value.Length != 16 || !long.TryParse(value, out _))
                {
                    throw new ArgumentException("Номер картки повинен містити 16 цифр!");
                }
                cardNumber = value;
            }
        }

    
        public string CardHolderName
        {
            get { return cardHolderName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("ПІБ власника не може бути порожнім!");
                }
                cardHolderName = value;
            }
        }

       
        public string CVC
        {
            get { return cvc; }
            set
            {
                if (value.Length != 3 || !int.TryParse(value, out _))
                {
                    throw new ArgumentException("CVC повинен містити 3 цифри!");
                }
                cvc = value;
            }
        }

       
        public DateTime ExpirationDate
        {
            get { return expirationDate; }
            set
            {
                if (value < DateTime.Now)
                {
                    throw new ArgumentException("Дата завершення дії картки не може бути в минулому!");
                }
                expirationDate = value;
            }
        }

       
        public Card(string cardNumber, string cardHolderName, string cvc, DateTime expirationDate)
        {
            CardNumber = cardNumber;
            CardHolderName = cardHolderName;
            CVC = cvc;
            ExpirationDate = expirationDate;
        }

        
        public void DisplayCardInfo()
        {
            Console.WriteLine($"Номер картки: {CardNumber}");
            Console.WriteLine($"ПІБ власника: {CardHolderName}");
            Console.WriteLine($"CVC: {CVC}");
            Console.WriteLine($"Дата завершення дії картки: {ExpirationDate.ToShortDateString()}");
        }

    }
}
