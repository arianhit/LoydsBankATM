using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoydsBankATM
{
    public class Card
    {
        Database db = new Database();
        private string cardNumber;
        private string cardName;
        private int exDateMonths;
        private int exDateYears;
        private int pin;

        public string crrentCardNumber;
        public string currentCardName;
        public int currentExDatemonths;
        public int currentExDateyears;

        public Card(string cardNumber, string cardName, int exDateMonths, int exDateYears, int pin)
        {
            this.cardNumber = cardNumber;
            this.cardName = cardName;
            this.exDateMonths = exDateMonths;
            this.exDateYears = exDateYears;
            this.pin = pin;
        }

        public Card()
        {

        }

        public string GetCardNumber() { return cardNumber; }
        public string GetCardName() { return cardName; }
        public int GetExDateMonths() { return exDateMonths; }
        public int GetExDateYears() { return exDateYears; }
        public int GetPin() { return pin; }

        
    }
}
