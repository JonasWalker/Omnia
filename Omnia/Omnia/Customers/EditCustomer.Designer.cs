
namespace Omnia
{
    partial class EditCustomer
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
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.customerNotesTextBox = new System.Windows.Forms.TextBox();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.customerStateTextBox = new System.Windows.Forms.TextBox();
            this.customerZIPTextBox = new System.Windows.Forms.TextBox();
            this.customerAddressTextBox = new System.Windows.Forms.TextBox();
            this.customerAltPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerPhoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.customerNameTextBox = new System.Windows.Forms.TextBox();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.customerStateLabel = new System.Windows.Forms.Label();
            this.customerZIPLabel = new System.Windows.Forms.Label();
            this.customerAddressLabel = new System.Windows.Forms.Label();
            this.customerAltPhoneNumberLabel = new System.Windows.Forms.Label();
            this.customerPhoneNumberLabel = new System.Windows.Forms.Label();
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.IDLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(139, 418);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 30);
            this.SaveButton.TabIndex = 8;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(12, 418);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(121, 30);
            this.SaveAndCloseButton.TabIndex = 7;
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
            this.BackButton.TabIndex = 10;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // ClearButton
            // 
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.Location = new System.Drawing.Point(819, 418);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 30);
            this.ClearButton.TabIndex = 9;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // customerNotesTextBox
            // 
            this.customerNotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNotesTextBox.Location = new System.Drawing.Point(12, 269);
            this.customerNotesTextBox.Multiline = true;
            this.customerNotesTextBox.Name = "customerNotesTextBox";
            this.customerNotesTextBox.Size = new System.Drawing.Size(975, 123);
            this.customerNotesTextBox.TabIndex = 6;
            this.customerNotesTextBox.Leave += new System.EventHandler(this.customerNotesTextBox_Leave);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NotesLabel.Location = new System.Drawing.Point(457, 241);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(74, 25);
            this.NotesLabel.TabIndex = 19;
            this.NotesLabel.Text = "Notes:";
            // 
            // customerStateTextBox
            // 
            this.customerStateTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStateTextBox.Location = new System.Drawing.Point(718, 189);
            this.customerStateTextBox.Name = "customerStateTextBox";
            this.customerStateTextBox.Size = new System.Drawing.Size(269, 31);
            this.customerStateTextBox.TabIndex = 5;
            this.customerStateTextBox.Leave += new System.EventHandler(this.customerStateTextBox_Leave);
            // 
            // customerZIPTextBox
            // 
            this.customerZIPTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerZIPTextBox.Location = new System.Drawing.Point(718, 122);
            this.customerZIPTextBox.Name = "customerZIPTextBox";
            this.customerZIPTextBox.Size = new System.Drawing.Size(269, 31);
            this.customerZIPTextBox.TabIndex = 4;
            this.customerZIPTextBox.Leave += new System.EventHandler(this.customerZIPTextBox_Leave);
            // 
            // customerAddressTextBox
            // 
            this.customerAddressTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressTextBox.Location = new System.Drawing.Point(718, 59);
            this.customerAddressTextBox.Name = "customerAddressTextBox";
            this.customerAddressTextBox.Size = new System.Drawing.Size(269, 31);
            this.customerAddressTextBox.TabIndex = 3;
            this.customerAddressTextBox.Leave += new System.EventHandler(this.customerAddressTextBox_Leave);
            // 
            // customerAltPhoneNumberTextBox
            // 
            this.customerAltPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAltPhoneNumberTextBox.Location = new System.Drawing.Point(215, 189);
            this.customerAltPhoneNumberTextBox.Name = "customerAltPhoneNumberTextBox";
            this.customerAltPhoneNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.customerAltPhoneNumberTextBox.TabIndex = 2;
            this.customerAltPhoneNumberTextBox.Leave += new System.EventHandler(this.customerAltPhoneNumberTextBox_Leave);
            // 
            // customerPhoneNumberTextBox
            // 
            this.customerPhoneNumberTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneNumberTextBox.Location = new System.Drawing.Point(215, 122);
            this.customerPhoneNumberTextBox.Name = "customerPhoneNumberTextBox";
            this.customerPhoneNumberTextBox.Size = new System.Drawing.Size(269, 31);
            this.customerPhoneNumberTextBox.TabIndex = 1;
            this.customerPhoneNumberTextBox.Leave += new System.EventHandler(this.customerPhoneNumberTextBox_Leave);
            // 
            // customerNameTextBox
            // 
            this.customerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameTextBox.Location = new System.Drawing.Point(215, 62);
            this.customerNameTextBox.Name = "customerNameTextBox";
            this.customerNameTextBox.Size = new System.Drawing.Size(269, 31);
            this.customerNameTextBox.TabIndex = 0;
            this.customerNameTextBox.Leave += new System.EventHandler(this.customerNameTextBox_Leave);
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerIDTextBox.Location = new System.Drawing.Point(159, 9);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.ReadOnly = true;
            this.CustomerIDTextBox.Size = new System.Drawing.Size(101, 31);
            this.CustomerIDTextBox.TabIndex = 12;
            this.CustomerIDTextBox.Text = "99";
            // 
            // customerStateLabel
            // 
            this.customerStateLabel.AutoSize = true;
            this.customerStateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerStateLabel.Location = new System.Drawing.Point(644, 192);
            this.customerStateLabel.Name = "customerStateLabel";
            this.customerStateLabel.Size = new System.Drawing.Size(68, 25);
            this.customerStateLabel.TabIndex = 18;
            this.customerStateLabel.Text = "State:";
            // 
            // customerZIPLabel
            // 
            this.customerZIPLabel.AutoSize = true;
            this.customerZIPLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerZIPLabel.Location = new System.Drawing.Point(605, 128);
            this.customerZIPLabel.Name = "customerZIPLabel";
            this.customerZIPLabel.Size = new System.Drawing.Size(107, 25);
            this.customerZIPLabel.TabIndex = 17;
            this.customerZIPLabel.Text = "ZIP Code:";
            // 
            // customerAddressLabel
            // 
            this.customerAddressLabel.AutoSize = true;
            this.customerAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAddressLabel.Location = new System.Drawing.Point(615, 62);
            this.customerAddressLabel.Name = "customerAddressLabel";
            this.customerAddressLabel.Size = new System.Drawing.Size(97, 25);
            this.customerAddressLabel.TabIndex = 16;
            this.customerAddressLabel.Text = "Address:";
            // 
            // customerAltPhoneNumberLabel
            // 
            this.customerAltPhoneNumberLabel.AutoSize = true;
            this.customerAltPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAltPhoneNumberLabel.Location = new System.Drawing.Point(14, 192);
            this.customerAltPhoneNumberLabel.Name = "customerAltPhoneNumberLabel";
            this.customerAltPhoneNumberLabel.Size = new System.Drawing.Size(192, 25);
            this.customerAltPhoneNumberLabel.TabIndex = 15;
            this.customerAltPhoneNumberLabel.Text = "Alt Phone Number:";
            // 
            // customerPhoneNumberLabel
            // 
            this.customerPhoneNumberLabel.AutoSize = true;
            this.customerPhoneNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerPhoneNumberLabel.Location = new System.Drawing.Point(45, 128);
            this.customerPhoneNumberLabel.Name = "customerPhoneNumberLabel";
            this.customerPhoneNumberLabel.Size = new System.Drawing.Size(161, 25);
            this.customerPhoneNumberLabel.TabIndex = 14;
            this.customerPhoneNumberLabel.Text = "Phone Number:";
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerNameLabel.Location = new System.Drawing.Point(132, 62);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(74, 25);
            this.customerNameLabel.TabIndex = 13;
            this.customerNameLabel.Text = "Name:";
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDLabel.Location = new System.Drawing.Point(17, 12);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(136, 25);
            this.IDLabel.TabIndex = 11;
            this.IDLabel.Text = "Customer ID:";
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(999, 464);
            this.Controls.Add(this.customerNotesTextBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.customerStateTextBox);
            this.Controls.Add(this.customerZIPTextBox);
            this.Controls.Add(this.customerAddressTextBox);
            this.Controls.Add(this.customerAltPhoneNumberTextBox);
            this.Controls.Add(this.customerPhoneNumberTextBox);
            this.Controls.Add(this.customerNameTextBox);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.customerStateLabel);
            this.Controls.Add(this.customerZIPLabel);
            this.Controls.Add(this.customerAddressLabel);
            this.Controls.Add(this.customerAltPhoneNumberLabel);
            this.Controls.Add(this.customerPhoneNumberLabel);
            this.Controls.Add(this.customerNameLabel);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edit Customer";
            this.Load += new System.EventHandler(this.EditCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.TextBox customerNotesTextBox;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.TextBox customerStateTextBox;
        private System.Windows.Forms.TextBox customerZIPTextBox;
        private System.Windows.Forms.TextBox customerAddressTextBox;
        private System.Windows.Forms.TextBox customerAltPhoneNumberTextBox;
        private System.Windows.Forms.TextBox customerPhoneNumberTextBox;
        private System.Windows.Forms.TextBox customerNameTextBox;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.Label customerStateLabel;
        private System.Windows.Forms.Label customerZIPLabel;
        private System.Windows.Forms.Label customerAddressLabel;
        private System.Windows.Forms.Label customerAltPhoneNumberLabel;
        private System.Windows.Forms.Label customerPhoneNumberLabel;
        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.Label IDLabel;
    }
}