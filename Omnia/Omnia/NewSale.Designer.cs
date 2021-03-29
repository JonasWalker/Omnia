
namespace Omnia
{
    partial class NewSale
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
            this.components = new System.ComponentModel.Container();
            this.PartsListView = new System.Windows.Forms.ListView();
            this.idparts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partDescription1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partyQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partMSRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartSearchButton = new System.Windows.Forms.Button();
            this.PartDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PartNumberTextBox = new System.Windows.Forms.TextBox();
            this.PartDescriptionLabel = new System.Windows.Forms.Label();
            this.PartNumberLabel = new System.Windows.Forms.Label();
            this.CustomerSearchButton = new System.Windows.Forms.Button();
            this.CustomerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerPhoneNumberLabel = new System.Windows.Forms.Label();
            this.CustomerNameLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.TotalOutButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.TotalItemLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.GrandTotalLabel = new System.Windows.Forms.Label();
            this.TotalItemsTextBox = new System.Windows.Forms.TextBox();
            this.GrandTotalTextBox = new System.Windows.Forms.TextBox();
            this.TotalTaxTextBox = new System.Windows.Forms.TextBox();
            this.TotalCostTextBox = new System.Windows.Forms.TextBox();
            this.DiscountTextBox = new System.Windows.Forms.TextBox();
            this.DiscountLabel = new System.Windows.Forms.Label();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DateLabel = new System.Windows.Forms.ToolStripLabel();
            this.EmployeeNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PartsListView
            // 
            this.PartsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idparts,
            this.partNumber,
            this.partDescription1,
            this.partyQty,
            this.partMSRP,
            this.partCost,
            this.partNote});
            this.PartsListView.FullRowSelect = true;
            this.PartsListView.HideSelection = false;
            this.PartsListView.Location = new System.Drawing.Point(23, 134);
            this.PartsListView.Name = "PartsListView";
            this.PartsListView.Size = new System.Drawing.Size(1005, 314);
            this.PartsListView.TabIndex = 6;
            this.PartsListView.UseCompatibleStateImageBehavior = false;
            this.PartsListView.View = System.Windows.Forms.View.Details;
            // 
            // idparts
            // 
            this.idparts.Text = "Part ID";
            this.idparts.Width = 77;
            // 
            // partNumber
            // 
            this.partNumber.Text = "Part Number";
            this.partNumber.Width = 117;
            // 
            // partDescription1
            // 
            this.partDescription1.Text = "Description";
            this.partDescription1.Width = 150;
            // 
            // partyQty
            // 
            this.partyQty.Text = "Quantity";
            this.partyQty.Width = 134;
            // 
            // partMSRP
            // 
            this.partMSRP.Text = "MSRP";
            this.partMSRP.Width = 124;
            // 
            // partCost
            // 
            this.partCost.Text = "Cost";
            this.partCost.Width = 118;
            // 
            // partNote
            // 
            this.partNote.Text = "Notes";
            this.partNote.Width = 261;
            // 
            // PartSearchButton
            // 
            this.PartSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartSearchButton.Location = new System.Drawing.Point(953, 82);
            this.PartSearchButton.Name = "PartSearchButton";
            this.PartSearchButton.Size = new System.Drawing.Size(75, 30);
            this.PartSearchButton.TabIndex = 5;
            this.PartSearchButton.Text = "Search";
            this.PartSearchButton.UseVisualStyleBackColor = true;
            this.PartSearchButton.Click += new System.EventHandler(this.PartSearchButton_Click);
            // 
            // PartDescriptionTextBox
            // 
            this.PartDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionTextBox.Location = new System.Drawing.Point(604, 81);
            this.PartDescriptionTextBox.Name = "PartDescriptionTextBox";
            this.PartDescriptionTextBox.Size = new System.Drawing.Size(327, 31);
            this.PartDescriptionTextBox.TabIndex = 4;
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberTextBox.Location = new System.Drawing.Point(162, 82);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartNumberTextBox.TabIndex = 3;
            // 
            // PartDescriptionLabel
            // 
            this.PartDescriptionLabel.AutoSize = true;
            this.PartDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionLabel.Location = new System.Drawing.Point(435, 84);
            this.PartDescriptionLabel.Name = "PartDescriptionLabel";
            this.PartDescriptionLabel.Size = new System.Drawing.Size(171, 25);
            this.PartDescriptionLabel.TabIndex = 15;
            this.PartDescriptionLabel.Text = "Part Description:";
            // 
            // PartNumberLabel
            // 
            this.PartNumberLabel.AutoSize = true;
            this.PartNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberLabel.Location = new System.Drawing.Point(18, 84);
            this.PartNumberLabel.Name = "PartNumberLabel";
            this.PartNumberLabel.Size = new System.Drawing.Size(138, 25);
            this.PartNumberLabel.TabIndex = 13;
            this.PartNumberLabel.Text = "Part Number:";
            // 
            // CustomerSearchButton
            // 
            this.CustomerSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchButton.Location = new System.Drawing.Point(953, 28);
            this.CustomerSearchButton.Name = "CustomerSearchButton";
            this.CustomerSearchButton.Size = new System.Drawing.Size(75, 30);
            this.CustomerSearchButton.TabIndex = 2;
            this.CustomerSearchButton.Text = "Search";
            this.CustomerSearchButton.UseVisualStyleBackColor = true;
            this.CustomerSearchButton.Click += new System.EventHandler(this.CustomerSearchButton_Click);
            // 
            // CustomerPhoneNumberTextBox
            // 
            this.CustomerPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneNumberTextBox.Location = new System.Drawing.Point(604, 27);
            this.CustomerPhoneNumberTextBox.Name = "CustomerPhoneNumberTextBox";
            this.CustomerPhoneNumberTextBox.Size = new System.Drawing.Size(327, 31);
            this.CustomerPhoneNumberTextBox.TabIndex = 1;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTextBox.Location = new System.Drawing.Point(162, 28);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(269, 31);
            this.CustomerNameTextBox.TabIndex = 0;
            // 
            // CustomerPhoneNumberLabel
            // 
            this.CustomerPhoneNumberLabel.AutoSize = true;
            this.CustomerPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneNumberLabel.Location = new System.Drawing.Point(435, 30);
            this.CustomerPhoneNumberLabel.Name = "CustomerPhoneNumberLabel";
            this.CustomerPhoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.CustomerPhoneNumberLabel.TabIndex = 14;
            this.CustomerPhoneNumberLabel.Text = "Phone Number:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(82, 31);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(74, 25);
            this.CustomerNameLabel.TabIndex = 12;
            this.CustomerNameLabel.Text = "Name:";
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(953, 495);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // TotalOutButton
            // 
            this.TotalOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOutButton.Location = new System.Drawing.Point(23, 495);
            this.TotalOutButton.Name = "TotalOutButton";
            this.TotalOutButton.Size = new System.Drawing.Size(75, 30);
            this.TotalOutButton.TabIndex = 8;
            this.TotalOutButton.Text = "Total Out";
            this.TotalOutButton.UseVisualStyleBackColor = true;
            this.TotalOutButton.Click += new System.EventHandler(this.TotalOutButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearListButton.Location = new System.Drawing.Point(872, 495);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(75, 30);
            this.ClearListButton.TabIndex = 10;
            this.ClearListButton.Text = "Clear";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartButton.Location = new System.Drawing.Point(759, 495);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(107, 30);
            this.DeletePartButton.TabIndex = 9;
            this.DeletePartButton.Text = "Delete Part(s)";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // TotalItemLabel
            // 
            this.TotalItemLabel.AutoSize = true;
            this.TotalItemLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemLabel.Location = new System.Drawing.Point(182, 457);
            this.TotalItemLabel.Name = "TotalItemLabel";
            this.TotalItemLabel.Size = new System.Drawing.Size(123, 25);
            this.TotalItemLabel.TabIndex = 17;
            this.TotalItemLabel.Text = "Total Items:";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostLabel.Location = new System.Drawing.Point(371, 457);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(66, 25);
            this.TotalCostLabel.TabIndex = 19;
            this.TotalCostLabel.Text = "Total:";
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaxLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.TaxLabel.Location = new System.Drawing.Point(576, 457);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(54, 25);
            this.TaxLabel.TabIndex = 21;
            this.TaxLabel.Text = "Tax:";
            // 
            // GrandTotalLabel
            // 
            this.GrandTotalLabel.AutoSize = true;
            this.GrandTotalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalLabel.Location = new System.Drawing.Point(777, 457);
            this.GrandTotalLabel.Name = "GrandTotalLabel";
            this.GrandTotalLabel.Size = new System.Drawing.Size(131, 25);
            this.GrandTotalLabel.TabIndex = 23;
            this.GrandTotalLabel.Text = "Grand Total:";
            // 
            // TotalItemsTextBox
            // 
            this.TotalItemsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalItemsTextBox.Location = new System.Drawing.Point(305, 454);
            this.TotalItemsTextBox.Name = "TotalItemsTextBox";
            this.TotalItemsTextBox.ReadOnly = true;
            this.TotalItemsTextBox.Size = new System.Drawing.Size(60, 31);
            this.TotalItemsTextBox.TabIndex = 18;
            this.TotalItemsTextBox.Text = "0";
            this.TotalItemsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // GrandTotalTextBox
            // 
            this.GrandTotalTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrandTotalTextBox.Location = new System.Drawing.Point(914, 454);
            this.GrandTotalTextBox.Name = "GrandTotalTextBox";
            this.GrandTotalTextBox.ReadOnly = true;
            this.GrandTotalTextBox.Size = new System.Drawing.Size(135, 31);
            this.GrandTotalTextBox.TabIndex = 24;
            this.GrandTotalTextBox.Text = "$000.00";
            this.GrandTotalTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalTaxTextBox
            // 
            this.TotalTaxTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalTaxTextBox.Location = new System.Drawing.Point(636, 454);
            this.TotalTaxTextBox.Name = "TotalTaxTextBox";
            this.TotalTaxTextBox.ReadOnly = true;
            this.TotalTaxTextBox.Size = new System.Drawing.Size(135, 31);
            this.TotalTaxTextBox.TabIndex = 22;
            this.TotalTaxTextBox.Text = "$000.00";
            this.TotalTaxTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalCostTextBox
            // 
            this.TotalCostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalCostTextBox.Location = new System.Drawing.Point(435, 454);
            this.TotalCostTextBox.Name = "TotalCostTextBox";
            this.TotalCostTextBox.ReadOnly = true;
            this.TotalCostTextBox.Size = new System.Drawing.Size(135, 31);
            this.TotalCostTextBox.TabIndex = 20;
            this.TotalCostTextBox.Text = "$000.00";
            this.TotalCostTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // DiscountTextBox
            // 
            this.DiscountTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountTextBox.Location = new System.Drawing.Point(116, 454);
            this.DiscountTextBox.Name = "DiscountTextBox";
            this.DiscountTextBox.Size = new System.Drawing.Size(60, 31);
            this.DiscountTextBox.TabIndex = 7;
            this.DiscountTextBox.Text = "0";
            this.DiscountTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.DiscountTextBox.Leave += new System.EventHandler(this.DiscountTextBox_Leave);
            // 
            // DiscountLabel
            // 
            this.DiscountLabel.AutoSize = true;
            this.DiscountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DiscountLabel.Location = new System.Drawing.Point(8, 457);
            this.DiscountLabel.Name = "DiscountLabel";
            this.DiscountLabel.Size = new System.Drawing.Size(102, 25);
            this.DiscountLabel.TabIndex = 16;
            this.DiscountLabel.Text = "Discount:";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateLabel,
            this.EmployeeNameLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 538);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1069, 25);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DateLabel
            // 
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(31, 22);
            this.DateLabel.Text = "Date";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(39, 22);
            this.EmployeeNameLabel.Text = "Name";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1069, 563);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DiscountTextBox);
            this.Controls.Add(this.DiscountLabel);
            this.Controls.Add(this.TotalCostTextBox);
            this.Controls.Add(this.TotalTaxTextBox);
            this.Controls.Add(this.GrandTotalTextBox);
            this.Controls.Add(this.TotalItemsTextBox);
            this.Controls.Add(this.GrandTotalLabel);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.TotalItemLabel);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.TotalOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CustomerSearchButton);
            this.Controls.Add(this.CustomerPhoneNumberTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerPhoneNumberLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.PartSearchButton);
            this.Controls.Add(this.PartDescriptionTextBox);
            this.Controls.Add(this.PartNumberTextBox);
            this.Controls.Add(this.PartDescriptionLabel);
            this.Controls.Add(this.PartNumberLabel);
            this.Controls.Add(this.PartsListView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewSale";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Sale";
            this.Load += new System.EventHandler(this.NewSale_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView PartsListView;
        private System.Windows.Forms.ColumnHeader idparts;
        private System.Windows.Forms.ColumnHeader partNumber;
        private System.Windows.Forms.ColumnHeader partDescription1;
        private System.Windows.Forms.ColumnHeader partyQty;
        private System.Windows.Forms.ColumnHeader partMSRP;
        private System.Windows.Forms.ColumnHeader partCost;
        private System.Windows.Forms.ColumnHeader partNote;
        private System.Windows.Forms.Button PartSearchButton;
        private System.Windows.Forms.TextBox PartDescriptionTextBox;
        private System.Windows.Forms.TextBox PartNumberTextBox;
        private System.Windows.Forms.Label PartDescriptionLabel;
        private System.Windows.Forms.Label PartNumberLabel;
        private System.Windows.Forms.Button CustomerSearchButton;
        private System.Windows.Forms.TextBox CustomerPhoneNumberTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerPhoneNumberLabel;
        private System.Windows.Forms.Label CustomerNameLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button TotalOutButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.Label TotalItemLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label GrandTotalLabel;
        private System.Windows.Forms.TextBox TotalItemsTextBox;
        private System.Windows.Forms.TextBox GrandTotalTextBox;
        private System.Windows.Forms.TextBox TotalTaxTextBox;
        private System.Windows.Forms.TextBox TotalCostTextBox;
        private System.Windows.Forms.TextBox DiscountTextBox;
        private System.Windows.Forms.Label DiscountLabel;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel DateLabel;
        private System.Windows.Forms.ToolStripLabel EmployeeNameLabel;
        private System.Windows.Forms.Timer timer1;
    }
}