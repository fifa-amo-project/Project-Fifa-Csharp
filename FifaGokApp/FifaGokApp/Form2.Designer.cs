namespace FifaGokApp
{
    partial class BetMenuForm
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
            this.MatchComboBox = new System.Windows.Forms.ComboBox();
            this.historyListBox = new System.Windows.Forms.ListBox();
            this.scoreTeam1TextBox = new System.Windows.Forms.TextBox();
            this.scoreTeam2TextBox = new System.Windows.Forms.TextBox();
            this.betButton = new System.Windows.Forms.Button();
            this.creditNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.teamOneRadioButton = new System.Windows.Forms.RadioButton();
            this.teamTwoRadioButton = new System.Windows.Forms.RadioButton();
            this.creditLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.creditNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatchComboBox
            // 
            this.MatchComboBox.FormattingEnabled = true;
            this.MatchComboBox.Location = new System.Drawing.Point(42, 251);
            this.MatchComboBox.Name = "MatchComboBox";
            this.MatchComboBox.Size = new System.Drawing.Size(169, 21);
            this.MatchComboBox.TabIndex = 0;
            this.MatchComboBox.SelectedIndexChanged += new System.EventHandler(this.MatchComboBox_SelectedIndexChanged);
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.Location = new System.Drawing.Point(12, 12);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(348, 147);
            this.historyListBox.TabIndex = 1;
            // 
            // scoreTeam1TextBox
            // 
            this.scoreTeam1TextBox.Location = new System.Drawing.Point(42, 363);
            this.scoreTeam1TextBox.Name = "scoreTeam1TextBox";
            this.scoreTeam1TextBox.Size = new System.Drawing.Size(59, 20);
            this.scoreTeam1TextBox.TabIndex = 2;
            // 
            // scoreTeam2TextBox
            // 
            this.scoreTeam2TextBox.Location = new System.Drawing.Point(140, 363);
            this.scoreTeam2TextBox.Name = "scoreTeam2TextBox";
            this.scoreTeam2TextBox.Size = new System.Drawing.Size(60, 20);
            this.scoreTeam2TextBox.TabIndex = 3;
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(80, 415);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(75, 23);
            this.betButton.TabIndex = 4;
            this.betButton.Text = "zet in ";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // creditNumericUpDown
            // 
            this.creditNumericUpDown.Location = new System.Drawing.Point(96, 389);
            this.creditNumericUpDown.Name = "creditNumericUpDown";
            this.creditNumericUpDown.Size = new System.Drawing.Size(59, 20);
            this.creditNumericUpDown.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teamTwoRadioButton);
            this.groupBox1.Controls.Add(this.teamOneRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(42, 295);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(185, 49);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // teamOneRadioButton
            // 
            this.teamOneRadioButton.AutoSize = true;
            this.teamOneRadioButton.Location = new System.Drawing.Point(3, 19);
            this.teamOneRadioButton.Name = "teamOneRadioButton";
            this.teamOneRadioButton.Size = new System.Drawing.Size(85, 17);
            this.teamOneRadioButton.TabIndex = 0;
            this.teamOneRadioButton.TabStop = true;
            this.teamOneRadioButton.Text = "radioButton1";
            this.teamOneRadioButton.UseVisualStyleBackColor = true;
            // 
            // teamTwoRadioButton
            // 
            this.teamTwoRadioButton.AutoSize = true;
            this.teamTwoRadioButton.Location = new System.Drawing.Point(94, 19);
            this.teamTwoRadioButton.Name = "teamTwoRadioButton";
            this.teamTwoRadioButton.Size = new System.Drawing.Size(85, 17);
            this.teamTwoRadioButton.TabIndex = 1;
            this.teamTwoRadioButton.TabStop = true;
            this.teamTwoRadioButton.Text = "radioButton2";
            this.teamTwoRadioButton.UseVisualStyleBackColor = true;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.Location = new System.Drawing.Point(12, 178);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(24, 25);
            this.creditLabel.TabIndex = 8;
            this.creditLabel.Text = "1";
            // 
            // BetMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 450);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.creditNumericUpDown);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.scoreTeam2TextBox);
            this.Controls.Add(this.scoreTeam1TextBox);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.MatchComboBox);
            this.Name = "BetMenuForm";
            this.Text = "Bet Menu";
            this.Load += new System.EventHandler(this.BetMenuForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.creditNumericUpDown)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox MatchComboBox;
        private System.Windows.Forms.ListBox historyListBox;
        private System.Windows.Forms.TextBox scoreTeam1TextBox;
        private System.Windows.Forms.TextBox scoreTeam2TextBox;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.NumericUpDown creditNumericUpDown;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton teamTwoRadioButton;
        private System.Windows.Forms.RadioButton teamOneRadioButton;
        private System.Windows.Forms.Label creditLabel;
    }
}