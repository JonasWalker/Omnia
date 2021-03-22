
namespace Omnia
{
    partial class Timesheets
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.DateLabel = new System.Windows.Forms.ToolStripLabel();
            this.NameLabel = new System.Windows.Forms.ToolStripLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ClearListButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SaveAndCloseButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SundayHoursTextBox = new System.Windows.Forms.TextBox();
            this.SundayLabel = new System.Windows.Forms.Label();
            this.MondayHoursTextBox = new System.Windows.Forms.TextBox();
            this.MondayLabel = new System.Windows.Forms.Label();
            this.TuesdayHoursTextBox = new System.Windows.Forms.TextBox();
            this.TuesdayLabel = new System.Windows.Forms.Label();
            this.WednesdayHoursTextBox = new System.Windows.Forms.TextBox();
            this.WednesdayLabel = new System.Windows.Forms.Label();
            this.ThrusdayHoursTextBox = new System.Windows.Forms.TextBox();
            this.ThrusdayLabel = new System.Windows.Forms.Label();
            this.FridayHoursTextBox = new System.Windows.Forms.TextBox();
            this.FridayLabel = new System.Windows.Forms.Label();
            this.SaturdayHoursTextBox = new System.Windows.Forms.TextBox();
            this.SaturdayLabel = new System.Windows.Forms.Label();
            this.TotalHoursTextBox = new System.Windows.Forms.TextBox();
            this.TotalHoursLabel = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DateLabel,
            this.NameLabel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 538);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(398, 25);
            this.toolStrip1.TabIndex = 22;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // DateLabel
            // 
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(31, 22);
            this.DateLabel.Text = "Date";
            // 
            // NameLabel
            // 
            this.NameLabel.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(39, 22);
            this.NameLabel.Text = "Name";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // ClearListButton
            // 
            this.ClearListButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearListButton.Location = new System.Drawing.Point(221, 495);
            this.ClearListButton.Name = "ClearListButton";
            this.ClearListButton.Size = new System.Drawing.Size(75, 30);
            this.ClearListButton.TabIndex = 38;
            this.ClearListButton.Text = "Clear";
            this.ClearListButton.UseVisualStyleBackColor = true;
            this.ClearListButton.Click += new System.EventHandler(this.ClearListButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(302, 495);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 30);
            this.BackButton.TabIndex = 39;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            // 
            // SaveAndCloseButton
            // 
            this.SaveAndCloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveAndCloseButton.Location = new System.Drawing.Point(12, 495);
            this.SaveAndCloseButton.Name = "SaveAndCloseButton";
            this.SaveAndCloseButton.Size = new System.Drawing.Size(124, 30);
            this.SaveAndCloseButton.TabIndex = 40;
            this.SaveAndCloseButton.Text = "Save and Close";
            this.SaveAndCloseButton.UseVisualStyleBackColor = true;
            this.SaveAndCloseButton.Click += new System.EventHandler(this.SaveAndCloseButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Location = new System.Drawing.Point(142, 495);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 30);
            this.SaveButton.TabIndex = 41;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SundayHoursTextBox
            // 
            this.SundayHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SundayHoursTextBox.Location = new System.Drawing.Point(217, 57);
            this.SundayHoursTextBox.Name = "SundayHoursTextBox";
            this.SundayHoursTextBox.Size = new System.Drawing.Size(60, 31);
            this.SundayHoursTextBox.TabIndex = 45;
            this.SundayHoursTextBox.Text = "0.0";
            this.SundayHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SundayHoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SundayHoursTextBox_KeyPress);
            this.SundayHoursTextBox.Leave += new System.EventHandler(this.TotalItemsTextBox_Leave);
            // 
            // SundayLabel
            // 
            this.SundayLabel.AutoSize = true;
            this.SundayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SundayLabel.Location = new System.Drawing.Point(120, 60);
            this.SundayLabel.Name = "SundayLabel";
            this.SundayLabel.Size = new System.Drawing.Size(91, 25);
            this.SundayLabel.TabIndex = 44;
            this.SundayLabel.Text = "Sunday:";
            // 
            // MondayHoursTextBox
            // 
            this.MondayHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayHoursTextBox.Location = new System.Drawing.Point(217, 100);
            this.MondayHoursTextBox.Name = "MondayHoursTextBox";
            this.MondayHoursTextBox.Size = new System.Drawing.Size(60, 31);
            this.MondayHoursTextBox.TabIndex = 47;
            this.MondayHoursTextBox.Text = "0.0";
            this.MondayHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.MondayHoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MondayHoursTextBox_KeyPress);
            this.MondayHoursTextBox.Leave += new System.EventHandler(this.MondayHoursTextBox_Leave);
            // 
            // MondayLabel
            // 
            this.MondayLabel.AutoSize = true;
            this.MondayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MondayLabel.Location = new System.Drawing.Point(114, 103);
            this.MondayLabel.Name = "MondayLabel";
            this.MondayLabel.Size = new System.Drawing.Size(95, 25);
            this.MondayLabel.TabIndex = 46;
            this.MondayLabel.Text = "Monday:";
            // 
            // TuesdayHoursTextBox
            // 
            this.TuesdayHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuesdayHoursTextBox.Location = new System.Drawing.Point(217, 141);
            this.TuesdayHoursTextBox.Name = "TuesdayHoursTextBox";
            this.TuesdayHoursTextBox.Size = new System.Drawing.Size(60, 31);
            this.TuesdayHoursTextBox.TabIndex = 49;
            this.TuesdayHoursTextBox.Text = "0.0";
            this.TuesdayHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TuesdayHoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TuesdayHoursTextBox_KeyPress);
            this.TuesdayHoursTextBox.Leave += new System.EventHandler(this.TuesdayHoursTextBox_Leave);
            // 
            // TuesdayLabel
            // 
            this.TuesdayLabel.AutoSize = true;
            this.TuesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TuesdayLabel.Location = new System.Drawing.Point(110, 144);
            this.TuesdayLabel.Name = "TuesdayLabel";
            this.TuesdayLabel.Size = new System.Drawing.Size(101, 25);
            this.TuesdayLabel.TabIndex = 48;
            this.TuesdayLabel.Text = "Tuesday:";
            // 
            // WednesdayHoursTextBox
            // 
            this.WednesdayHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WednesdayHoursTextBox.Location = new System.Drawing.Point(217, 182);
            this.WednesdayHoursTextBox.Name = "WednesdayHoursTextBox";
            this.WednesdayHoursTextBox.Size = new System.Drawing.Size(60, 31);
            this.WednesdayHoursTextBox.TabIndex = 51;
            this.WednesdayHoursTextBox.Text = "0.0";
            this.WednesdayHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.WednesdayHoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WednesdayHoursTextBox_KeyPress);
            this.WednesdayHoursTextBox.Leave += new System.EventHandler(this.WednesdayHoursTextBox_Leave);
            // 
            // WednesdayLabel
            // 
            this.WednesdayLabel.AutoSize = true;
            this.WednesdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WednesdayLabel.Location = new System.Drawing.Point(79, 185);
            this.WednesdayLabel.Name = "WednesdayLabel";
            this.WednesdayLabel.Size = new System.Drawing.Size(132, 25);
            this.WednesdayLabel.TabIndex = 50;
            this.WednesdayLabel.Text = "Wednesday:";
            // 
            // ThrusdayHoursTextBox
            // 
            this.ThrusdayHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThrusdayHoursTextBox.Location = new System.Drawing.Point(217, 228);
            this.ThrusdayHoursTextBox.Name = "ThrusdayHoursTextBox";
            this.ThrusdayHoursTextBox.Size = new System.Drawing.Size(60, 31);
            this.ThrusdayHoursTextBox.TabIndex = 53;
            this.ThrusdayHoursTextBox.Text = "0.0";
            this.ThrusdayHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.ThrusdayHoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ThrusdayHoursTextBox_KeyPress);
            this.ThrusdayHoursTextBox.Leave += new System.EventHandler(this.ThrusdayHoursTextBox_Leave);
            // 
            // ThrusdayLabel
            // 
            this.ThrusdayLabel.AutoSize = true;
            this.ThrusdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThrusdayLabel.Location = new System.Drawing.Point(103, 231);
            this.ThrusdayLabel.Name = "ThrusdayLabel";
            this.ThrusdayLabel.Size = new System.Drawing.Size(108, 25);
            this.ThrusdayLabel.TabIndex = 52;
            this.ThrusdayLabel.Text = "Thrusday:";
            // 
            // FridayHoursTextBox
            // 
            this.FridayHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayHoursTextBox.Location = new System.Drawing.Point(217, 271);
            this.FridayHoursTextBox.Name = "FridayHoursTextBox";
            this.FridayHoursTextBox.Size = new System.Drawing.Size(60, 31);
            this.FridayHoursTextBox.TabIndex = 55;
            this.FridayHoursTextBox.Text = "0.0";
            this.FridayHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.FridayHoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FridayHoursTextBox_KeyPress);
            this.FridayHoursTextBox.Leave += new System.EventHandler(this.FridayHoursTextBox_Leave);
            // 
            // FridayLabel
            // 
            this.FridayLabel.AutoSize = true;
            this.FridayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FridayLabel.Location = new System.Drawing.Point(133, 271);
            this.FridayLabel.Name = "FridayLabel";
            this.FridayLabel.Size = new System.Drawing.Size(78, 25);
            this.FridayLabel.TabIndex = 54;
            this.FridayLabel.Text = "Friday:";
            // 
            // SaturdayHoursTextBox
            // 
            this.SaturdayHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaturdayHoursTextBox.Location = new System.Drawing.Point(217, 313);
            this.SaturdayHoursTextBox.Name = "SaturdayHoursTextBox";
            this.SaturdayHoursTextBox.Size = new System.Drawing.Size(60, 31);
            this.SaturdayHoursTextBox.TabIndex = 57;
            this.SaturdayHoursTextBox.Text = "0.0";
            this.SaturdayHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.SaturdayHoursTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SaturdayHoursTextBox_KeyPress);
            this.SaturdayHoursTextBox.Leave += new System.EventHandler(this.SaturdayHoursTextBox_Leave);
            // 
            // SaturdayLabel
            // 
            this.SaturdayLabel.AutoSize = true;
            this.SaturdayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaturdayLabel.Location = new System.Drawing.Point(105, 313);
            this.SaturdayLabel.Name = "SaturdayLabel";
            this.SaturdayLabel.Size = new System.Drawing.Size(104, 25);
            this.SaturdayLabel.TabIndex = 56;
            this.SaturdayLabel.Text = "Saturday:";
            // 
            // TotalHoursTextBox
            // 
            this.TotalHoursTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHoursTextBox.Location = new System.Drawing.Point(217, 385);
            this.TotalHoursTextBox.Name = "TotalHoursTextBox";
            this.TotalHoursTextBox.ReadOnly = true;
            this.TotalHoursTextBox.Size = new System.Drawing.Size(60, 31);
            this.TotalHoursTextBox.TabIndex = 59;
            this.TotalHoursTextBox.Text = "0.0";
            this.TotalHoursTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // TotalHoursLabel
            // 
            this.TotalHoursLabel.AutoSize = true;
            this.TotalHoursLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalHoursLabel.Location = new System.Drawing.Point(94, 388);
            this.TotalHoursLabel.Name = "TotalHoursLabel";
            this.TotalHoursLabel.Size = new System.Drawing.Size(129, 25);
            this.TotalHoursLabel.TabIndex = 58;
            this.TotalHoursLabel.Text = "Total Hours:";
            // 
            // Timesheets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 563);
            this.Controls.Add(this.TotalHoursTextBox);
            this.Controls.Add(this.TotalHoursLabel);
            this.Controls.Add(this.SaturdayHoursTextBox);
            this.Controls.Add(this.SaturdayLabel);
            this.Controls.Add(this.FridayHoursTextBox);
            this.Controls.Add(this.FridayLabel);
            this.Controls.Add(this.ThrusdayHoursTextBox);
            this.Controls.Add(this.ThrusdayLabel);
            this.Controls.Add(this.WednesdayHoursTextBox);
            this.Controls.Add(this.WednesdayLabel);
            this.Controls.Add(this.TuesdayHoursTextBox);
            this.Controls.Add(this.TuesdayLabel);
            this.Controls.Add(this.MondayHoursTextBox);
            this.Controls.Add(this.MondayLabel);
            this.Controls.Add(this.SundayHoursTextBox);
            this.Controls.Add(this.SundayLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.SaveAndCloseButton);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.ClearListButton);
            this.Controls.Add(this.toolStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Timesheets";
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timesheets";
            this.Load += new System.EventHandler(this.Timesheets_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel DateLabel;
        private System.Windows.Forms.ToolStripLabel NameLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button ClearListButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button SaveAndCloseButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.TextBox SundayHoursTextBox;
        private System.Windows.Forms.Label SundayLabel;
        private System.Windows.Forms.TextBox MondayHoursTextBox;
        private System.Windows.Forms.Label MondayLabel;
        private System.Windows.Forms.TextBox TuesdayHoursTextBox;
        private System.Windows.Forms.Label TuesdayLabel;
        private System.Windows.Forms.TextBox WednesdayHoursTextBox;
        private System.Windows.Forms.Label WednesdayLabel;
        private System.Windows.Forms.TextBox ThrusdayHoursTextBox;
        private System.Windows.Forms.Label ThrusdayLabel;
        private System.Windows.Forms.TextBox FridayHoursTextBox;
        private System.Windows.Forms.Label FridayLabel;
        private System.Windows.Forms.TextBox SaturdayHoursTextBox;
        private System.Windows.Forms.Label SaturdayLabel;
        private System.Windows.Forms.TextBox TotalHoursTextBox;
        private System.Windows.Forms.Label TotalHoursLabel;
    }
}