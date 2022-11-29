using DocumentFormat.OpenXml.Office2016.Drawing.ChartDrawing;
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
using System.Net.Mail;
using System.Net;
using DocumentFormat.OpenXml.Vml;
using DocumentFormat.OpenXml.Drawing.Charts;

namespace LoydsBankATM
{
    public partial class ATMMenu : Form
    {
        bool pinMenu = false;
        Number n = new Number();
        Database db = new Database();
        Account ac = new Account();
        Random rnd = new Random();
        Customer cus = new Customer();
        bool withdrawMenu = false;
        List<string> numbers = new List<string>();
        int numberOfPinTrials = 0;
        public Card passedCard;
        int currentAccountNumber = 0;
        bool firstTimeWidthraw = false;
        bool firstTimeTransfer = false;
        int confirmationCode = 0;
        string customerEmailAddress = "";
        bool confirmationMenu = false;
        bool transferMenu = false;
        bool transferMenu2 = false;
        int deductedAmount = 0;
        int toAccountNumber = 0;
        public ATMMenu()
        {
            InitializeComponent();
            label_No.Hide();
            label_Yes.Hide();
            label_withdraw.Hide();
            label_Transfer.Hide();

            label_get_balance.Hide();
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
                    MessageBox.Show("You Can not enter more than 4 digits pin", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numbers.Clear();
                    Label_UserPIN.Text = "";
                }

            }
            if (withdrawMenu)
            {

                if (numbers.Count < 9)
                {
                    numbers.Add(number);

                    Label_UserPIN.Text += number;



                }
                else
                {
                    MessageBox.Show("Serieously?! you have that much money?!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numbers.Clear();
                    Label_UserPIN.Text = "";
                }

            }
            if (transferMenu)
            {
                if (numbers.Count < 9)
                {
                    numbers.Add(number);

                    Label_UserPIN.Text += number;

                }
                else
                {
                    MessageBox.Show("Please enter the valid account number?!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numbers.Clear();
                    Label_UserPIN.Text = "";
                }
            }
            if (confirmationMenu)
            {

                if (numbers.Count < 4)
                {
                    numbers.Add(number);

                    Label_UserPIN.Text += number;



                }
                else
                {
                    MessageBox.Show("Please enter the 4 digit confirmation code!", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    numbers.Clear();
                    Label_UserPIN.Text = "";
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

            int pin = 0;
            try
            {
                string cardNum = passedCard.crrentCardNumber;

                string sqlcmd = ($"select * from Card where Card_Number = '{cardNum}'");
                SqlCommand read = new SqlCommand(sqlcmd, db.connection());
                SqlDataReader dtreader = read.ExecuteReader();
                dtreader.Read();

                pin = int.Parse(dtreader.GetValue(2).ToString());
                currentAccountNumber = int.Parse(dtreader.GetValue(3).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            //int pin = 1258;

            if (pinMenu)
            {
                if (numberOfPinTrials >= 3)
                {
                    MessageBox.Show("You have tried more than 3 times !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                if (Label_UserPIN.Text == pin.ToString())
                {
                    label_Massage.Text = "Pin verifyed \n Welcome to the ATM " + passedCard.currentCardName;
                    numbers.Clear();
                    Label_UserPIN.Text = "";
                    pinMenu = false;
                    numberOfPinTrials = 0;
                    userMenu();

                }
                else
                {
                    label_Massage.Text = "Pin not verifyed try again";
                    Label_UserPIN.Text = "";
                    numbers.Clear();
                    numberOfPinTrials++;
                    numbers.Clear();
                }

            }
            if (withdrawMenu)
            {

                GetAccount();
                if (int.Parse(Label_UserPIN.Text) < ac.viewBalance() + ac.GetOverDraft())
                {
                    int total = 0;
                    int amount = Convert.ToInt32(Label_UserPIN.Text);

                    if (ac.viewBalance() < amount)
                    {
                        total = (ac.viewBalance() + ac.GetOverDraft()) - amount;
                    }
                    else
                    {
                        total = ac.viewBalance() - amount;
                    }
                    Label_UserPIN.Text = "";
                    numbers.Clear();
                    label_Balance.Text = "Your Balance is £" + total;
                    withdrawMenu = false;

                    try
                    {
                        int accountNumber = currentAccountNumber;

                        string sqlcmd = ($"UPDATE Account SET Account_Balance = '{total}'  WHERE Account_Number = '{accountNumber}'");
                        SqlCommand update = new SqlCommand(sqlcmd, db.connection());
                        update.ExecuteNonQuery();
                        total = deductedAmount;

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (transferMenu2)
                    {
                        try
                        {
                            GetAccountByNumber(toAccountNumber);
                            int accountNumber = toAccountNumber;

                            string sqlcmd = ($"UPDATE Account SET Account_Balance = '{amount + ac.viewBalance()}'  WHERE Account_Number = '{accountNumber}'");
                            SqlCommand update = new SqlCommand(sqlcmd, db.connection());
                            update.ExecuteNonQuery();

                            string date = DateTime.Now.ToString("yyyy-MM-dd", System.Globalization.DateTimeFormatInfo.InvariantInfo);
                            string time = DateTime.Now.ToString("h:mm:ss");
                            string toName = ac.GetAccountHolderName();

                            string qeuryInsert = $"insert into [dbo].[Transaction] (Transaction_Date,Trasaction_Time,Transaction_Amount ,Account_Number,Recipent_Account_Nume)" +
                                $"VALUES ('{date}','{time}','{amount}','{accountNumber}','{toName}')";
                            SqlCommand insert = new SqlCommand(qeuryInsert, db.connection());
                            insert.ExecuteNonQuery();

                            MessageBox.Show($"£{amount} succseesfully transfered to {toName}", "Transfered", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {
                    label_Massage.Text = "The amount is more than that you have ,try again!";
                    Label_UserPIN.Text = "";
                    numbers.Clear();
                }
            }
            if (transferMenu)
            {
                toAccountNumber = int.Parse(Label_UserPIN.Text);
                GetAccountByNumber(toAccountNumber);
                DialogResult dialogResult = MessageBox.Show("Do you want to transfer money to : " + ac.GetAccountHolderName(), "Confirm the account holder", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    Label_UserPIN.Text = "";
                    label_Massage.Text = "Please enter the amount of transfer";
                    transferMenu = false;
                    withdrawMenu = true;
                    transferMenu2 = true;
                }
                else if (dialogResult == DialogResult.No)
                {
                    userMenu();
                    Label_UserPIN.Text = "";
                    numbers.Clear();
                }
            }
            if (confirmationMenu)
            {

                if (numberOfPinTrials >= 3)
                {
                    MessageBox.Show("You have tried more than 3 times !", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
                if (int.Parse(Label_UserPIN.Text) == confirmationCode)
                {
                    MessageBox.Show("Confirmation Code verifyed!", "Vrifyed", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (firstTimeTransfer)
                    {
                        label_Massage.Text = "Confirmation Code verifyed \n please enter the Account number ";
                        firstTimeTransfer = false;
                        this.transferMenu = true;
                        Label_UserPIN.Text = "";
                        numbers.Clear();
                        confirmationMenu = false;
                        userMenu();

                        try
                        {
                            int accountNumber = currentAccountNumber;

                            string sqlcmd = ($"UPDATE Account SET Account_Transfer_Status = '1'  WHERE Account_Number = '{accountNumber}'");
                            SqlCommand update = new SqlCommand(sqlcmd, db.connection());
                            update.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        label_Massage.Text = "Confirmation Code verifyed \n please enter the amount of withdraw";
                        firstTimeWidthraw = false;
                        this.withdrawMenu = true;
                        Label_UserPIN.Text = "";
                        numbers.Clear();
                        confirmationMenu = false;
                        userMenu();
                        try
                        {
                            int accountNumber = currentAccountNumber;

                            string sqlcmd = ($"UPDATE Account SET Account_Widthraw_Status = '1'  WHERE Account_Number = '{accountNumber}'");
                            SqlCommand update = new SqlCommand(sqlcmd, db.connection());
                            update.ExecuteNonQuery();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }

                }
                else
                {

                    label_Massage.Text = "Confirmation Code not verifyed try again";
                    userMenu();
                    Label_UserPIN.Text = "";
                    numbers.Clear();
                    numberOfPinTrials++;

                }
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
            btn_rght_3.Enabled = false;
            btn_rght_4.Enabled = false;
        }

        private void userMenu()
        {
            btn_left_1.Enabled = true;
            btn_left_2.Enabled = true;
            btn_rght_2.Enabled = true;
            btn_right_1.Enabled = true;

            label_Transfer.Show();
            label_withdraw.Show();
            label_get_balance.Show();

        }
        public void GetAccount()
        {
            int balance = 0;
            string AccName = "";
            string AccType = "";
            int ovedrft = 0;

            try
            {
                int accountNumber = currentAccountNumber;

                string sqlcmd = ($"select * from Account where Account_Number = '{accountNumber}'");
                SqlCommand read = new SqlCommand(sqlcmd, db.connection());
                SqlDataReader dtreader = read.ExecuteReader();
                dtreader.Read();
                AccName = dtreader.GetValue(1).ToString();
                AccType = dtreader.GetValue(2).ToString();
                balance = Convert.ToInt32(dtreader.GetValue(3).ToString());
                ovedrft = Convert.ToInt32(dtreader.GetValue(4).ToString());
                ac = new Account(accountNumber, AccName, balance, AccType, ovedrft);
                if (dtreader.GetValue(5).ToString().ToUpper() == "FIRST")
                {
                    firstTimeTransfer = true;
                }
                if (dtreader.GetValue(6).ToString().ToUpper() == "FIRST")
                {
                    firstTimeWidthraw = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void GetAccountByNumber(int accountNumberr)
        {
            int balance = 0;
            string AccName = "";
            string AccType = "";
            int ovedrft = 0;

            try
            {
                int accountNumber = accountNumberr;

                string sqlcmd = ($"select * from Account where Account_Number = '{accountNumber}'");
                SqlCommand read = new SqlCommand(sqlcmd, db.connection());
                SqlDataReader dtreader = read.ExecuteReader();
                dtreader.Read();
                AccName = dtreader.GetValue(1).ToString();
                AccType = dtreader.GetValue(2).ToString();
                balance = Convert.ToInt32(dtreader.GetValue(3).ToString());
                ovedrft = Convert.ToInt32(dtreader.GetValue(4).ToString());
                ac = new Account(accountNumber, AccName, balance, AccType, ovedrft);
                if (Convert.ToInt32(dtreader.GetValue(5).ToString()) == 0)
                {
                    firstTimeTransfer = true;
                }
                if (Convert.ToInt32(dtreader.GetValue(6).ToString()) == 0)
                {
                    firstTimeWidthraw = true;
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Account not fount", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Label_UserPIN.Text = "";
                numbers.Clear();
            }
        }
        public void GetCustomer()
        {
            int CustId = 0;
            string CustFirstName = "";
            string CustLastName = "";
            string CustPhoneNum = "";
            string CustAddress = "";
            string CustEmail = "";

            try
            {
                int accountNumber = currentAccountNumber;

                string sqlcmd = ($"select * from Customer where Account_Number = '{accountNumber}'");
                SqlCommand read = new SqlCommand(sqlcmd, db.connection());
                SqlDataReader dtreader = read.ExecuteReader();
                dtreader.Read();
                CustId = Convert.ToInt32(dtreader.GetValue(0).ToString());

                CustFirstName = dtreader.GetValue(1).ToString();
                CustLastName = dtreader.GetValue(2).ToString();
                CustPhoneNum = dtreader.GetValue(3).ToString();
                CustAddress = dtreader.GetValue(4).ToString();
                CustEmail = dtreader.GetValue(5).ToString();
                cus = new Customer(CustId, CustFirstName, CustLastName, CustPhoneNum, CustAddress, CustEmail);
                customerEmailAddress = CustEmail;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_right_1_Click(object sender, EventArgs e)
        {
            GetAccount();

            if (firstTimeTransfer)
            {
                GetCustomer();
                emailTo(cus.GetCustomerEmail());
                label_Balance.Text = "";
                label_Massage.Text = "Please Enter the Confirmation code";
                this.confirmationMenu = true;
            }
            else
            {


                this.transferMenu = true;
                label_Balance.Text = "";
                label_Massage.Text = "Please Enter the Account number";
            }


        }
        private void btn_rght_2_Click(object sender, EventArgs e)
        {
            GetAccount();
            if (firstTimeWidthraw)
            {

                GetCustomer();
                emailTo(cus.GetCustomerEmail());
                label_Balance.Text = "";
                label_Massage.Text = "Please Enter the Confirmation code";
                this.confirmationMenu = true;
            }

            else
            {
                this.withdrawMenu = true;
                label_Balance.Text = "";
                label_Massage.Text = "Please Enter amount of widthraw";
            }


        }

        private void emailTo(string custEmail)
        {
            int port = 587;
            string host = "smtp.gmail.com";
            bool cbxSSL = true;
            string SenderAddress = "arianhit89@gmail.com";
            string appsPassword = Environment.GetEnvironmentVariable("ATMGm_Password");
            string recipentAddrss = custEmail;
            GetAccount();

            confirmationCode = rnd.Next(1000, 9000);
            SmtpClient clientDetails = new SmtpClient();
            clientDetails.Port = port;
            clientDetails.Host = host;
            clientDetails.EnableSsl = cbxSSL;
            clientDetails.DeliveryMethod = SmtpDeliveryMethod.Network;
            clientDetails.UseDefaultCredentials = false;
            clientDetails.Credentials = new NetworkCredential(SenderAddress, appsPassword);

            MailMessage mailDetails = new MailMessage();
            mailDetails.From = new MailAddress(SenderAddress);
            mailDetails.To.Add(recipentAddrss);
            mailDetails.Subject = "Confirmation Code";
            mailDetails.IsBodyHtml = cbxSSL;
            mailDetails.Body = "This is the conformation 4 digit code email from ATM as it is your first tiem" +
                "that You want to widthraw\n please keep this private\nDO NOT SHARE THIS CODE \n " +
                "\n\nCode is: [ " + confirmationCode + " }";
            clientDetails.Send(mailDetails);
            string securedEmail = recipentAddrss.Substring(recipentAddrss.Length - 12);
            MessageBox.Show("Confiration Email Sended to :********" + securedEmail, "Confirmation Code");

        }

        private void btn_rght_4_Click(object sender, EventArgs e)
        {

        }

        private void btn_left_2_Click(object sender, EventArgs e)
        {
            GetAccount();

            label_Balance.Text = "Your Balance is £" + ac.viewBalance();
        }
    }
    public class Number
    {
        public int nextNumber;
    }


}
