
namespace Omnia
{
    partial class EditRepair
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
            this.repairNotesTextBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.repairSerialTextBox = new System.Windows.Forms.TextBox();
            this.repairModelTextBox = new System.Windows.Forms.TextBox();
            this.repairDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.repairCustomerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.repairCustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.repairTagNumberTextBox = new System.Windows.Forms.TextBox();
            this.RepairIDTextBox = new System.Windows.Forms.TextBox();
            this.repairSerialLabel = new System.Windows.Forms.Label();
            this.repairModelLabel = new System.Windows.Forms.Label();
            this.repairDescriptionLabel = new System.Windows.Forms.Label();
            this.repairCustPhoneNumberLabel = new System.Windows.Forms.Label();
            this.repairCustNameLabel = new System.Windows.Forms.Label();
            this.repairTagLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // repairNotesTextBox
            // 
            this.repairNotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairNotesTextBox.Location = new System.Drawing.Point(26, 248);
            this.repairNotesTextBox.Multiline = true;
            this.repairNotesTextBox.Name = "repairNotesTextBox";
            this.repairNotesTextBox.Size = new System.Drawing.Size(952, 150);
            this.repairNotesTextBox.TabIndex = 6;
            this.repairNotesTextBox.Leave += new System.EventHandler(this.repairNotesTextBox_Leave);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(473, 220);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(74, 25);
            this.NotesLabel.TabIndex = 19;
            this.NotesLabel.Text = "Notes:";
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(26, 417);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(120, 30);
            this.SaveAndCloseButton.TabIndex = 7;
            this.SaveAndCloseButton.Text = "Save and Close";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(903, 417);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(822, 417);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 30);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // repairSerialTextBox
            // 
            this.repairSerialTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairSerialTextBox.Location = new System.Drawing.Point(709, 167);
            this.repairSerialTextBox.Name = "repairSerialTextBox";
            this.repairSerialTextBox.Size = new System.Drawing.Size(269, 31);
            this.repairSerialTextBox.TabIndex = 5;
            this.repairSerialTextBox.Leave += new System.EventHandler(this.repairSerialTextBox_Leave);
            // 
            // repairModelTextBox
            // 
            this.repairModelTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairModelTextBox.Location = new System.Drawing.Point(709, 118);
            this.repairModelTextBox.Name = "repairModelTextBox";
            this.repairModelTextBox.Size = new System.Drawing.Size(269, 31);
            this.repairModelTextBox.TabIndex = 4;
            this.repairModelTextBox.Leave += new System.EventHandler(this.repairModelTextBox_Leave);
            // 
            // repairDescriptionTextBox
            // 
            this.repairDescriptionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairDescriptionTextBox.Location = new System.Drawing.Point(709, 71);
            this.repairDescriptionTextBox.Name = "repairDescriptionTextBox";
            this.repairDescriptionTextBox.Size = new System.Drawing.Size(269, 31);
            this.repairDescriptionTextBox.TabIndex = 3;
            this.repairDescriptionTextBox.Leave += new System.EventHandler(this.repairDescriptionTextBox_Leave);
            // 
            // repairCustomerPhoneNumberTextBox
            // 
            this.repairCustomerPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairCustomerPhoneNumberTextBox.Location = new System.Drawing.Point(199, 170);
            this.repairCustomerPhoneNumberTextBox.Name = "repairCustomerPhoneNumberTextBox";
            this.repairCustomerPhoneNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.repairCustomerPhoneNumberTextBox.TabIndex = 2;
            this.repairCustomerPhoneNumberTextBox.Leave += new System.EventHandler(this.repairCustomerPhoneNumberTextBox_Leave);
            // 
            // repairCustomerNameTextBox
            // 
            this.repairCustomerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairCustomerNameTextBox.Location = new System.Drawing.Point(199, 118);
            this.repairCustomerNameTextBox.Name = "repairCustomerNameTextBox";
            this.repairCustomerNameTextBox.Size = new System.Drawing.Size(269, 31);
            this.repairCustomerNameTextBox.TabIndex = 1;
            this.repairCustomerNameTextBox.Leave += new System.EventHandler(this.repairCustomerNameTextBox_Leave);
            // 
            // repairTagNumberTextBox
            // 
            this.repairTagNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairTagNumberTextBox.Location = new System.Drawing.Point(199, 74);
            this.repairTagNumberTextBox.Name = "repairTagNumberTextBox";
            this.repairTagNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.repairTagNumberTextBox.TabIndex = 0;
            this.repairTagNumberTextBox.Leave += new System.EventHandler(this.repairTagNumberTextBox_Leave);
            // 
            // RepairIDTextBox
            // 
            this.RepairIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RepairIDTextBox.Location = new System.Drawing.Point(134, 17);
            this.RepairIDTextBox.Name = "RepairIDTextBox";
            this.RepairIDTextBox.ReadOnly = true;
            this.RepairIDTextBox.Size = new System.Drawing.Size(101, 31);
            this.RepairIDTextBox.TabIndex = 12;
            this.RepairIDTextBox.Text = "99";
            // 
            // repairSerialLabel
            // 
            this.repairSerialLabel.AutoSize = true;
            this.repairSerialLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairSerialLabel.Location = new System.Drawing.Point(630, 170);
            this.repairSerialLabel.Name = "repairSerialLabel";
            this.repairSerialLabel.Size = new System.Drawing.Size(73, 25);
            this.repairSerialLabel.TabIndex = 18;
            this.repairSerialLabel.Text = "Serial:";
            // 
            // repairModelLabel
            // 
            this.repairModelLabel.AutoSize = true;
            this.repairModelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairModelLabel.Location = new System.Drawing.Point(626, 121);
            this.repairModelLabel.Name = "repairModelLabel";
            this.repairModelLabel.Size = new System.Drawing.Size(77, 25);
            this.repairModelLabel.TabIndex = 17;
            this.repairModelLabel.Text = "Model:";
            // 
            // repairDescriptionLabel
            // 
            this.repairDescriptionLabel.AutoSize = true;
            this.repairDescriptionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairDescriptionLabel.Location = new System.Drawing.Point(577, 74);
            this.repairDescriptionLabel.Name = "repairDescriptionLabel";
            this.repairDescriptionLabel.Size = new System.Drawing.Size(126, 25);
            this.repairDescriptionLabel.TabIndex = 16;
            this.repairDescriptionLabel.Text = "Description:";
            // 
            // repairCustPhoneNumberLabel
            // 
            this.repairCustPhoneNumberLabel.AutoSize = true;
            this.repairCustPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairCustPhoneNumberLabel.Location = new System.Drawing.Point(32, 173);
            this.repairCustPhoneNumberLabel.Name = "repairCustPhoneNumberLabel";
            this.repairCustPhoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.repairCustPhoneNumberLabel.TabIndex = 15;
            this.repairCustPhoneNumberLabel.Text = "Phone Number:";
            // 
            // repairCustNameLabel
            // 
            this.repairCustNameLabel.AutoSize = true;
            this.repairCustNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairCustNameLabel.Location = new System.Drawing.Point(21, 121);
            this.repairCustNameLabel.Name = "repairCustNameLabel";
            this.repairCustNameLabel.Size = new System.Drawing.Size(172, 25);
            this.repairCustNameLabel.TabIndex = 14;
            this.repairCustNameLabel.Text = "Customer Name:";
            // 
            // repairTagLabel
            // 
            this.repairTagLabel.AutoSize = true;
            this.repairTagLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repairTagLabel.Location = new System.Drawing.Point(57, 74);
            this.repairTagLabel.Name = "repairTagLabel";
            this.repairTagLabel.Size = new System.Drawing.Size(136, 25);
            this.repairTagLabel.TabIndex = 13;
            this.repairTagLabel.Text = "Tag Number:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(21, 20);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(107, 25);
            this.IDLabel.TabIndex = 11;
            this.IDLabel.Text = "Repair ID:";
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(152, 417);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 30);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EditRepair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 464);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.repairNotesTextBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.repairSerialTextBox);
            this.Controls.Add(this.repairModelTextBox);
            this.Controls.Add(this.repairDescriptionTextBox);
            this.Controls.Add(this.repairCustomerPhoneNumberTextBox);
            this.Controls.Add(this.repairCustomerNameTextBox);
            this.Controls.Add(this.repairTagNumberTextBox);
            this.Controls.Add(this.RepairIDTextBox);
            this.Controls.Add(this.repairSerialLabel);
            this.Controls.Add(this.repairModelLabel);
            this.Controls.Add(this.repairDescriptionLabel);
            this.Controls.Add(this.repairCustPhoneNumberLabel);
            this.Controls.Add(this.repairCustNameLabel);
            this.Controls.Add(this.repairTagLabel);
            this.Controls.Add(this.IDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditRepair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Repair";
            this.Load += new System.EventHandler(this.EditRepair_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox repairNotesTextBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox repairSerialTextBox;
        private System.Windows.Forms.TextBox repairModelTextBox;
        private System.Windows.Forms.TextBox repairDescriptionTextBox;
        private System.Windows.Forms.TextBox repairCustomerPhoneNumberTextBox;
        private System.Windows.Forms.TextBox repairCustomerNameTextBox;
        private System.Windows.Forms.TextBox repairTagNumberTextBox;
        private System.Windows.Forms.TextBox RepairIDTextBox;
        private System.Windows.Forms.Label repairSerialLabel;
        private System.Windows.Forms.Label repairModelLabel;
        private System.Windows.Forms.Label repairDescriptionLabel;
        private System.Windows.Forms.Label repairCustPhoneNumberLabel;
        private System.Windows.Forms.Label repairCustNameLabel;
        private System.Windows.Forms.Label repairTagLabel;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.Button SaveButton;
    }
}