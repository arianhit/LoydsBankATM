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
    public partial class ATMMenu : Form
    {
        bool pinMenu = false;
        Number n = new Number();
        Card card = new Card();
        List<string> numbers = new List<string>();
        
        public ATMMenu()
        {
            InitializeComponent();
            label_No.Hide();
            label_Yes.Hide();
            label_withdraw.Hide();
            label_Transfer.Hide();
            lebel_PinService.Hide();
            disableRLbuttons();
            pinMenu = true;
            
        }

        private void ATMMenu_X_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ATMbutton1_Click(object sender, EventArgs e)
        {
            displayPin("1");
            
        }

        private void ATMbutton2_Click(object sender, EventArgs e)
        {
            displayPin("2");
        }

        private void ATMbutton3_Click(object sender, EventArgs e)
        {
            displayPin("3");
        }

        private void ATMbutton4_Click(object sender, EventArgs e)
        {
            displayPin("4");
        }

        private void ATMbutton5_Click(object sender, EventArgs e)
        {
            displayPin("5");
        }

        private void ATMbutton6_Click(object sender, EventArgs e)
        {
            displayPin("6");
        }

        private void ATMbutton7_Click(object sender, EventArgs e)
        {
            displayPin("7");
        }

        private void ATMbutton8_Click(object sender, EventArgs e)
        {
            displayPin("8");
        }

        private void ATMbutton9_Click(object sender, EventArgs e)
        {
            displayPin("9");
        }

        private void ATMbutton0_Click(object sender, EventArgs e)
        {
            displayPin("0");
        }
        private void displayPin(string number)
        {
            if (pinMenu)
            {
                if (numbers.Count < 4)
                {
                    numbers.Add(number);

                    Label_UserPIN.Text += number;

                }
                else
                {
                    MessageBox.Show("You Can not enter more than 4 digits pin");
                }
            }
        }

        private void buttonClr_Click(object sender, EventArgs e)
        {
            Label_UserPIN.Text = "";
            numbers.Clear();
        }

        private void buttonCln_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonEntr_Click(object sender, EventArgs e)
        {
            if(Label_UserPIN.Text == "1234")
            {
                label_Massage.Text = "Pin verifyed \n Welcome to the ATM " + card.currentCardName;
            }
            else
            {
                label_Massage.Text = "Pin not verifyed try again";
                Label_UserPIN.Text = "";
                numbers.Clear();
            }
        }

        private void disableRLbuttons()
        {
            btn_left_1.Enabled = false;
            btn_left_2.Enabled = false;
            btn_left_3.Enabled = false;
            btn_left_4.Enabled = false;
            btn_right_1.Enabled = false;
            btn_rght_2.Enabled = false;
            btn_rght_3.Enabled = false ;
            btn_rght_4.Enabled = false ;
        }
    }
    public class Number
    {
        public int nextNumber;
    }
}
