using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoydsBankATM
{
    public partial class CardEntery : Form
    {
        private bool cardvalidated = false;
        Card card = new Card();
        public CardEntery()
        {
            InitializeComponent();
        }
        public bool getCardValidated()
        {
            return this.cardvalidated;
        }
        private void CardNumberTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void CardEntry_X_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EnterCard_btn_Click(object sender, EventArgs e)
        {
            if ( Convert.ToInt32(ExpDateMonthsTB.Text) < 12 && Convert.ToInt32(ExpDateMonthsTB.Text) > 0 && Convert.ToInt32(ExpDateYearsTB.Text) > 21) 
            {
                MessageBox.Show("Card Validated  " + CardNameTB.Text)   ;
                cardvalidated = true;
                card.crrentCardNumber = Convert.ToDouble(CardNumberTB.Text);
                card.currentExDatemonths = Convert.ToInt32(ExpDateMonthsTB.Text);
                card.currentExDateyears = Convert.ToInt32(ExpDateYearsTB.Text);
                card.currentCardName = CardNameTB.Text;
                ATMMenu atm = new ATMMenu();
                atm.Show();
            }
            else
            {
                MessageBox.Show("ERRROR:Card not Validated TRY AGAIN   " );
                CardNumberTB.Clear();
                ExpDateMonthsTB.Clear();
            }
        }

        private void ClearCard_btn_Click(object sender, EventArgs e)
        {
           CardNumberTB.Clear();
            ExpDateMonthsTB.Clear();
            ExpDateYearsTB.Clear();
            CardNameTB.Clear();
        }

    }
}
