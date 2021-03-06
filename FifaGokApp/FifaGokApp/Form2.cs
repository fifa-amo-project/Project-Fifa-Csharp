﻿using System;
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
    public partial class BetMenuForm : Form
    {
        int winner;
        public BetMenuForm()
        {
            InitializeComponent();
        }

        public int creditAmount;
        public string winningteam;
        public string losingteam;
        public bool isBetPlaced;
        
        public void updateMoneyLabel()
        {
            if (Application.OpenForms.OfType<BetMenuForm>().Count() == 1)
            {
                creditAmount = Program.guy.Credits;
            }
            else
            {
                // hier komt de credits te staan van de laatste savegame
            }
            creditLabel.Text = creditAmount.ToString();
            creditNumericUpDown.Maximum = creditAmount;
            creditNumericUpDown.ReadOnly = true;
        }

        public void GetResults()
        {
            resultListBox.Items.Clear();
            for (int i = 0; i < Program.fifa.match.Count; i++)
            {
                Program.fifa.GetResults();
                resultListBox.Items.Add(string.Format("{0} - {1}", Program.fifa.match[i].result_team1, Program.fifa.match[i].result_team2));
            }
        }

        public void GetMatches()
        {
            MatchComboBox.Items.Clear();
            for (int i = 0; i < Program.fifa.match.Count; i++)
            {
                Program.fifa.GetMatches();
                MatchComboBox.Items.Add(string.Format("{0} - {1}", Program.fifa.match[i].team1, Program.fifa.match[i].team2));
            }
        }
        private void BetMenuForm_Load(object sender, EventArgs e)
        {
            getResultsButton.Enabled = false;
            updateMoneyLabel();
            GetMatches();
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            int parsedValue;

            if (scoreTeam1TextBox.Text == string.Empty || scoreTeam2TextBox.Text == string.Empty)
            {
                MessageBox.Show("voer aub een stand in.");
            }
            else if (int.Parse(scoreTeam1TextBox.Text) < int.Parse(scoreTeam2TextBox.Text) && teamOneRadioButton.Checked)
            {
                MessageBox.Show("Error, je mag niet wedden dat iemand verliest.");
                Program.guy.CollectEven(winner);
                updateMoneyLabel();
            }
            else if (int.Parse(scoreTeam1TextBox.Text) > int.Parse(scoreTeam2TextBox.Text) && teamTwoRadioButton.Checked)
            {
                MessageBox.Show("Error, je mag niet wedden dat iemand verliest.");
                Program.guy.CollectEven(winner);
                updateMoneyLabel();
            }
           else if (int.Parse(scoreTeam1TextBox.Text) == int.Parse(scoreTeam2TextBox.Text))
            {
                MessageBox.Show("Error, je mag niet wedden op gelijkspel.");
                Program.guy.CollectEven(winner);
                updateMoneyLabel();
            }

            else if (!int.TryParse(scoreTeam1TextBox.Text, out parsedValue) || !int.TryParse(scoreTeam2TextBox.Text, out parsedValue))
            {
                MessageBox.Show("alleen nummers aub.");
                return;
            }
            else if (creditAmount < creditNumericUpDown.Value)
            {
                MessageBox.Show("sorry je hebt niet genoeg geld om in te zetten.");
            }
            else if (creditNumericUpDown.Value == 0)
            {
                MessageBox.Show("geen bedrag ingezet. voer aub een bedrag in.");
            }
            else
            {   
                int bettetAmount = (int)creditNumericUpDown.Value;
                Program.guy.Credits -= bettetAmount;
                Program.guy.BetAmount = bettetAmount;
                creditAmount = Program.guy.Credits;
                creditLabel.Text = creditAmount.ToString();
                bettetAmount = Program.guy.BetAmount;
                winningteam = SelectedTeamName();
                losingteam = LosingTeam();
                Program.guy.TeamBetOn = winningteam;
                MessageBox.Show(string.Format("{0} heeft op {1} {2} euro gezet. ", 
                    Program.guy.Name, SelectedTeamName(), creditNumericUpDown.Value));
                historyListBox.Items.Add(string.Format("{0} heeft {1} euro op {2} gezet tegen {3} met als stand: {4} - {5}.",
                    Program.guy.Name, creditNumericUpDown.Value, SelectedTeamName(),
                    losingteam, scoreTeam1TextBox.Text, scoreTeam2TextBox.Text));
                creditNumericUpDown.Value = 0;
                getResultsButton.Enabled = true;
                betButton.Enabled = false;
            }
        }

        public string SelectedTeamName()
        {
            if (teamOneRadioButton.Checked)
            {
                return teamOneRadioButton.Text;
            }
            else
            {
                return teamTwoRadioButton.Text;
            }
        }

        public string LosingTeam()
        {
            if (teamOneRadioButton.Checked)
            {
                return teamTwoRadioButton.Text;
            }
            else
            {
                return teamOneRadioButton.Text;
            }
        }
        private void MatchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamOneRadioButton.Text = Program.fifa.match[MatchComboBox.SelectedIndex].team1;
            teamTwoRadioButton.Text = Program.fifa.match[MatchComboBox.SelectedIndex].team2;
        }

        private void getResultsButton_Click(object sender, EventArgs e)
        {

            string ifWon = "";
            resultListBox.Items.Clear();

            for (int i = 0; i < Program.fifa.match.Count; i++)
            {
                if (Program.fifa.match[i].result_team1 > Program.fifa.match[i].result_team2)
                {
                   ifWon = "Gewonnen van";
                }
                else if (Program.fifa.match[i].result_team1 < Program.fifa.match[i].result_team2)
                {
                    ifWon = "Verloren van";
                }
                else if (Program.fifa.match[i].result_team1 == Program.fifa.match[i].result_team2)
                {
                    ifWon = "Gelijkgespeeld met";
                }
                Program.fifa.GetResults();
                resultListBox.Items.Add(string.Format("{0} heeft {1} {2} met als uitslag {3} - {4}. ",
                Program.fifa.match[i].team1, ifWon,
                Program.fifa.match[i].team2,
                Program.fifa.match[i].result_team1, Program.fifa.match[i].result_team2));
            }
        }

        public void payOutButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < Program.fifa.match.Count; i++)
            {
                if (Program.fifa.match[i].result_team1 == int.Parse(scoreTeam1TextBox.Text)
                    && Program.fifa.match[i].result_team2 == int.Parse(scoreTeam2TextBox.Text)
                    && teamOneRadioButton.Checked
                    && teamOneRadioButton.Text == Program.fifa.match[i].team1
                    && teamTwoRadioButton.Text == Program.fifa.match[i].team2
                    && Program.fifa.match[i].result_team1 > Program.fifa.match[i].result_team2
                    )
                {
                    Program.guy.CollectTriple(winner);
                    updateMoneyLabel();
                    getResultsButton.Enabled = false;
                    betButton.Enabled = true;
                }
                
                else if (Program.fifa.match[i].result_team2 == int.Parse(scoreTeam2TextBox.Text)
                    && Program.fifa.match[i].result_team1 == int.Parse(scoreTeam1TextBox.Text)
                    && teamTwoRadioButton.Checked
                    && teamOneRadioButton.Text == Program.fifa.match[i].team1
                    && teamTwoRadioButton.Text == Program.fifa.match[i].team2
                    && Program.fifa.match[i].result_team1 < Program.fifa.match[i].result_team2)
                {
                    Program.guy.CollectTriple(winner);
                    updateMoneyLabel();
                    getResultsButton.Enabled = false;
                    betButton.Enabled = true;
                }

                else if (Program.fifa.match[i].result_team1 == Program.fifa.match[i].result_team2
                    && teamOneRadioButton.Text == Program.fifa.match[i].team1
                    && teamTwoRadioButton.Text == Program.fifa.match[i].team2
                    && Program.fifa.match[i].result_team1 == int.Parse(scoreTeam1TextBox.Text)
                    && Program.fifa.match[i].result_team2 == int.Parse(scoreTeam2TextBox.Text)
                    )
                {
                    Program.guy.Collect(winner);
                    updateMoneyLabel();
                    getResultsButton.Enabled = false;
                    betButton.Enabled = true;
                }

                else if (Program.fifa.match[i].result_team1 > Program.fifa.match[i].result_team2
                    && teamOneRadioButton.Checked
                    && teamOneRadioButton.Text == Program.fifa.match[i].team1
                    && teamTwoRadioButton.Text == Program.fifa.match[i].team2 
                    && int.Parse(scoreTeam1TextBox.Text) > int.Parse(scoreTeam2TextBox.Text) )
                {
                    Program.guy.Collect(winner);
                    updateMoneyLabel();
                    getResultsButton.Enabled = false;
                    betButton.Enabled = true;
                }
                else if (Program.fifa.match[i].result_team2 > Program.fifa.match[i].result_team1
                    && teamTwoRadioButton.Checked
                    && teamOneRadioButton.Text == Program.fifa.match[i].team1
                    && teamTwoRadioButton.Text == Program.fifa.match[i].team2
                    && int.Parse(scoreTeam2TextBox.Text) > int.Parse(scoreTeam1TextBox.Text))
                {
                    Program.guy.Collect(winner);
                    updateMoneyLabel();
                    getResultsButton.Enabled = false;
                    betButton.Enabled = true;
                }

                else if (Program.fifa.match[i].result_team1 < Program.fifa.match[i].result_team2
                    && teamOneRadioButton.Checked
                    && teamOneRadioButton.Text == Program.fifa.match[i].team1
                    && teamTwoRadioButton.Text == Program.fifa.match[i].team2
                    )
                {
                    MessageBox.Show("Aww, verloren!");
                    updateMoneyLabel();
                    getResultsButton.Enabled = false;
                    betButton.Enabled = true;
                }
                else if (Program.fifa.match[i].result_team2 < Program.fifa.match[i].result_team1
                    && teamTwoRadioButton.Checked
                    && teamOneRadioButton.Text == Program.fifa.match[i].team1
                    && teamTwoRadioButton.Text == Program.fifa.match[i].team2
                   )
                {
                    MessageBox.Show("Aww, verloren!");
                    updateMoneyLabel();
                    getResultsButton.Enabled = false;
                    betButton.Enabled = true;
                }
                else if (Program.fifa.match[i].result_team1 == 0 && Program.fifa.match[i].result_team2 == 0
                    && teamOneRadioButton.Text == Program.fifa.match[i].team1
                    && teamTwoRadioButton.Text == Program.fifa.match[i].team2)
                {
                    MessageBox.Show("De wedstrijd is nog niet gespeeld of het wedstrijd resultaat is 0 - 0. \n" +
                        "wacht tot de wedstrijd is gespeeld, haal de uitslagen opnieuw op en druk op uitbetalen.");
                    updateMoneyLabel();
                }
                
            }
        }

        private void scoreTeam2TextBox_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;

            if ( !int.TryParse(scoreTeam2TextBox.Text, out parsedValue) && scoreTeam2TextBox.Text != ""  )
            {
                scoreTeam2TextBox.Clear();
                MessageBox.Show("Alleen nummers alsjeblieft.");
            }
        }

        private void scoreTeam1TextBox_TextChanged(object sender, EventArgs e)
        {
            int parsedValue;

            if (!int.TryParse(scoreTeam1TextBox.Text, out parsedValue) && scoreTeam1TextBox.Text != "")
            {
                scoreTeam1TextBox.Clear();
                MessageBox.Show("Alleen nummers alsjeblieft.");
            }
        }
    }
}
