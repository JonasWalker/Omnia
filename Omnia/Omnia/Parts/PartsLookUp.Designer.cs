
namespace Omnia
{
    partial class PartsLookUp
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
            this.PartDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PartNumberTextBox = new System.Windows.Forms.TextBox();
            this.PartDescription = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.PartsListView = new System.Windows.Forms.ListView();
            this.idparts = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNumber = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partDescription1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partyQty = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partMSRP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partCost = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.partNote = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AllParts = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.Clear = new System.Windows.Forms.Button();
            this.Search = new System.Windows.Forms.Button();
            this.CreatePartButton = new System.Windows.Forms.Button();
            this.DeletePartButton = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DateLabel = new System.Windows.Forms.ToolStripLabel();
            this.EmployeeNameLabel = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.EditButton = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PartDescriptionTextBox
            // 
            this.PartDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionTextBox.Location = new System.Drawing.Point(591, 12);
            this.PartDescriptionTextBox.Name = "PartDescriptionTextBox";
            this.PartDescriptionTextBox.Size = new System.Drawing.Size(327, 31);
            this.PartDescriptionTextBox.TabIndex = 1;
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberTextBox.Location = new System.Drawing.Point(149, 13);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartNumberTextBox.TabIndex = 0;
            // 
            // PartDescription
            // 
            this.PartDescription.AutoSize = true;
            this.PartDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescription.Location = new System.Drawing.Point(422, 15);
            this.PartDescription.Name = "PartDescription";
            this.PartDescription.Size = new System.Drawing.Size(171, 25);
            this.PartDescription.TabIndex = 10;
            this.PartDescription.Text = "Part Description:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(17, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(138, 25);
            this.NameLabel.TabIndex = 9;
            this.NameLabel.Text = "Part Number:";
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
            this.PartsListView.Location = new System.Drawing.Point(22, 56);
            this.PartsListView.Name = "PartsListView";
            this.PartsListView.Size = new System.Drawing.Size(1022, 393);
            this.PartsListView.TabIndex = 8;
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
            // AllParts
            // 
            this.AllParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllParts.Location = new System.Drawing.Point(22, 455);
            this.AllParts.Name = "AllParts";
            this.AllParts.Size = new System.Drawing.Size(75, 30);
            this.AllParts.TabIndex = 3;
            this.AllParts.Text = "All Parts";
            this.AllParts.UseVisualStyleBackColor = true;
            this.AllParts.Click += new System.EventHandler(this.AllParts_Click);
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(969, 455);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 7;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(888, 455);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 30);
            this.Clear.TabIndex = 6;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(969, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 30);
            this.Search.TabIndex = 2;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // CreatePartButton
            // 
            this.CreatePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreatePartButton.Location = new System.Drawing.Point(564, 455);
            this.CreatePartButton.Name = "CreatePartButton";
            this.CreatePartButton.Size = new System.Drawing.Size(102, 30);
            this.CreatePartButton.TabIndex = 4;
            this.CreatePartButton.Text = "Create Part";
            this.CreatePartButton.UseVisualStyleBackColor = true;
            this.CreatePartButton.Click += new System.EventHandler(this.CreatePartButton_Click);
            // 
            // DeletePartButton
            // 
            this.DeletePartButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeletePartButton.Location = new System.Drawing.Point(780, 455);
            this.DeletePartButton.Name = "DeletePartButton";
            this.DeletePartButton.Size = new System.Drawing.Size(102, 30);
            this.DeletePartButton.TabIndex = 5;
            this.DeletePartButton.Text = "Delete Part";
            this.DeletePartButton.UseVisualStyleBackColor = true;
            this.DeletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateLabel,
            this.EmployeeNameLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 497);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1056, 25);
            this.toolStrip1.TabIndex = 11;
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
            this.EditButton.Location = new System.Drawing.Point(672, 455);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(102, 30);
            this.EditButton.TabIndex = 12;
            this.EditButton.Text = "Edit Part";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // PartsLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1056, 522);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.DeletePartButton);
            this.Controls.Add(this.CreatePartButton);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AllParts);
            this.Controls.Add(this.PartsListView);
            this.Controls.Add(this.PartDescriptionTextBox);
            this.Controls.Add(this.PartNumberTextBox);
            this.Controls.Add(this.PartDescription);
            this.Controls.Add(this.NameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PartsLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.PartsLookUp_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PartDescriptionTextBox;
        private System.Windows.Forms.TextBox PartNumberTextBox;
        private System.Windows.Forms.Label PartDescription;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListView PartsListView;
        private System.Windows.Forms.ColumnHeader idparts;
        private System.Windows.Forms.ColumnHeader partNumber;
        private System.Windows.Forms.ColumnHeader partDescription1;
        private System.Windows.Forms.ColumnHeader partyQty;
        private System.Windows.Forms.ColumnHeader partMSRP;
        private System.Windows.Forms.ColumnHeader partCost;
        private System.Windows.Forms.ColumnHeader partNote;
        private System.Windows.Forms.Button AllParts;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.Button CreatePartButton;
        private System.Windows.Forms.Button DeletePartButton;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel DateLabel;
        private System.Windows.Forms.ToolStripLabel EmployeeNameLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button EditButton;
    }
}