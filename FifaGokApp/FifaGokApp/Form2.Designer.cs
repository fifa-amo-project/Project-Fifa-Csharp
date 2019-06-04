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
            this.teamTwoRadioButton = new System.Windows.Forms.RadioButton();
            this.teamOneRadioButton = new System.Windows.Forms.RadioButton();
            this.creditLabel = new System.Windows.Forms.Label();
            this.resultListBox = new System.Windows.Forms.ListBox();
            this.getResultsButton = new System.Windows.Forms.Button();
            this.payOutButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.creditNumericUpDown)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MatchComboBox
            // 
            this.MatchComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MatchComboBox.FormattingEnabled = true;
            this.MatchComboBox.Location = new System.Drawing.Point(56, 309);
            this.MatchComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.MatchComboBox.Name = "MatchComboBox";
            this.MatchComboBox.Size = new System.Drawing.Size(224, 24);
            this.MatchComboBox.TabIndex = 0;
            this.MatchComboBox.SelectedIndexChanged += new System.EventHandler(this.MatchComboBox_SelectedIndexChanged);
            // 
            // historyListBox
            // 
            this.historyListBox.FormattingEnabled = true;
            this.historyListBox.ItemHeight = 16;
            this.historyListBox.Location = new System.Drawing.Point(16, 15);
            this.historyListBox.Margin = new System.Windows.Forms.Padding(4);
            this.historyListBox.Name = "historyListBox";
            this.historyListBox.Size = new System.Drawing.Size(1050, 180);
            this.historyListBox.TabIndex = 1;
            // 
            // scoreTeam1TextBox
            // 
            this.scoreTeam1TextBox.Location = new System.Drawing.Point(56, 447);
            this.scoreTeam1TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.scoreTeam1TextBox.Name = "scoreTeam1TextBox";
            this.scoreTeam1TextBox.Size = new System.Drawing.Size(77, 22);
            this.scoreTeam1TextBox.TabIndex = 2;
            this.scoreTeam1TextBox.TextChanged += new System.EventHandler(this.scoreTeam1TextBox_TextChanged);
            // 
            // scoreTeam2TextBox
            // 
            this.scoreTeam2TextBox.Location = new System.Drawing.Point(187, 447);
            this.scoreTeam2TextBox.Margin = new System.Windows.Forms.Padding(4);
            this.scoreTeam2TextBox.Name = "scoreTeam2TextBox";
            this.scoreTeam2TextBox.Size = new System.Drawing.Size(79, 22);
            this.scoreTeam2TextBox.TabIndex = 3;
            this.scoreTeam2TextBox.TextChanged += new System.EventHandler(this.scoreTeam2TextBox_TextChanged);
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(107, 511);
            this.betButton.Margin = new System.Windows.Forms.Padding(4);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(100, 28);
            this.betButton.TabIndex = 4;
            this.betButton.Text = "zet in ";
            this.betButton.UseVisualStyleBackColor = true;
            this.betButton.Click += new System.EventHandler(this.BetButton_Click);
            // 
            // creditNumericUpDown
            // 
            this.creditNumericUpDown.Location = new System.Drawing.Point(128, 479);
            this.creditNumericUpDown.Margin = new System.Windows.Forms.Padding(4);
            this.creditNumericUpDown.Name = "creditNumericUpDown";
            this.creditNumericUpDown.Size = new System.Drawing.Size(79, 22);
            this.creditNumericUpDown.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.teamTwoRadioButton);
            this.groupBox1.Controls.Add(this.teamOneRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(56, 363);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(247, 60);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // teamTwoRadioButton
            // 
            this.teamTwoRadioButton.AutoSize = true;
            this.teamTwoRadioButton.Location = new System.Drawing.Point(125, 23);
            this.teamTwoRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.teamTwoRadioButton.Name = "teamTwoRadioButton";
            this.teamTwoRadioButton.Size = new System.Drawing.Size(110, 21);
            this.teamTwoRadioButton.TabIndex = 1;
            this.teamTwoRadioButton.TabStop = true;
            this.teamTwoRadioButton.Text = "radioButton2";
            this.teamTwoRadioButton.UseVisualStyleBackColor = true;
            // 
            // teamOneRadioButton
            // 
            this.teamOneRadioButton.AutoSize = true;
            this.teamOneRadioButton.Location = new System.Drawing.Point(4, 23);
            this.teamOneRadioButton.Margin = new System.Windows.Forms.Padding(4);
            this.teamOneRadioButton.Name = "teamOneRadioButton";
            this.teamOneRadioButton.Size = new System.Drawing.Size(110, 21);
            this.teamOneRadioButton.TabIndex = 0;
            this.teamOneRadioButton.TabStop = true;
            this.teamOneRadioButton.Text = "radioButton1";
            this.teamOneRadioButton.UseVisualStyleBackColor = true;
            // 
            // creditLabel
            // 
            this.creditLabel.AutoSize = true;
            this.creditLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditLabel.Location = new System.Drawing.Point(16, 219);
            this.creditLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.creditLabel.Name = "creditLabel";
            this.creditLabel.Size = new System.Drawing.Size(29, 31);
            this.creditLabel.TabIndex = 8;
            this.creditLabel.Text = "1";
            // 
            // resultListBox
            // 
            this.resultListBox.FormattingEnabled = true;
            this.resultListBox.ItemHeight = 16;
            this.resultListBox.Location = new System.Drawing.Point(340, 263);
            this.resultListBox.Name = "resultListBox";
            this.resultListBox.Size = new System.Drawing.Size(726, 180);
            this.resultListBox.TabIndex = 9;
            // 
            // getResultsButton
            // 
            this.getResultsButton.Location = new System.Drawing.Point(340, 479);
            this.getResultsButton.Name = "getResultsButton";
            this.getResultsButton.Size = new System.Drawing.Size(726, 59);
            this.getResultsButton.TabIndex = 10;
            this.getResultsButton.Text = "Haal de uitslag op";
            this.getResultsButton.UseVisualStyleBackColor = true;
            this.getResultsButton.Click += new System.EventHandler(this.getResultsButton_Click);
            // 
            // payOutButton
            // 
            this.payOutButton.Location = new System.Drawing.Point(16, 559);
            this.payOutButton.Name = "payOutButton";
            this.payOutButton.Size = new System.Drawing.Size(275, 51);
            this.payOutButton.TabIndex = 11;
            this.payOutButton.Text = "Uitbetalen";
            this.payOutButton.UseVisualStyleBackColor = true;
            this.payOutButton.Click += new System.EventHandler(this.payOutButton_Click);
            // 
            // BetMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 622);
            this.Controls.Add(this.payOutButton);
            this.Controls.Add(this.getResultsButton);
            this.Controls.Add(this.resultListBox);
            this.Controls.Add(this.creditLabel);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.creditNumericUpDown);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.scoreTeam2TextBox);
            this.Controls.Add(this.scoreTeam1TextBox);
            this.Controls.Add(this.historyListBox);
            this.Controls.Add(this.MatchComboBox);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.ListBox resultListBox;
        private System.Windows.Forms.Button getResultsButton;
        private System.Windows.Forms.Button payOutButton;
    }
}