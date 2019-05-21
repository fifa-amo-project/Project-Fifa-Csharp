﻿using System;
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

        Label teamLabel;
        TextBox scoreTeam;
        TextBox scoreTeam2;
        Label colonLabel;


        Label TeamAName;
        Label TeamAScore;
        Label between;
        Label TeamBScore;
        Label TeamBName;

        public int GuyThatBets { get; set; }

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
            else
            { 
                // hier komt de credits te staan van de laatste savegame
            }
            creditAmountLabel.Text = creditAmount.ToString();
            creditNumericUpDown.Maximum = creditAmount;
            creditNumericUpDown.ReadOnly = true;
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


        public void Updatematches()
        {
            /*var labelsVar = teamPanel.Controls.OfType<Label>();
            List<Label> team1label = new List<Label>();
            foreach (Label label in labelsVar)
            {
                if (!label.Text.Contains(":"))
                {
                    team1label.Add(label);
                }
            }
            List<Label> team2label = new List<Label>();
            foreach (Label label in labelsVar)
            {
                if (!label.Text.Contains(":"))
                {
                    team2label.Add(label);
                }
            }*/
            bool isLeftSide = true;
            int locationY = teamLabel1.Location.Y;
            int locationTextBoxY = teamScore1.Location.Y;
            
            int i = 0;

            teamLabel1.Text = Program.fifa.match[0].team1;
            teamLabel2.Text = Program.fifa.match[0].team2;

            for (int j = 1; j < Program.fifa.match.Count; j++)
            {
                
                
                
               

                    Label teamlabel = new Label();
                    teamlabel.AutoSize = true;
                    teamlabel.Text = Program.fifa.match[j].team1;
                

                    teamlabel.Location = new System.Drawing.Point(6, locationY += 30);
                    teamlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(teamlabel);

                    Label team2Label = new Label();
                    team2Label.AutoSize = true;
                    team2Label.Text = Program.fifa.match[j].team2;
                    team2Label.Location = new System.Drawing.Point(280, locationY);
                    team2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(team2Label);
                //add score section
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
                /*if (isLeftSide)
                    {
                        


                      


                   

                    }
                    else
                    {
                    

                    isLeftSide = true;
                    }*/


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


            for (int k = 0; k < Program.fifa.team.Count; k++)
            {
                for (; i < labels.Count(); i++, k++)
                {
                    labels[i].Text = Program.fifa.team[k].TeamName;
                }
                if (isLeftSide)
                {
                    teamLabel = new Label();
                    teamLabel.AutoSize = true;
                    teamLabel.Text = Program.fifa.team[k].TeamName;
                    teamLabel.Location = new System.Drawing.Point(6, locationY += 30);
                    teamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(teamLabel);

                    // adding score section
                    scoreTeam = new TextBox();
                    scoreTeam.Size = new System.Drawing.Size(31, 20);
                    scoreTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    scoreTeam.Location = new System.Drawing.Point(155, locationTextBoxY += 30);
                    teamPanel.Controls.Add(scoreTeam);

                    scoreTeam2 = new TextBox();
                    scoreTeam2.Size = new System.Drawing.Size(31, 20);
                    scoreTeam2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    scoreTeam2.Location = new System.Drawing.Point(217, locationTextBoxY);
                    teamPanel.Controls.Add(scoreTeam2);

                    colonLabel = new Label();
                    colonLabel.AutoSize = true;
                    colonLabel.Text = ":";
                    colonLabel.Location = new System.Drawing.Point(192, locationY);
                    colonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(colonLabel);

                    isLeftSide = false;
                }
                else
                {
                    teamLabel = new Label();
                    teamLabel.AutoSize = true;
                    teamLabel.Text = Program.fifa.team[k].TeamName;
                    teamLabel.Location = new System.Drawing.Point(280, locationY);
                    teamLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    teamPanel.Controls.Add(teamLabel);

                    isLeftSide = true;
                }
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {


            Updatematches();
            
           
            updateMoneyLabel();
            welcomeLabel.Text = string.Format("Welkom {0} in de FIFA gok app!", Program.guy.Name);
        }


        Gokker[] gokker = new Gokker[1];
        private void betButton_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (teamScore1.Text == string.Empty || teamScore2.Text == string.Empty)
            {
                MessageBox.Show("voer aub een stand in");
            }
            else if (!int.TryParse(teamScore1.Text, out parsedValue) || !int.TryParse(teamScore2.Text, out parsedValue))
            {
                MessageBox.Show("alleen nummers aub");
                return;
            }
            else if (creditAmount < creditNumericUpDown.Value)
            {
                MessageBox.Show("sorry je hebt niet genoeg geld om in te zetten");
            }
            else if(creditNumericUpDown.Value == 0)
            {
                MessageBox.Show("geen bedrag ingezet. voer aub een bedrag in");
            }
            else
            {
                int bettetAmount = (int)creditNumericUpDown.Value;
                for (int i = 0; i < Program.fifa.match.Count; i++)
                {
                    GuyThatBets = 1;
                    int currentMatch = Program.fifa.match[i].id;
                    gokker[GuyThatBets].PlaceBet(bettetAmount, currentMatch);
                }
                
                creditAmountLabel.Text = (creditAmount - bettetAmount).ToString();



                // hier komt de code voor het wedden
                // is nog niet goed functioneel
                


                


                // na elke keer op de knop te klikken, hoort er een nieuwe stand bij elke team te komen.
                for (int i = 0; i < Program.fifa.team.Count / 2; i++)
                {
                    TeamAScore.Text = randomNumber().ToString();
                    resultPanel.Controls.Add(TeamAScore);

                    TeamBScore.Text = randomNumber().ToString();
                    resultPanel.Controls.Add(TeamBScore);
                }

                creditNumericUpDown.Value = 0;
            }
        }


        public void CheckBet()
        {
           
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Program.guy.SaveGokker();
        }

        private void LoadTeamsButton_Click(object sender, EventArgs e)
        {
            Program.guy.LoadGokker();
            
        }
        

        private void teamPanel_Paint(object sender, PaintEventArgs e)
        {
            
            for (int i = 0; i < Program.fifa.team.Count() / 2; i++)
            {
                //naam van de team aan de rechterkant
                TeamAName = new Label();
                TeamAName.Text = Program.fifa.team[i*2].TeamName;
                TeamAName.Size = new Size(100, 30);
                TeamAName.Location = new Point(0, i * 30);
                resultPanel.Controls.Add(TeamAName);

                //score van de team aan de linkerkant
                TeamAScore = new Label();
                TeamAScore.Text = randomNumber().ToString();
                TeamAScore.Size = new Size(20, 30);
                TeamAScore.Location = new Point(100, i * 30);
                resultPanel.Controls.Add(TeamAScore);

                // dit is de ":"
                between = new Label();
                between.Text = " : ";
                between.Size = new Size(15, 30);
                between.Location = new Point(125, i * 30);
                resultPanel.Controls.Add(between);

                //score van de team aan de rechterkant
                TeamBScore = new Label();
                TeamBScore.Text = randomNumber().ToString();
                TeamBScore.Size = new Size(20, 30);
                TeamBScore.Location = new Point(150, i * 30);
                resultPanel.Controls.Add(TeamBScore);

                //naam van de team aan de rechterkant
                TeamBName = new Label();
                TeamBName.Text = Program.fifa.team[i * 2 + 1].TeamName;
                TeamBName.Location = new Point(250, i * 30);
                resultPanel.Controls.Add(TeamBName);
            }
            
        }

        private void TeamLabel1_Click(object sender, EventArgs e)
        {

        }

        private void TeamLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}