using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FifaGokApp
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }
        private void CreateGuyButton_Click(object sender, EventArgs e)
        {
            //Hier doe je dat je niet meer dan 20 karakters kan invoeren, anders krijg je waarschuwing en kan je niet verder.
            if (nameTextBox.Text.Length > 20)
            {
                MessageBox.Show("doe kortere naam.");
            }
            else
            {
                Form1 mainform = new Form1();
                name = nameTextBox.Text;
                Program.guy.Name = name;
                this.Hide();
                mainform.ShowDialog();
            }
        }

        public string name = "";

        
    }
}
