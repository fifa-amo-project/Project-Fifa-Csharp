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
            else
            { 
                // hier komt de credits te staan van de laatste savegame
            }
            creditAmountLabel.Text = creditAmount.ToString();
        }

        public async Task<string> fetchTeams()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string url = "http://jaibreyonlourens.nl/Project-Fifa-PHP/API/read.php";
                    HttpResponseMessage response = await httpClient.GetAsync(url);
                    response.EnsureSuccessStatusCode();

                    jsonTeams = await response.Content.ReadAsStringAsync();
                    return jsonTeams;
                }
                catch
                {
                    return "";
                }
            }
        }

        public void UpdateScreen()
        {
            //pakt alle labels van teamlabel
            var labelsVar = teamPanel.Controls.OfType<Label>();

            //alle teamlabels naar een list converten
            List<Label> labels = new List<Label>();
            foreach (Label label in labelsVar)
            {
                if (!label.Text.Contains(":"))
                {
                    labels.Add(label);
                }
            }

            bool isLeftSide = true;
            int locationY = teamLabel1.Location.Y;
            int locationTextBoxY = teamScore1.Location.Y;
            int i = 0;


            for (int k = 0; k < Program.fetchedTeams.Count(); k++)
            {
                for (; i < labels.Count(); i++, k++)
                {
                    labels[i].Text = Program.fetchedTeams[k].TeamName;
                }
                if (isLeftSide)
                {
                    Label teamLabel = new Label();
                    teamLabel.AutoSize = true;
                    teamLabel.Text = Program.fetchedTeams[k].TeamName;
                    teamLabel.Location = new System.Drawing.Point(6, locationY += 30);
                    teamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(teamLabel);

                    // adding score section
                    TextBox scoreTeam = new TextBox();
                    scoreTeam.Size = new System.Drawing.Size(31, 20);
                    scoreTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    scoreTeam.Location = new System.Drawing.Point(155, locationTextBoxY += 30);
                    teamPanel.Controls.Add(scoreTeam);

                    TextBox scoreTeam2 = new TextBox();
                    scoreTeam2.Size = new System.Drawing.Size(31, 20);
                    scoreTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    scoreTeam2.Location = new System.Drawing.Point(217, locationTextBoxY);
                    teamPanel.Controls.Add(scoreTeam2);

                    Label colonLabel = new Label();
                    colonLabel.AutoSize = true;
                    colonLabel.Text = ":";
                    colonLabel.Location = new System.Drawing.Point(192, locationY);
                    colonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(colonLabel);

                    isLeftSide = false;
                }
                else
                {
                    Label teamLabel = new Label();
                    teamLabel.AutoSize = true;
                    teamLabel.Text = Program.fetchedTeams[k].TeamName;
                    teamLabel.Location = new System.Drawing.Point(280, locationY);
                    teamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(teamLabel);

                    isLeftSide = true;
                }
            }
        }

        

        

        public void Form1_Load(object sender, EventArgs e)
        {
            UpdateScreen();
           
            updateMoneyLabel();
            welcomeLabel.Text = string.Format("Welkom {0} in de FIFA gok app!", Program.guy.Name);
         
        }

        private void Label2_Click(object sender, EventArgs e)
        {
        }

        private void TeamScore2_TextChanged(object sender, EventArgs e)
        {
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Program.guy.SaveGokker();
        }

        private void AddGuyButton_Click(object sender, EventArgs e)
        {

        }

        private void LoadTeamsButton_Click(object sender, EventArgs e)
        {
            Program.guy.LoadGokker();
        }
    }
}
