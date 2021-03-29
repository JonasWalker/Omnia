
namespace Omnia
{
    partial class SelectPartLookUp
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
            this.SearchButton = new System.Windows.Forms.Button();
            this.PartsListView = new System.Windows.Forms.ListView();
            this.idparts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partDescription1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partyQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partMSRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PartDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PartNumberTextBox = new System.Windows.Forms.TextBox();
            this.PartDescriptionLabel = new System.Windows.Forms.Label();
            this.PartNumberLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ClearListButton = new System.Windows.Forms.Button();
            this.AllParts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SearchButton
            // 
            this.SearchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchButton.Location = new System.Drawing.Point(946, 15);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 30);
            this.SearchButton.TabIndex = 2;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
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
            this.PartsListView.Location = new System.Drawing.Point(28, 52);
            this.PartsListView.Name = "PartsListView";
            this.PartsListView.Size = new System.Drawing.Size(993, 400);
            this.PartsListView.TabIndex = 9;
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
            this.partCost.Width = 126;
            // 
            // partNote
            // 
            this.partNote.Text = "Notes";
            this.partNote.Width = 261;
            // 
            // PartDescriptionTextBox
            // 
            this.PartDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionTextBox.Location = new System.Drawing.Point(597, 14);
            this.PartDescriptionTextBox.Name = "PartDescriptionTextBox";
            this.PartDescriptionTextBox.Size = new System.Drawing.Size(327, 31);
            this.PartDescriptionTextBox.TabIndex = 1;
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberTextBox.Location = new System.Drawing.Point(155, 15);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartNumberTextBox.TabIndex = 0;
            // 
            // PartDescriptionLabel
            // 
            this.PartDescriptionLabel.AutoSize = true;
            this.PartDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionLabel.Location = new System.Drawing.Point(428, 17);
            this.PartDescriptionLabel.Name = "PartDescriptionLabel";
            this.PartDescriptionLabel.Size = new System.Drawing.Size(171, 25);
            this.PartDescriptionLabel.TabIndex = 8;
            this.PartDescriptionLabel.Text = "Part Description:";
            // 
            // PartNumberLabel
            // 
            this.PartNumberLabel.AutoSize = true;
            this.PartNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberLabel.Location = new System.Drawing.Point(23, 18);
            this.PartNumberLabel.Name = "PartNumberLabel";
            this.PartNumberLabel.Size = new System.Drawing.Size(138, 25);
            this.PartNumberLabel.TabIndex = 7;
            this.PartNumberLabel.Text = "Part Number:";
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(946, 480);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 5;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // SelectButton
            // 
            this.SelectButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectButton.Location = new System.Drawing.Point(784, 480);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(75, 30);
            this.SelectButton.TabIndex = 3;
            this.SelectButton.Text = "Select";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.SelectButton_Click);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearListButton.Location = new System.Drawing.Point(865, 480);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(75, 30);
            this.ClearListButton.TabIndex = 4;
            this.ClearListButton.Text = "Clear";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // AllParts
            // 
            this.AllParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllParts.Location = new System.Drawing.Point(28, 480);
            this.AllParts.Name = "AllParts";
            this.AllParts.Size = new System.Drawing.Size(75, 30);
            this.AllParts.TabIndex = 6;
            this.AllParts.Text = "All Parts";
            this.AllParts.UseVisualStyleBackColor = true;
            this.AllParts.Click += new System.EventHandler(this.AllParts_Click);
            // 
            // SelectPartLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 522);
            this.Controls.Add(this.AllParts);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.PartsListView);
            this.Controls.Add(this.PartDescriptionTextBox);
            this.Controls.Add(this.PartNumberTextBox);
            this.Controls.Add(this.PartDescriptionLabel);
            this.Controls.Add(this.PartNumberLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SelectPartLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SelectPartLookUp";
            this.Load += new System.EventHandler(this.SelectPartLookUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListView PartsListView;
        private System.Windows.Forms.ColumnHeader idparts;
        private System.Windows.Forms.ColumnHeader partNumber;
        private System.Windows.Forms.ColumnHeader partDescription1;
        private System.Windows.Forms.ColumnHeader partyQty;
        private System.Windows.Forms.ColumnHeader partMSRP;
        private System.Windows.Forms.ColumnHeader partCost;
        private System.Windows.Forms.ColumnHeader partNote;
        private System.Windows.Forms.TextBox PartDescriptionTextBox;
        private System.Windows.Forms.TextBox PartNumberTextBox;
        private System.Windows.Forms.Label PartDescriptionLabel;
        private System.Windows.Forms.Label PartNumberLabel;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Button AllParts;
    }
}