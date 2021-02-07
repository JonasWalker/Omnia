namespace Omnia
{
    partial class CustomerLookUp
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
            this.NameLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberBox = new System.Windows.Forms.TextBox();
            this.CustomerListView = new System.Windows.Forms.ListView();
            this.idcustomers = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerAltPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerZIPCode = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.customerState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.AllCustomersButton = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(12, 21);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 25);
            this.NameLabel.TabIndex = 1;
            this.NameLabel.Text = "Name:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(346, 21);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.PhoneNumberLabel.TabIndex = 2;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(83, 18);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(257, 31);
            this.NameBox.TabIndex = 4;
            // 
            // PhoneNumberBox
            // 
            this.PhoneNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberBox.Location = new System.Drawing.Point(501, 18);
            this.PhoneNumberBox.Name = "PhoneNumberBox";
            this.PhoneNumberBox.Size = new System.Drawing.Size(179, 31);
            this.PhoneNumberBox.TabIndex = 5;
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
            this.CustomerListView.HideSelection = false;
            this.CustomerListView.Location = new System.Drawing.Point(17, 67);
            this.CustomerListView.Name = "CustomerListView";
            this.CustomerListView.Size = new System.Drawing.Size(1034, 430);
            this.CustomerListView.TabIndex = 20;
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
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(895, 517);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 30);
            this.ClearButton.TabIndex = 23;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(976, 517);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 24;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // AllCustomersButton
            // 
            this.AllCustomersButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllCustomersButton.Location = new System.Drawing.Point(17, 515);
            this.AllCustomersButton.Name = "AllCustomersButton";
            this.AllCustomersButton.Size = new System.Drawing.Size(109, 30);
            this.AllCustomersButton.TabIndex = 25;
            this.AllCustomersButton.Text = "All Customers";
            this.AllCustomersButton.UseVisualStyleBackColor = true;
            this.AllCustomersButton.Click += new System.EventHandler(this.AllCustomersButton_Click);
            // 
            // Search
            // 
            this.Search.BackColor = System.Drawing.SystemColors.Control;
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(976, 20);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 30);
            this.Search.TabIndex = 26;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = false;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CustomerLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1069, 563);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AllCustomersButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.CustomerListView);
            this.Controls.Add(this.PhoneNumberBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "CustomerLookUp";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.CustomerLookUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox PhoneNumberBox;
        private System.Windows.Forms.ListView CustomerListView;
        private System.Windows.Forms.ColumnHeader idcustomers;
        private System.Windows.Forms.ColumnHeader customerName;
        private System.Windows.Forms.ColumnHeader customerPhoneNumber;
        private System.Windows.Forms.ColumnHeader customerAltPhoneNumber;
        private System.Windows.Forms.ColumnHeader customerAddress;
        private System.Windows.Forms.ColumnHeader customerZIPCode;
        private System.Windows.Forms.ColumnHeader customerState;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button AllCustomersButton;
        private System.Windows.Forms.Button Search;
    }
}