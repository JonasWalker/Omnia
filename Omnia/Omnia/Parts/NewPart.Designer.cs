
namespace Omnia
{
    partial class NewPart
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
            this.IDLabel = new System.Windows.Forms.Label();
            this.partNumberLabel = new System.Windows.Forms.Label();
            this.partDescriptionLabel = new System.Windows.Forms.Label();
            this.partQuantityLabel = new System.Windows.Forms.Label();
            this.MSRPLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.PartIDTextBox = new System.Windows.Forms.TextBox();
            this.PartNumberTextBox = new System.Windows.Forms.TextBox();
            this.PartDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PartQuantityTextBox = new System.Windows.Forms.TextBox();
            this.MSRPTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.CreateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(12, 9);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(83, 25);
            this.IDLabel.TabIndex = 10;
            this.IDLabel.Text = "Part ID:";
            // 
            // partNumberLabel
            // 
            this.partNumberLabel.AutoSize = true;
            this.partNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberLabel.Location = new System.Drawing.Point(12, 65);
            this.partNumberLabel.Name = "partNumberLabel";
            this.partNumberLabel.Size = new System.Drawing.Size(138, 25);
            this.partNumberLabel.TabIndex = 11;
            this.partNumberLabel.Text = "Part Number:";
            // 
            // partDescriptionLabel
            // 
            this.partDescriptionLabel.AutoSize = true;
            this.partDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDescriptionLabel.Location = new System.Drawing.Point(12, 120);
            this.partDescriptionLabel.Name = "partDescriptionLabel";
            this.partDescriptionLabel.Size = new System.Drawing.Size(171, 25);
            this.partDescriptionLabel.TabIndex = 12;
            this.partDescriptionLabel.Text = "Part Description:";
            // 
            // partQuantityLabel
            // 
            this.partQuantityLabel.AutoSize = true;
            this.partQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partQuantityLabel.Location = new System.Drawing.Point(12, 178);
            this.partQuantityLabel.Name = "partQuantityLabel";
            this.partQuantityLabel.Size = new System.Drawing.Size(143, 25);
            this.partQuantityLabel.TabIndex = 13;
            this.partQuantityLabel.Text = "Part Quantity:";
            // 
            // MSRPLabel
            // 
            this.MSRPLabel.AutoSize = true;
            this.MSRPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSRPLabel.Location = new System.Drawing.Point(633, 65);
            this.MSRPLabel.Name = "MSRPLabel";
            this.MSRPLabel.Size = new System.Drawing.Size(79, 25);
            this.MSRPLabel.TabIndex = 14;
            this.MSRPLabel.Text = "MSRP:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(650, 123);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(62, 25);
            this.CostLabel.TabIndex = 15;
            this.CostLabel.Text = "Cost:";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(465, 224);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(74, 25);
            this.NotesLabel.TabIndex = 16;
            this.NotesLabel.Text = "Notes:";
            // 
            // PartIDTextBox
            // 
            this.PartIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartIDTextBox.Location = new System.Drawing.Point(101, 6);
            this.PartIDTextBox.Name = "PartIDTextBox";
            this.PartIDTextBox.ReadOnly = true;
            this.PartIDTextBox.Size = new System.Drawing.Size(101, 31);
            this.PartIDTextBox.TabIndex = 9;
            this.PartIDTextBox.Text = "99";
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberTextBox.Location = new System.Drawing.Point(189, 65);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartNumberTextBox.TabIndex = 0;
            // 
            // PartDescriptionTextBox
            // 
            this.PartDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionTextBox.Location = new System.Drawing.Point(189, 114);
            this.PartDescriptionTextBox.Name = "PartDescriptionTextBox";
            this.PartDescriptionTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartDescriptionTextBox.TabIndex = 1;
            // 
            // PartQuantityTextBox
            // 
            this.PartQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartQuantityTextBox.Location = new System.Drawing.Point(189, 172);
            this.PartQuantityTextBox.Name = "PartQuantityTextBox";
            this.PartQuantityTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartQuantityTextBox.TabIndex = 2;
            this.PartQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartQuantityTextBox_KeyPress);
            this.PartQuantityTextBox.Leave += new System.EventHandler(this.PartQuantityTextBox_Leave);
            // 
            // MSRPTextBox
            // 
            this.MSRPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSRPTextBox.Location = new System.Drawing.Point(718, 62);
            this.MSRPTextBox.Name = "MSRPTextBox";
            this.MSRPTextBox.Size = new System.Drawing.Size(269, 31);
            this.MSRPTextBox.TabIndex = 3;
            this.MSRPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MSRPTextBox_KeyPress);
            this.MSRPTextBox.Leave += new System.EventHandler(this.MSRPTextBox_Leave);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.Location = new System.Drawing.Point(718, 120);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(269, 31);
            this.CostTextBox.TabIndex = 4;
            this.CostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTextBox_KeyPress);
            this.CostTextBox.Leave += new System.EventHandler(this.CostTextBox_Leave);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTextBox.Location = new System.Drawing.Point(12, 252);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(975, 138);
            this.NotesTextBox.TabIndex = 5;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(819, 408);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 30);
            this.ClearButton.TabIndex = 7;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(912, 408);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 8;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // CreateButton
            // 
            this.CreateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateButton.Location = new System.Drawing.Point(12, 408);
            this.CreateButton.Name = "CreateButton";
            this.CreateButton.Size = new System.Drawing.Size(75, 30);
            this.CreateButton.TabIndex = 6;
            this.CreateButton.Text = "Create";
            this.CreateButton.UseVisualStyleBackColor = true;
            this.CreateButton.Click += new System.EventHandler(this.CreateButton_Click);
            // 
            // NewPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 464);
            this.Controls.Add(this.CreateButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.MSRPTextBox);
            this.Controls.Add(this.PartQuantityTextBox);
            this.Controls.Add(this.PartDescriptionTextBox);
            this.Controls.Add(this.PartNumberTextBox);
            this.Controls.Add(this.PartIDTextBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.CostLabel);
            this.Controls.Add(this.MSRPLabel);
            this.Controls.Add(this.partQuantityLabel);
            this.Controls.Add(this.partDescriptionLabel);
            this.Controls.Add(this.partNumberLabel);
            this.Controls.Add(this.IDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "NewPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Part";
            this.Load += new System.EventHandler(this.NewPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Label partNumberLabel;
        private System.Windows.Forms.Label partDescriptionLabel;
        private System.Windows.Forms.Label partQuantityLabel;
        private System.Windows.Forms.Label MSRPLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox PartIDTextBox;
        private System.Windows.Forms.TextBox PartNumberTextBox;
        private System.Windows.Forms.TextBox PartDescriptionTextBox;
        private System.Windows.Forms.TextBox PartQuantityTextBox;
        private System.Windows.Forms.TextBox MSRPTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button CreateButton;
    }
}