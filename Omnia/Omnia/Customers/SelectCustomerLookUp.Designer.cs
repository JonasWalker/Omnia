
namespace Omnia
{
    partial class SelectCustomerLookUp
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
            this.Search = new System.Windows.Forms.Button();
            this.CustomerListView = new System.Windows.Forms.ListView();
            this.idcustomers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerAltPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerZIPCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CustomerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.AllCustomersButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Control;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(971, 8);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 30);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CustomerListView
            // 
            this.CustomerListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idcustomers,
            this.customerName,
            this.customerPhoneNumber,
            this.customerAltPhoneNumber,
            this.customerAddress,
            this.customerZIPCode,
            this.customerState});
            this.CustomerListView.FullRowSelect = true;
            this.CustomerListView.HideSelection = false;
            this.CustomerListView.Location = new System.Drawing.Point(12, 55);
            this.CustomerListView.MultiSelect = false;
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.Size = new System.Drawing.Size(1034, 410);
            this.CustomerListView.TabIndex = 9;
            this.CustomerListView.UseCompatibleStateImageBehavior = false;
            this.CustomerListView.View = System.Windows.Forms.View.Details;
            // 
            // idcustomers
            // 
            this.idcustomers.Text = "Customer ID";
            this.idcustomers.Width = 77;
            // 
            // customerName
            // 
            this.customerName.Text = "Customer Name";
            this.customerName.Width = 152;
            // 
            // customerPhoneNumber
            // 
            this.customerPhoneNumber.Text = "Phone Number";
            this.customerPhoneNumber.Width = 132;
            // 
            // customerAltPhoneNumber
            // 
            this.customerAltPhoneNumber.Text = "Alt Phone Number";
            this.customerAltPhoneNumber.Width = 134;
            // 
            // customerAddress
            // 
            this.customerAddress.Text = "Address";
            this.customerAddress.Width = 419;
            // 
            // customerZIPCode
            // 
            this.customerZIPCode.Text = "ZIP Code";
            this.customerZIPCode.Width = 75;
            // 
            // customerState
            // 
            this.customerState.Text = "State";
            this.customerState.Width = 41;
            // 
            // CustomerPhoneNumberTextBox
            // 
            this.CustomerPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneNumberTextBox.Location = new System.Drawing.Point(496, 6);
            this.CustomerPhoneNumberTextBox.Name = "CustomerPhoneNumberTextBox";
            this.CustomerPhoneNumberTextBox.Size = new System.Drawing.Size(179, 31);
            this.CustomerPhoneNumberTextBox.TabIndex = 1;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTextBox.Location = new System.Drawing.Point(78, 6);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(257, 31);
            this.CustomerNameTextBox.TabIndex = 0;
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(341, 9);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.PhoneNumberLabel.TabIndex = 8;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(7, 9);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(74, 25);
            this.CustomerNameLabel.TabIndex = 7;
            this.CustomerNameLabel.Text = "Name:";
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.SystemColors.Control;
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(969, 480);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 6;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.SystemColors.Control;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(888, 480);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 30);
            this.ClearButton.TabIndex = 5;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.SystemColors.Control;
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.Location = new System.Drawing.Point(807, 480);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 30);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = false;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // AllCustomersButton
            // 
            this.AllCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCustomersButton.Location = new System.Drawing.Point(12, 480);
            this.AllCustomersButton.Name = "AllCustomersButton";
            this.AllCustomersButton.Size = new System.Drawing.Size(109, 30);
            this.AllCustomersButton.TabIndex = 4;
            this.AllCustomersButton.Text = "All Customers";
            this.AllCustomersButton.UseVisualStyleBackColor = true;
            this.AllCustomersButton.Click += new System.EventHandler(this.AllCustomersButton_Click);
            // 
            // SelectCustomerLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 522);
            this.Controls.Add(this.AllCustomersButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.CustomerListView);
            this.Controls.Add(this.CustomerPhoneNumberTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectCustomerLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectCustomerLookUp";
            this.Load += new System.EventHandler(this.SelectCustomerLookUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ListView CustomerListView;
        private System.Windows.Forms.ColumnHeader idcustomers;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader customerPhoneNumber;
        private System.Windows.Forms.ColumnHeader customerAltPhoneNumber;
        private System.Windows.Forms.ColumnHeader customerAddress;
        private System.Windows.Forms.ColumnHeader customerZIPCode;
        private System.Windows.Forms.ColumnHeader customerState;
        private System.Windows.Forms.TextBox CustomerPhoneNumberTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button AllCustomersButton;
    }
}