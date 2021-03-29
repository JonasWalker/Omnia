
namespace Omnia
{
    partial class EditPart
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
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.MSRPTextBox = new System.Windows.Forms.TextBox();
            this.PartQuantityTextBox = new System.Windows.Forms.TextBox();
            this.PartDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.PartNumberTextBox = new System.Windows.Forms.TextBox();
            this.PartIDTextBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.CostLabel = new System.Windows.Forms.Label();
            this.MSRPLabel = new System.Windows.Forms.Label();
            this.partQuantityLabel = new System.Windows.Forms.Label();
            this.partDescriptionLabel = new System.Windows.Forms.Label();
            this.partNumberLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(12, 418);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(121, 30);
            this.SaveAndCloseButton.TabIndex = 6;
            this.SaveAndCloseButton.Text = "Save and Close";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(912, 418);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 9;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(819, 418);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 30);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesTextBox.Location = new System.Drawing.Point(12, 262);
            this.NotesTextBox.Multiline = true;
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(975, 138);
            this.NotesTextBox.TabIndex = 5;
            this.NotesTextBox.Leave += new System.EventHandler(this.NotesTextBox_Leave);
            // 
            // CostTextBox
            // 
            this.CostTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTextBox.Location = new System.Drawing.Point(718, 130);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.Size = new System.Drawing.Size(269, 31);
            this.CostTextBox.TabIndex = 4;
            this.CostTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CostTextBox_KeyPress);
            this.CostTextBox.Leave += new System.EventHandler(this.CostTextBox_Leave);
            // 
            // MSRPTextBox
            // 
            this.MSRPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSRPTextBox.Location = new System.Drawing.Point(718, 72);
            this.MSRPTextBox.Name = "MSRPTextBox";
            this.MSRPTextBox.Size = new System.Drawing.Size(269, 31);
            this.MSRPTextBox.TabIndex = 3;
            this.MSRPTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MSRPTextBox_KeyPress);
            this.MSRPTextBox.Leave += new System.EventHandler(this.MSRPTextBox_Leave);
            // 
            // PartQuantityTextBox
            // 
            this.PartQuantityTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartQuantityTextBox.Location = new System.Drawing.Point(189, 182);
            this.PartQuantityTextBox.Name = "PartQuantityTextBox";
            this.PartQuantityTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartQuantityTextBox.TabIndex = 2;
            this.PartQuantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PartQuantityTextBox_KeyPress);
            this.PartQuantityTextBox.Leave += new System.EventHandler(this.PartQuantityTextBox_Leave);
            // 
            // PartDescriptionTextBox
            // 
            this.PartDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartDescriptionTextBox.Location = new System.Drawing.Point(189, 124);
            this.PartDescriptionTextBox.Name = "PartDescriptionTextBox";
            this.PartDescriptionTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartDescriptionTextBox.TabIndex = 1;
            this.PartDescriptionTextBox.Leave += new System.EventHandler(this.PartDescriptionTextBox_Leave);
            // 
            // PartNumberTextBox
            // 
            this.PartNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartNumberTextBox.Location = new System.Drawing.Point(189, 75);
            this.PartNumberTextBox.Name = "PartNumberTextBox";
            this.PartNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.PartNumberTextBox.TabIndex = 0;
            this.PartNumberTextBox.Leave += new System.EventHandler(this.PartNumberTextBox_Leave);
            // 
            // PartIDTextBox
            // 
            this.PartIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartIDTextBox.Location = new System.Drawing.Point(101, 16);
            this.PartIDTextBox.Name = "PartIDTextBox";
            this.PartIDTextBox.ReadOnly = true;
            this.PartIDTextBox.Size = new System.Drawing.Size(101, 31);
            this.PartIDTextBox.TabIndex = 11;
            this.PartIDTextBox.Text = "99";
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(465, 234);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(74, 25);
            this.NotesLabel.TabIndex = 15;
            this.NotesLabel.Text = "Notes:";
            // 
            // CostLabel
            // 
            this.CostLabel.AutoSize = true;
            this.CostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostLabel.Location = new System.Drawing.Point(650, 133);
            this.CostLabel.Name = "CostLabel";
            this.CostLabel.Size = new System.Drawing.Size(62, 25);
            this.CostLabel.TabIndex = 17;
            this.CostLabel.Text = "Cost:";
            // 
            // MSRPLabel
            // 
            this.MSRPLabel.AutoSize = true;
            this.MSRPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MSRPLabel.Location = new System.Drawing.Point(633, 75);
            this.MSRPLabel.Name = "MSRPLabel";
            this.MSRPLabel.Size = new System.Drawing.Size(79, 25);
            this.MSRPLabel.TabIndex = 16;
            this.MSRPLabel.Text = "MSRP:";
            // 
            // partQuantityLabel
            // 
            this.partQuantityLabel.AutoSize = true;
            this.partQuantityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partQuantityLabel.Location = new System.Drawing.Point(12, 188);
            this.partQuantityLabel.Name = "partQuantityLabel";
            this.partQuantityLabel.Size = new System.Drawing.Size(143, 25);
            this.partQuantityLabel.TabIndex = 14;
            this.partQuantityLabel.Text = "Part Quantity:";
            // 
            // partDescriptionLabel
            // 
            this.partDescriptionLabel.AutoSize = true;
            this.partDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partDescriptionLabel.Location = new System.Drawing.Point(12, 130);
            this.partDescriptionLabel.Name = "partDescriptionLabel";
            this.partDescriptionLabel.Size = new System.Drawing.Size(171, 25);
            this.partDescriptionLabel.TabIndex = 13;
            this.partDescriptionLabel.Text = "Part Description:";
            // 
            // partNumberLabel
            // 
            this.partNumberLabel.AutoSize = true;
            this.partNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberLabel.Location = new System.Drawing.Point(12, 75);
            this.partNumberLabel.Name = "partNumberLabel";
            this.partNumberLabel.Size = new System.Drawing.Size(138, 25);
            this.partNumberLabel.TabIndex = 12;
            this.partNumberLabel.Text = "Part Number:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(12, 19);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(83, 25);
            this.IDLabel.TabIndex = 10;
            this.IDLabel.Text = "Part ID:";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(139, 418);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 30);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 464);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveAndCloseButton);
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
            this.Name = "EditPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Part";
            this.Load += new System.EventHandler(this.EditPart_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox MSRPTextBox;
        private System.Windows.Forms.TextBox PartQuantityTextBox;
        private System.Windows.Forms.TextBox PartDescriptionTextBox;
        private System.Windows.Forms.TextBox PartNumberTextBox;
        private System.Windows.Forms.TextBox PartIDTextBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label CostLabel;
        private System.Windows.Forms.Label MSRPLabel;
        private System.Windows.Forms.Label partQuantityLabel;
        private System.Windows.Forms.Label partDescriptionLabel;
        private System.Windows.Forms.Label partNumberLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}