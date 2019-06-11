using System;
using System.Net;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;


namespace FifaGokApp
{
    public partial class Form1 : Form
    {   string jsonTeams;
        public int creditAmount;
        Random rnd = new Random();

        BetMenuForm betmenu = new BetMenuForm();

        Label teamLabel;
        TextBox scoreTeam;
        TextBox scoreTeam2;
        Label colonLabel;

        Label officialScore;
        Label officialScore2;

        public int randomNumber()
        {
            return rnd.Next(1, 11);
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        public void updateMoneyLabel()
        {
            if (Application.OpenForms.OfType<Form1>().Count() == 1)
            {
                creditAmount = Program.guy.Credits;
            }
            
            creditAmountLabel.Text = creditAmount.ToString();
           
        }

       

        public void Form1_Load(object sender, EventArgs e)
        {
            
            updateMoneyLabel();
            welcomeLabel.Text = string.Format("Welkom {0} in de FIFA gok app!", Program.guy.Name);
        }


        Gokker[] gokker = new Gokker[1];
      

        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            betmenu.ShowDialog();
            this.Show();
            creditAmountLabel.Text = Program.guy.Credits.ToString();
            updateMoneyLabel();
        }

        private void LoadTeamsButton_Click_1(object sender, EventArgs e)
        {
            Program.fifa.GetMatches();
        }
    }
}