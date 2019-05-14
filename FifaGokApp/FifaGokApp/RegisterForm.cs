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
        Form1 mainform = new Form1();
        public RegisterForm()
        {
            InitializeComponent();
        }

        public string name = "";

        private void CreateGuyButton_Click(object sender, EventArgs e)
        {
            
            name = nameTextBox.Text;
            Program.guy.Name = name;
            this.Hide();
            mainform.ShowDialog();
        }
    }
}
