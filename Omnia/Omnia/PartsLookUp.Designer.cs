
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
            this.partDescriptionBox = new System.Windows.Forms.TextBox();
            this.partNumberBox = new System.Windows.Forms.TextBox();
            this.PartDescription = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
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
            this.SuspendLayout();
            // 
            // partDescriptionBox
            // 
            this.partDescriptionBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDescriptionBox.Location = new System.Drawing.Point(591, 12);
            this.partDescriptionBox.Name = "partDescriptionBox";
            this.partDescriptionBox.Size = new System.Drawing.Size(327, 31);
            this.partDescriptionBox.TabIndex = 17;
            // 
            // partNumberBox
            // 
            this.partNumberBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberBox.Location = new System.Drawing.Point(149, 13);
            this.partNumberBox.Name = "partNumberBox";
            this.partNumberBox.Size = new System.Drawing.Size(269, 31);
            this.partNumberBox.TabIndex = 16;
            // 
            // PartDescription
            // 
            this.PartDescription.AutoSize = true;
            this.PartDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescription.Location = new System.Drawing.Point(422, 15);
            this.PartDescription.Name = "PartDescription";
            this.PartDescription.Size = new System.Drawing.Size(171, 25);
            this.PartDescription.TabIndex = 14;
            this.PartDescription.Text = "Part Description:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.Location = new System.Drawing.Point(17, 16);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(138, 25);
            this.NameLabel.TabIndex = 13;
            this.NameLabel.Text = "Part Number:";
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
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(22, 56);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(993, 400);
            this.listView1.TabIndex = 19;
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
            // AllParts
            // 
            this.AllParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AllParts.Location = new System.Drawing.Point(22, 480);
            this.AllParts.Name = "AllParts";
            this.AllParts.Size = new System.Drawing.Size(75, 30);
            this.AllParts.TabIndex = 20;
            this.AllParts.Text = "All Parts";
            this.AllParts.UseVisualStyleBackColor = true;
            this.AllParts.Click += new System.EventHandler(this.AllParts_Click);
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(940, 480);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 21;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(859, 480);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(75, 30);
            this.Clear.TabIndex = 22;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Search
            // 
            this.Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search.Location = new System.Drawing.Point(940, 13);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(75, 30);
            this.Search.TabIndex = 23;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // PartsLookUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 522);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.AllParts);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.partDescriptionBox);
            this.Controls.Add(this.partNumberBox);
            this.Controls.Add(this.PartDescription);
            this.Controls.Add(this.NameLabel);
            this.Name = "PartsLookUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parts";
            this.Load += new System.EventHandler(this.PartsLookUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox partDescriptionBox;
        private System.Windows.Forms.TextBox partNumberBox;
        private System.Windows.Forms.Label PartDescription;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.ListView listView1;
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
    }
}