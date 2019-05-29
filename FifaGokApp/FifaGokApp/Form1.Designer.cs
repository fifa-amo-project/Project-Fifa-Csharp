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
            this.saveButton = new System.Windows.Forms.Button();
            this.openBetFormButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(0, 39);
            this.welcomeLabel.TabIndex = 0;
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
            this.creditsLabel.Location = new System.Drawing.Point(495, 87);
            this.creditsLabel.Name = "creditsLabel";
            this.creditsLabel.Size = new System.Drawing.Size(127, 37);
            this.creditsLabel.TabIndex = 12;
            this.creditsLabel.Text = "Credits:";
            // 
            // creditAmountLabel
            // 
            this.creditAmountLabel.AutoSize = true;
            this.creditAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creditAmountLabel.Location = new System.Drawing.Point(628, 87);
            this.creditAmountLabel.Name = "creditAmountLabel";
            this.creditAmountLabel.Size = new System.Drawing.Size(35, 37);
            this.creditAmountLabel.TabIndex = 13;
            this.creditAmountLabel.Text = "0";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(19, 297);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(120, 47);
            this.saveButton.TabIndex = 18;
            this.saveButton.Text = "opslaan";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // openBetFormButton
            // 
            this.openBetFormButton.Location = new System.Drawing.Point(466, 297);
            this.openBetFormButton.Name = "openBetFormButton";
            this.openBetFormButton.Size = new System.Drawing.Size(133, 47);
            this.openBetFormButton.TabIndex = 23;
            this.openBetFormButton.Text = "Maak een gok";
            this.openBetFormButton.UseVisualStyleBackColor = true;
            this.openBetFormButton.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 382);
            this.Controls.Add(this.openBetFormButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.creditsLabel);
            this.Controls.Add(this.creditAmountLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "Form1";
            this.Tag = "";
            this.Text = "Fifa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label creditsLabel;
        private System.Windows.Forms.Label creditAmountLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button openBetFormButton;
    }
}

