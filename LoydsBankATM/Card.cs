using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoydsBankATM
{
    public class Card
    {
        private double cardNumber;
        private string cardName;
        private int exDateMonths;
        private int exDateYears;

        public double crrentCardNumber;
        public string currentCardName;
        public int currentExDatemonths;
        public int currentExDateyears;

        public Card(int cardNumber, string cardName, int exDateMonths, int exDateYears)
        {
            this.cardNumber = cardNumber;
            this.cardName = cardName;
            this.exDateMonths = exDateMonths;
            this.exDateYears = exDateYears;
        }

        public Card()
        {

        }

        public double GetCardNumber() { return cardNumber; }
        public string GetCardName() { return cardName; }
        public int GetExDateMonths() { return exDateMonths; }
        public int GetExDateYears() { return exDateYears; }

    }
}
