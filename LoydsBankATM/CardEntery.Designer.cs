namespace LoydsBankATM
{
    partial class CardEntery
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.ClearCard_btn = new System.Windows.Forms.Button();
            this.EnterCard_btn = new System.Windows.Forms.Button();
            this.ExpDateMonthsTB = new System.Windows.Forms.TextBox();
            this.CardNumberTB = new System.Windows.Forms.TextBox();
            this.PIN = new System.Windows.Forms.Label();
            this.CardNumber = new System.Windows.Forms.Label();
            this.label_ATM = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelX = new System.Windows.Forms.Label();
            this.CardEntry_X_btn = new System.Windows.Forms.Button();
            this.ExpDateYearsTB = new System.Windows.Forms.TextBox();
            this.CardNameTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightCyan;
            this.panel1.Controls.Add(this.CardNameTB);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.ExpDateYearsTB);
            this.panel1.Controls.Add(this.ClearCard_btn);
            this.panel1.Controls.Add(this.EnterCard_btn);
            this.panel1.Controls.Add(this.ExpDateMonthsTB);
            this.panel1.Controls.Add(this.CardNumberTB);
            this.panel1.Controls.Add(this.PIN);
            this.panel1.Controls.Add(this.CardNumber);
            this.panel1.Location = new System.Drawing.Point(177, 182);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(888, 414);
            this.panel1.TabIndex = 0;
            // 
            // ClearCard_btn
            // 
            this.ClearCard_btn.BackColor = System.Drawing.Color.Red;
            this.ClearCard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearCard_btn.ForeColor = System.Drawing.SystemColors.Control;
            this.ClearCard_btn.Location = new System.Drawing.Point(535, 265);
            this.ClearCard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.ClearCard_btn.Name = "ClearCard_btn";
            this.ClearCard_btn.Size = new System.Drawing.Size(157, 59);
            this.ClearCard_btn.TabIndex = 5;
            this.ClearCard_btn.Text = "Clear";
            this.ClearCard_btn.UseVisualStyleBackColor = false;
            this.ClearCard_btn.Click += new System.EventHandler(this.ClearCard_btn_Click);
            // 
            // EnterCard_btn
            // 
            this.EnterCard_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.EnterCard_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EnterCard_btn.Location = new System.Drawing.Point(176, 265);
            this.EnterCard_btn.Margin = new System.Windows.Forms.Padding(4);
            this.EnterCard_btn.Name = "EnterCard_btn";
            this.EnterCard_btn.Size = new System.Drawing.Size(157, 59);
            this.EnterCard_btn.TabIndex = 4;
            this.EnterCard_btn.Text = "Enter ";
            this.EnterCard_btn.UseVisualStyleBackColor = false;
            this.EnterCard_btn.Click += new System.EventHandler(this.EnterCard_btn_Click);
            // 
            // ExpDateMonthsTB
            // 
            this.ExpDateMonthsTB.Location = new System.Drawing.Point(375, 153);
            this.ExpDateMonthsTB.Margin = new System.Windows.Forms.Padding(4);
            this.ExpDateMonthsTB.MaxLength = 2;
            this.ExpDateMonthsTB.Name = "ExpDateMonthsTB";
            this.ExpDateMonthsTB.Size = new System.Drawing.Size(34, 22);
            this.ExpDateMonthsTB.TabIndex = 3;
            // 
            // CardNumberTB
            // 
            this.CardNumberTB.Location = new System.Drawing.Point(375, 90);
            this.CardNumberTB.Margin = new System.Windows.Forms.Padding(4);
            this.CardNumberTB.MaxLength = 16;
            this.CardNumberTB.Multiline = true;
            this.CardNumberTB.Name = "CardNumberTB";
            this.CardNumberTB.Size = new System.Drawing.Size(263, 36);
            this.CardNumberTB.TabIndex = 2;
            this.CardNumberTB.TextChanged += new System.EventHandler(this.CardNumberTB_TextChanged);
            // 
            // PIN
            // 
            this.PIN.AutoSize = true;
            this.PIN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PIN.Location = new System.Drawing.Point(169, 144);
            this.PIN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PIN.Name = "PIN";
            this.PIN.Size = new System.Drawing.Size(190, 31);
            this.PIN.TabIndex = 1;
            this.PIN.Text = "Expiary Date:";
            // 
            // CardNumber
            // 
            this.CardNumber.AutoSize = true;
            this.CardNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardNumber.Location = new System.Drawing.Point(169, 90);
            this.CardNumber.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.CardNumber.Name = "CardNumber";
            this.CardNumber.Size = new System.Drawing.Size(196, 31);
            this.CardNumber.TabIndex = 0;
            this.CardNumber.Text = "Card Nomber:";
            // 
            // label_ATM
            // 
            this.label_ATM.AutoSize = true;
            this.label_ATM.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ATM.Location = new System.Drawing.Point(443, 11);
            this.label_ATM.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ATM.Name = "label_ATM";
            this.label_ATM.Size = new System.Drawing.Size(313, 135);
            this.label_ATM.TabIndex = 0;
            this.label_ATM.Text = "ATM";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 28);
            this.label1.TabIndex = 0;
            // 
            // labelX
            // 
            this.labelX.AutoSize = true;
            this.labelX.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelX.Location = new System.Drawing.Point(1513, 11);
            this.labelX.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelX.Name = "labelX";
            this.labelX.Size = new System.Drawing.Size(33, 31);
            this.labelX.TabIndex = 1;
            this.labelX.Text = "X";
            // 
            // CardEntry_X_btn
            // 
            this.CardEntry_X_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CardEntry_X_btn.Location = new System.Drawing.Point(1199, 15);
            this.CardEntry_X_btn.Margin = new System.Windows.Forms.Padding(4);
            this.CardEntry_X_btn.Name = "CardEntry_X_btn";
            this.CardEntry_X_btn.Size = new System.Drawing.Size(55, 43);
            this.CardEntry_X_btn.TabIndex = 2;
            this.CardEntry_X_btn.Text = "X";
            this.CardEntry_X_btn.UseVisualStyleBackColor = true;
            this.CardEntry_X_btn.Click += new System.EventHandler(this.CardEntry_X_btn_Click);
            // 
            // ExpDateYearsTB
            // 
            this.ExpDateYearsTB.Location = new System.Drawing.Point(417, 153);
            this.ExpDateYearsTB.Margin = new System.Windows.Forms.Padding(4);
            this.ExpDateYearsTB.MaxLength = 2;
            this.ExpDateYearsTB.Name = "ExpDateYearsTB";
            this.ExpDateYearsTB.Size = new System.Drawing.Size(34, 22);
            this.ExpDateYearsTB.TabIndex = 6;
            // 
            // CardNameTB
            // 
            this.CardNameTB.Location = new System.Drawing.Point(441, 201);
            this.CardNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.CardNameTB.MaxLength = 160;
            this.CardNameTB.Multiline = true;
            this.CardNameTB.Name = "CardNameTB";
            this.CardNameTB.Size = new System.Drawing.Size(300, 36);
            this.CardNameTB.TabIndex = 8;
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(169, 206);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(264, 31);
            this.label2.TabIndex = 7;
            this.label2.Text = "Card Holder Name:";
            // 
            // CardEntery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(1269, 610);
            this.Controls.Add(this.CardEntry_X_btn);
            this.Controls.Add(this.labelX);
            this.Controls.Add(this.label_ATM);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CardEntery";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label_ATM;
        private System.Windows.Forms.Label PIN;
        private System.Windows.Forms.Label CardNumber;
        private System.Windows.Forms.Label labelX;
        private System.Windows.Forms.TextBox ExpDateMonthsTB;
        private System.Windows.Forms.TextBox CardNumberTB;
        private System.Windows.Forms.Button ClearCard_btn;
        private System.Windows.Forms.Button EnterCard_btn;
        private System.Windows.Forms.Button CardEntry_X_btn;
        private System.Windows.Forms.TextBox ExpDateYearsTB;
        private System.Windows.Forms.TextBox CardNameTB;
        private System.Windows.Forms.Label label2;
    }
}