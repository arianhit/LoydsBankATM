using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
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
        Database db = new Database();
        
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
            try
            {
                HashSet<string> cardNums = new HashSet<string>();
                try
                {
                    string cardNum = CardNumberTB.Text;

                    string sqlcmd = ($"select * from Card where Card_Number = '{cardNum}'");
                    SqlCommand read = new SqlCommand(sqlcmd, db.connection());
                    SqlDataReader dtreader = read.ExecuteReader();
                    while (dtreader.Read())
                    {
                        cardNums.Add(dtreader.GetValue(0).ToString());
                    }


            }
            catch (Exception ex)
            {
                MessageBox.Show("ERRROR:Card not Validated TRY AGAIN   ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (Convert.ToInt32(ExpDateMonthsTB.Text) < 13 && Convert.ToInt32(ExpDateMonthsTB.Text) > 0 && Convert.ToInt32(ExpDateYearsTB.Text) > 21 && cardNums.Count() >= 1 )
                {
                    MessageBox.Show("Card Validated  " + CardNameTB.Text ,"Validation",MessageBoxButtons.OK , MessageBoxIcon.Information);
                    cardvalidated = true;
                    card.crrentCardNumber = CardNumberTB.Text;
                    card.currentExDatemonths = Convert.ToInt32(ExpDateMonthsTB.Text);
                    card.currentExDateyears = Convert.ToInt32(ExpDateYearsTB.Text);
                    card.currentCardName = CardNameTB.Text;
                    
                    


                    ATMMenu atm = new ATMMenu();
                    atm.passedCard = card;
                    atm.Show();
                }
                else
                {
                    MessageBox.Show("ERRROR:Card not Validated TRY AGAIN   ", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    CardNumberTB.Clear();
                    ExpDateMonthsTB.Clear();
                    ExpDateYearsTB.Clear();

                }
            }
            catch (FormatException)
            {
                MessageBox.Show("ERRROR:Plase provide correct format for each field", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                CardNumberTB.Clear();
                ExpDateMonthsTB.Clear();
                ExpDateYearsTB.Clear();
                CardNameTB.Clear();
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
