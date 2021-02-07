
namespace Omnia
{
    partial class RepairLookUp
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
            this.TagNumberTextBox = new System.Windows.Forms.TextBox();
            this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.TagNumberLabel = new System.Windows.Forms.Label();
            this.PhoneNumberLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.RepairListView = new System.Windows.Forms.ListView();
            this.repairID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairTag = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairCustName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairCustPhoneNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairModel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.repairSerial = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackButton = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.AllRepairs = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.repairNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TagNumberTextBox
            // 
            this.TagNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagNumberTextBox.Location = new System.Drawing.Point(839, 23);
            this.TagNumberTextBox.Name = "TagNumberTextBox";
            this.TagNumberTextBox.Size = new System.Drawing.Size(113, 31);
            this.TagNumberTextBox.TabIndex = 12;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(512, 23);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(190, 31);
            this.PhoneNumberTextBox.TabIndex = 11;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(94, 23);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(257, 31);
            this.NameTextBox.TabIndex = 10;
            // 
            // TagNumberLabel
            // 
            this.TagNumberLabel.AutoSize = true;
            this.TagNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagNumberLabel.Location = new System.Drawing.Point(708, 26);
            this.TagNumberLabel.Name = "TagNumberLabel";
            this.TagNumberLabel.Size = new System.Drawing.Size(136, 25);
            this.TagNumberLabel.TabIndex = 9;
            this.TagNumberLabel.Text = "Tag Number:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(357, 26);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.PhoneNumberLabel.TabIndex = 8;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 25);
            this.NameLabel.TabIndex = 7;
            this.NameLabel.Text = "Name:";
            // 
            // RepairListView
            // 
            this.RepairListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.repairID,
            this.repairTag,
            this.repairCustName,
            this.repairCustPhoneNumber,
            this.repairDescription,
            this.repairModel,
            this.repairSerial,
            this.repairNotes});
            this.RepairListView.HideSelection = false;
            this.RepairListView.Location = new System.Drawing.Point(12, 70);
            this.RepairListView.Name = "RepairListView";
            this.RepairListView.Size = new System.Drawing.Size(1038, 460);
            this.RepairListView.TabIndex = 21;
            this.RepairListView.UseCompatibleStateImageBehavior = false;
            this.RepairListView.View = System.Windows.Forms.View.Details;
            // 
            // repairID
            // 
            this.repairID.Text = "Repair ID";
            this.repairID.Width = 57;
            // 
            // repairTag
            // 
            this.repairTag.Text = "Tag Number";
            this.repairTag.Width = 80;
            // 
            // repairCustName
            // 
            this.repairCustName.Text = "Customer Name";
            this.repairCustName.Width = 132;
            // 
            // repairCustPhoneNumber
            // 
            this.repairCustPhoneNumber.Text = "Phone Number";
            this.repairCustPhoneNumber.Width = 134;
            // 
            // repairDescription
            // 
            this.repairDescription.Text = "Description";
            this.repairDescription.Width = 178;
            // 
            // repairModel
            // 
            this.repairModel.Text = "Model";
            this.repairModel.Width = 123;
            // 
            // repairSerial
            // 
            this.repairSerial.Text = "Serial";
            this.repairSerial.Width = 103;
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(975, 554);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 22;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clear.Location = new System.Drawing.Point(894, 554);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 30);
            this.Clear.TabIndex = 23;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AllRepairs
            // 
            this.AllRepairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllRepairs.Location = new System.Drawing.Point(12, 554);
            this.AllRepairs.Name = "AllRepairs";
            this.AllRepairs.Size = new System.Drawing.Size(93, 30);
            this.AllRepairs.TabIndex = 24;
            this.AllRepairs.Text = "All Repairs";
            this.AllRepairs.UseVisualStyleBackColor = true;
            this.AllRepairs.Click += new System.EventHandler(this.AllRepairs_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(975, 25);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 30);
            this.Search.TabIndex = 25;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // repairNotes
            // 
            this.repairNotes.Text = "Notes";
            this.repairNotes.Width = 224;
            // 
            // RepairLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 596);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.AllRepairs);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.RepairListView);
            this.Controls.Add(this.TagNumberTextBox);
            this.Controls.Add(this.PhoneNumberTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.TagNumberLabel);
            this.Controls.Add(this.PhoneNumberLabel);
            this.Controls.Add(this.NameLabel);
            this.Name = "RepairLookUp";
            this.Text = "Repair Look Up";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TagNumberTextBox;
        private System.Windows.Forms.TextBox PhoneNumberTextBox;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label TagNumberLabel;
        private System.Windows.Forms.Label PhoneNumberLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListView RepairListView;
        private System.Windows.Forms.ColumnHeader repairID;
        private System.Windows.Forms.ColumnHeader repairTag;
        private System.Windows.Forms.ColumnHeader repairCustName;
        private System.Windows.Forms.ColumnHeader repairCustPhoneNumber;
        private System.Windows.Forms.ColumnHeader repairDescription;
        private System.Windows.Forms.ColumnHeader repairModel;
        private System.Windows.Forms.ColumnHeader repairSerial;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button AllRepairs;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.ColumnHeader repairNotes;
    }
}