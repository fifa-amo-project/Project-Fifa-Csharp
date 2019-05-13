namespace FifaGokApp
{
    partial class Form1
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.creditsLabel = new System.Windows.Forms.Label();
            this.creditAmountLabel = new System.Windows.Forms.Label();
            this.betButton = new System.Windows.Forms.Button();
            this.loadTeamsButton = new System.Windows.Forms.Button();
            this.load = new System.Windows.Forms.Label();
            this.teamPanel = new System.Windows.Forms.Panel();
            this.teamLabel2 = new System.Windows.Forms.Label();
            this.teamLabel1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.teamScore2 = new System.Windows.Forms.TextBox();
            this.teamScore1 = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.teamPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(451, 39);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welkom in de FIFA gok app!\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(410, 66);
            this.label1.TabIndex = 0;
            this.label1.Text = "Zet een bod op jou team \r\nof een ander team naar keuze.";
            // 
            // creditsLabel
            // 
            this.creditsLabel.AutoSize = true;
            this.creditsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditsLabel.Location = new System.Drawing.Point(572, 30);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(127, 37);
            this.creditsLabel.TabIndex = 12;
            this.creditsLabel.Text = "Credits:";
            // 
            // creditAmountLabel
            // 
            this.creditAmountLabel.AutoSize = true;
            this.creditAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAmountLabel.Location = new System.Drawing.Point(695, 30);
            this.creditAmountLabel.Name = "creditAmountLabel";
            this.creditAmountLabel.Size = new System.Drawing.Size(35, 37);
            this.creditAmountLabel.TabIndex = 13;
            this.creditAmountLabel.Text = "0";
            // 
            // betButton
            // 
            this.betButton.Location = new System.Drawing.Point(345, 343);
            this.betButton.Name = "betButton";
            this.betButton.Size = new System.Drawing.Size(124, 38);
            this.betButton.TabIndex = 14;
            this.betButton.Text = "Zet in";
            this.betButton.UseVisualStyleBackColor = true;
            // 
            // loadTeamsButton
            // 
            this.loadTeamsButton.Location = new System.Drawing.Point(730, 607);
            this.loadTeamsButton.Name = "loadTeamsButton";
            this.loadTeamsButton.Size = new System.Drawing.Size(120, 47);
            this.loadTeamsButton.TabIndex = 15;
            this.loadTeamsButton.Text = "Laad";
            this.loadTeamsButton.UseVisualStyleBackColor = true;
            // 
            // load
            // 
            this.load.AutoSize = true;
            this.load.Location = new System.Drawing.Point(727, 576);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(41, 13);
            this.load.TabIndex = 16;
            this.load.Text = "label14";
            // 
            // teamPanel
            // 
            this.teamPanel.Controls.Add(this.teamLabel2);
            this.teamPanel.Controls.Add(this.teamLabel1);
            this.teamPanel.Controls.Add(this.label2);
            this.teamPanel.Controls.Add(this.teamScore2);
            this.teamPanel.Controls.Add(this.teamScore1);
            this.teamPanel.Location = new System.Drawing.Point(235, 163);
            this.teamPanel.Name = "teamPanel";
            this.teamPanel.Size = new System.Drawing.Size(386, 153);
            this.teamPanel.TabIndex = 17;
            // 
            // teamLabel2
            // 
            this.teamLabel2.AutoSize = true;
            this.teamLabel2.Location = new System.Drawing.Point(320, 15);
            this.teamLabel2.Name = "teamLabel2";
            this.teamLabel2.Size = new System.Drawing.Size(35, 13);
            this.teamLabel2.TabIndex = 4;
            this.teamLabel2.Text = "label4";
            // 
            // teamLabel1
            // 
            this.teamLabel1.AutoSize = true;
            this.teamLabel1.Location = new System.Drawing.Point(12, 18);
            this.teamLabel1.Name = "teamLabel1";
            this.teamLabel1.Size = new System.Drawing.Size(35, 13);
            this.teamLabel1.TabIndex = 3;
            this.teamLabel1.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            this.label2.Click += new System.EventHandler(this.Label2_Click);
            // 
            // teamScore2
            // 
            this.teamScore2.Location = new System.Drawing.Point(217, 19);
            this.teamScore2.Name = "teamScore2";
            this.teamScore2.Size = new System.Drawing.Size(31, 20);
            this.teamScore2.TabIndex = 1;
            this.teamScore2.TextChanged += new System.EventHandler(this.TeamScore2_TextChanged);
            // 
            // teamScore1
            // 
            this.teamScore1.Location = new System.Drawing.Point(155, 18);
            this.teamScore1.Name = "teamScore1";
            this.teamScore1.Size = new System.Drawing.Size(31, 20);
            this.teamScore1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(349, 607);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 47);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "opslaan";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 666);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.teamPanel);
            this.Controls.Add(this.load);
            this.Controls.Add(this.loadTeamsButton);
            this.Controls.Add(this.betButton);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.creditAmountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.teamPanel.ResumeLayout(false);
            this.teamPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label creditAmountLabel;
        private System.Windows.Forms.Button betButton;
        private System.Windows.Forms.Button loadTeamsButton;
        private System.Windows.Forms.Label load;
        private System.Windows.Forms.Panel teamPanel;
        private System.Windows.Forms.Label teamLabel2;
        private System.Windows.Forms.Label teamLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox teamScore2;
        private System.Windows.Forms.TextBox teamScore1;
        private System.Windows.Forms.Button saveButton;
    }
}

