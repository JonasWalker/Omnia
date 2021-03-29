
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
            this.components = new System.ComponentModel.Container();
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
            this.repairNotes = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BackButton = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.AllRepairs = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.DeleteRepairBtton = new System.Windows.Forms.Button();
            this.CreateRepairButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DateLabel = new System.Windows.Forms.ToolStripLabel();
            this.EmployeeNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EditButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TagNumberTextBox
            // 
            this.TagNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagNumberTextBox.Location = new System.Drawing.Point(839, 23);
            this.TagNumberTextBox.Name = "TagNumberTextBox";
            this.TagNumberTextBox.Size = new System.Drawing.Size(113, 31);
            this.TagNumberTextBox.TabIndex = 2;
            // 
            // PhoneNumberTextBox
            // 
            this.PhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberTextBox.Location = new System.Drawing.Point(512, 23);
            this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
            this.PhoneNumberTextBox.Size = new System.Drawing.Size(190, 31);
            this.PhoneNumberTextBox.TabIndex = 1;
            // 
            // NameTextBox
            // 
            this.NameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameTextBox.Location = new System.Drawing.Point(94, 23);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(257, 31);
            this.NameTextBox.TabIndex = 0;
            // 
            // TagNumberLabel
            // 
            this.TagNumberLabel.AutoSize = true;
            this.TagNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TagNumberLabel.Location = new System.Drawing.Point(708, 26);
            this.TagNumberLabel.Name = "TagNumberLabel";
            this.TagNumberLabel.Size = new System.Drawing.Size(136, 25);
            this.TagNumberLabel.TabIndex = 12;
            this.TagNumberLabel.Text = "Tag Number:";
            // 
            // PhoneNumberLabel
            // 
            this.PhoneNumberLabel.AutoSize = true;
            this.PhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneNumberLabel.Location = new System.Drawing.Point(357, 26);
            this.PhoneNumberLabel.Name = "PhoneNumberLabel";
            this.PhoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.PhoneNumberLabel.TabIndex = 11;
            this.PhoneNumberLabel.Text = "Phone Number:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(23, 26);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(74, 25);
            this.NameLabel.TabIndex = 10;
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
            this.RepairListView.FullRowSelect = true;
            this.RepairListView.HideSelection = false;
            this.RepairListView.Location = new System.Drawing.Point(12, 70);
            this.RepairListView.Name = "RepairListView";
            this.RepairListView.Size = new System.Drawing.Size(1038, 453);
            this.RepairListView.TabIndex = 4;
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
            // repairNotes
            // 
            this.repairNotes.Text = "Notes";
            this.repairNotes.Width = 224;
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(975, 529);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Clear.Location = new System.Drawing.Point(894, 529);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 30);
            this.Clear.TabIndex = 8;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // AllRepairs
            // 
            this.AllRepairs.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllRepairs.Location = new System.Drawing.Point(12, 529);
            this.AllRepairs.Name = "AllRepairs";
            this.AllRepairs.Size = new System.Drawing.Size(93, 30);
            this.AllRepairs.TabIndex = 6;
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
            this.Search.TabIndex = 3;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // DeleteRepairBtton
            // 
            this.DeleteRepairBtton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteRepairBtton.Location = new System.Drawing.Point(759, 529);
            this.DeleteRepairBtton.Name = "DeleteRepairBtton";
            this.DeleteRepairBtton.Size = new System.Drawing.Size(129, 30);
            this.DeleteRepairBtton.TabIndex = 7;
            this.DeleteRepairBtton.Text = "Delete Repair";
            this.DeleteRepairBtton.UseVisualStyleBackColor = true;
            this.DeleteRepairBtton.Click += new System.EventHandler(this.DeleteRepairBtton_Click);
            // 
            // CreateRepairButton
            // 
            this.CreateRepairButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateRepairButton.Location = new System.Drawing.Point(483, 529);
            this.CreateRepairButton.Name = "CreateRepairButton";
            this.CreateRepairButton.Size = new System.Drawing.Size(132, 30);
            this.CreateRepairButton.TabIndex = 5;
            this.CreateRepairButton.Text = "Create Repair";
            this.CreateRepairButton.UseVisualStyleBackColor = true;
            this.CreateRepairButton.Click += new System.EventHandler(this.CreateRepairButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateLabel,
            this.EmployeeNameLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 571);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1062, 25);
            this.toolStrip1.TabIndex = 13;
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
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(621, 529);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(132, 30);
            this.EditButton.TabIndex = 14;
            this.EditButton.Text = "Edit Repair";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // RepairLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 596);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DeleteRepairBtton);
            this.Controls.Add(this.CreateRepairButton);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RepairLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Repairs";
            this.Load += new System.EventHandler(this.RepairLookUp_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
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
        private System.Windows.Forms.Button DeleteRepairBtton;
        private System.Windows.Forms.Button CreateRepairButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel DateLabel;
        private System.Windows.Forms.ToolStripLabel EmployeeNameLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button EditButton;
    }
}