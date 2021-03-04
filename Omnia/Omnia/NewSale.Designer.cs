﻿
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.idparts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partDescription1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partyQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partMSRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Search = new System.Windows.Forms.Button();
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
            this.PrintButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idparts,
            this.partNumber,
            this.partDescription1,
            this.partyQty,
            this.partMSRP,
            this.partCost,
            this.partNote});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 135);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(993, 346);
            this.listView1.TabIndex = 20;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            this.partCost.Width = 126;
            // 
            // partNote
            // 
            this.partNote.Text = "Notes";
            this.partNote.Width = 261;
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(953, 82);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 30);
            this.Search.TabIndex = 28;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // PartDescriptionTextBox
            // 
            this.PartDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionTextBox.Location = new System.Drawing.Point(604, 81);
            this.PartDescriptionTextBox.Name = "PartDescriptionTextBox";
            this.PartDescriptionTextBox.Size = new System.Drawing.Size(327, 31);
            this.PartDescriptionTextBox.TabIndex = 27;
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberTextBox.Location = new System.Drawing.Point(162, 82);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartNumberTextBox.TabIndex = 26;
            // 
            // PartDescriptionLabel
            // 
            this.PartDescriptionLabel.AutoSize = true;
            this.PartDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionLabel.Location = new System.Drawing.Point(435, 84);
            this.PartDescriptionLabel.Name = "PartDescriptionLabel";
            this.PartDescriptionLabel.Size = new System.Drawing.Size(171, 25);
            this.PartDescriptionLabel.TabIndex = 25;
            this.PartDescriptionLabel.Text = "Part Description:";
            // 
            // PartNumberLabel
            // 
            this.PartNumberLabel.AutoSize = true;
            this.PartNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberLabel.Location = new System.Drawing.Point(18, 84);
            this.PartNumberLabel.Name = "PartNumberLabel";
            this.PartNumberLabel.Size = new System.Drawing.Size(138, 25);
            this.PartNumberLabel.TabIndex = 24;
            this.PartNumberLabel.Text = "Part Number:";
            // 
            // CustomerSearchButton
            // 
            this.CustomerSearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerSearchButton.Location = new System.Drawing.Point(953, 28);
            this.CustomerSearchButton.Name = "CustomerSearchButton";
            this.CustomerSearchButton.Size = new System.Drawing.Size(75, 30);
            this.CustomerSearchButton.TabIndex = 33;
            this.CustomerSearchButton.Text = "Search";
            this.CustomerSearchButton.UseVisualStyleBackColor = true;
            // 
            // CustomerPhoneNumberTextBox
            // 
            this.CustomerPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneNumberTextBox.Location = new System.Drawing.Point(604, 27);
            this.CustomerPhoneNumberTextBox.Name = "CustomerPhoneNumberTextBox";
            this.CustomerPhoneNumberTextBox.Size = new System.Drawing.Size(327, 31);
            this.CustomerPhoneNumberTextBox.TabIndex = 32;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameTextBox.Location = new System.Drawing.Point(162, 28);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(269, 31);
            this.CustomerNameTextBox.TabIndex = 31;
            // 
            // CustomerPhoneNumberLabel
            // 
            this.CustomerPhoneNumberLabel.AutoSize = true;
            this.CustomerPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerPhoneNumberLabel.Location = new System.Drawing.Point(435, 30);
            this.CustomerPhoneNumberLabel.Name = "CustomerPhoneNumberLabel";
            this.CustomerPhoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.CustomerPhoneNumberLabel.TabIndex = 30;
            this.CustomerPhoneNumberLabel.Text = "Phone Number:";
            // 
            // CustomerNameLabel
            // 
            this.CustomerNameLabel.AutoSize = true;
            this.CustomerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerNameLabel.Location = new System.Drawing.Point(82, 31);
            this.CustomerNameLabel.Name = "CustomerNameLabel";
            this.CustomerNameLabel.Size = new System.Drawing.Size(74, 25);
            this.CustomerNameLabel.TabIndex = 29;
            this.CustomerNameLabel.Text = "Name:";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(953, 509);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 34;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // TotalOutButton
            // 
            this.TotalOutButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalOutButton.Location = new System.Drawing.Point(872, 509);
            this.TotalOutButton.Name = "TotalOutButton";
            this.TotalOutButton.Size = new System.Drawing.Size(75, 30);
            this.TotalOutButton.TabIndex = 35;
            this.TotalOutButton.Text = "Total Out";
            this.TotalOutButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrintButton.Location = new System.Drawing.Point(35, 509);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(75, 30);
            this.PrintButton.TabIndex = 36;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // NewSale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1069, 563);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.TotalOutButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CustomerSearchButton);
            this.Controls.Add(this.CustomerPhoneNumberTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerPhoneNumberLabel);
            this.Controls.Add(this.CustomerNameLabel);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.PartDescriptionTextBox);
            this.Controls.Add(this.PartNumberTextBox);
            this.Controls.Add(this.PartDescriptionLabel);
            this.Controls.Add(this.PartNumberLabel);
            this.Controls.Add(this.listView1);
            this.Name = "NewSale";
            this.Text = "NewSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader idparts;
        private System.Windows.Forms.ColumnHeader partNumber;
        private System.Windows.Forms.ColumnHeader partDescription1;
        private System.Windows.Forms.ColumnHeader partyQty;
        private System.Windows.Forms.ColumnHeader partMSRP;
        private System.Windows.Forms.ColumnHeader partCost;
        private System.Windows.Forms.ColumnHeader partNote;
        private System.Windows.Forms.Button Search;
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
        private System.Windows.Forms.Button PrintButton;
    }
}