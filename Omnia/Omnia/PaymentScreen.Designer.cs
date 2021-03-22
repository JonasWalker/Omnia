
namespace Omnia
{
    partial class PaymentScreen
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
            this.CashTextBox = new System.Windows.Forms.TextBox();
            this.CashLabel = new System.Windows.Forms.Label();
            this.CreditCardTextBox = new System.Windows.Forms.TextBox();
            this.CreditCardLabel = new System.Windows.Forms.Label();
            this.DebitCardTextBox = new System.Windows.Forms.TextBox();
            this.DebitCardLabel = new System.Windows.Forms.Label();
            this.CheckTextBox = new System.Windows.Forms.TextBox();
            this.CheckLabel = new System.Windows.Forms.Label();
            this.TotalOutButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CashTextBox
            // 
            this.CashTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashTextBox.Location = new System.Drawing.Point(285, 113);
            this.CashTextBox.Name = "CashTextBox";
            this.CashTextBox.Size = new System.Drawing.Size(269, 31);
            this.CashTextBox.TabIndex = 28;
            this.CashTextBox.Text = "0.00";
            this.CashTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CashTextBox_KeyPress);
            this.CashTextBox.Leave += new System.EventHandler(this.CashTextBox_Leave);
            // 
            // CashLabel
            // 
            this.CashLabel.AutoSize = true;
            this.CashLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CashLabel.Location = new System.Drawing.Point(211, 116);
            this.CashLabel.Name = "CashLabel";
            this.CashLabel.Size = new System.Drawing.Size(68, 25);
            this.CashLabel.TabIndex = 27;
            this.CashLabel.Text = "Cash:";
            // 
            // CreditCardTextBox
            // 
            this.CreditCardTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardTextBox.Location = new System.Drawing.Point(285, 150);
            this.CreditCardTextBox.Name = "CreditCardTextBox";
            this.CreditCardTextBox.Size = new System.Drawing.Size(269, 31);
            this.CreditCardTextBox.TabIndex = 30;
            this.CreditCardTextBox.Text = "0.00";
            this.CreditCardTextBox.TextChanged += new System.EventHandler(this.CreditCardTextBox_TextChanged);
            this.CreditCardTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CreditCardTextBox_KeyPress);
            this.CreditCardTextBox.Leave += new System.EventHandler(this.CreditCardTextBox_Leave);
            // 
            // CreditCardLabel
            // 
            this.CreditCardLabel.AutoSize = true;
            this.CreditCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreditCardLabel.Location = new System.Drawing.Point(153, 153);
            this.CreditCardLabel.Name = "CreditCardLabel";
            this.CreditCardLabel.Size = new System.Drawing.Size(127, 25);
            this.CreditCardLabel.TabIndex = 29;
            this.CreditCardLabel.Text = "Credit Card:";
            // 
            // DebitCardTextBox
            // 
            this.DebitCardTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitCardTextBox.Location = new System.Drawing.Point(285, 187);
            this.DebitCardTextBox.Name = "DebitCardTextBox";
            this.DebitCardTextBox.Size = new System.Drawing.Size(269, 31);
            this.DebitCardTextBox.TabIndex = 32;
            this.DebitCardTextBox.Text = "0.00";
            this.DebitCardTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.DebitCardTextBox_KeyPress);
            this.DebitCardTextBox.Leave += new System.EventHandler(this.DebitCardTextBox_Leave);
            // 
            // DebitCardLabel
            // 
            this.DebitCardLabel.AutoSize = true;
            this.DebitCardLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DebitCardLabel.Location = new System.Drawing.Point(159, 190);
            this.DebitCardLabel.Name = "DebitCardLabel";
            this.DebitCardLabel.Size = new System.Drawing.Size(120, 25);
            this.DebitCardLabel.TabIndex = 31;
            this.DebitCardLabel.Text = "Debit Card:";
            // 
            // CheckTextBox
            // 
            this.CheckTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckTextBox.Location = new System.Drawing.Point(285, 224);
            this.CheckTextBox.Name = "CheckTextBox";
            this.CheckTextBox.Size = new System.Drawing.Size(269, 31);
            this.CheckTextBox.TabIndex = 34;
            this.CheckTextBox.Text = "0.00";
            this.CheckTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckTextBox_KeyPress);
            this.CheckTextBox.Leave += new System.EventHandler(this.CheckTextBox_Leave);
            // 
            // CheckLabel
            // 
            this.CheckLabel.AutoSize = true;
            this.CheckLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CheckLabel.Location = new System.Drawing.Point(200, 227);
            this.CheckLabel.Name = "CheckLabel";
            this.CheckLabel.Size = new System.Drawing.Size(79, 25);
            this.CheckLabel.TabIndex = 33;
            this.CheckLabel.Text = "Check:";
            // 
            // TotalOutButton
            // 
            this.TotalOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOutButton.Location = new System.Drawing.Point(12, 408);
            this.TotalOutButton.Name = "TotalOutButton";
            this.TotalOutButton.Size = new System.Drawing.Size(79, 30);
            this.TotalOutButton.TabIndex = 36;
            this.TotalOutButton.Text = "Total Out";
            this.TotalOutButton.UseVisualStyleBackColor = true;
            this.TotalOutButton.Click += new System.EventHandler(this.TotalOutButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(713, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 35;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(312, 85);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(221, 25);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Enter Total Amount(s)";
            // 
            // ClearListButton
            // 
            this.ClearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearListButton.Location = new System.Drawing.Point(632, 408);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(75, 30);
            this.ClearListButton.TabIndex = 38;
            this.ClearListButton.Text = "Clear";
            this.ClearListButton.UseVisualStyleBackColor = true;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.Location = new System.Drawing.Point(369, 43);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(90, 25);
            this.TotalLabel.TabIndex = 40;
            this.TotalLabel.Text = "$000.00";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalLabel.Location = new System.Drawing.Point(142, 43);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(221, 25);
            this.GrandTotalLabel.TabIndex = 42;
            this.GrandTotalLabel.Text = "Enter Total Amount(s)";
            // 
            // PaymentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.TotalOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CheckTextBox);
            this.Controls.Add(this.CheckLabel);
            this.Controls.Add(this.DebitCardTextBox);
            this.Controls.Add(this.DebitCardLabel);
            this.Controls.Add(this.CreditCardTextBox);
            this.Controls.Add(this.CreditCardLabel);
            this.Controls.Add(this.CashTextBox);
            this.Controls.Add(this.CashLabel);
            this.Name = "PaymentScreen";
            this.Text = "PaymentScreen";
            this.Load += new System.EventHandler(this.PaymentScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox CashTextBox;
        private System.Windows.Forms.Label CashLabel;
        private System.Windows.Forms.TextBox CreditCardTextBox;
        private System.Windows.Forms.Label CreditCardLabel;
        private System.Windows.Forms.TextBox DebitCardTextBox;
        private System.Windows.Forms.Label DebitCardLabel;
        private System.Windows.Forms.TextBox CheckTextBox;
        private System.Windows.Forms.Label CheckLabel;
        private System.Windows.Forms.Button TotalOutButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label GrandTotalLabel;
    }
}