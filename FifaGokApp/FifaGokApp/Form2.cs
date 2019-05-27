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
    public partial class BetMenuForm : Form
    {
        public BetMenuForm()
        {
            InitializeComponent();
        }

        public int creditAmount;
        public string winningteam;
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
            updateMoneyLabel();
            GetMatches();
        }

        private void BetButton_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (scoreTeam1TextBox.Text == string.Empty || scoreTeam2TextBox.Text == string.Empty)
            {
                MessageBox.Show("voer aub een stand in");
            }

            
            

            
            else if (!int.TryParse(scoreTeam1TextBox.Text, out parsedValue) || !int.TryParse(scoreTeam2TextBox.Text, out parsedValue))
            {
                MessageBox.Show("alleen nummers aub");
                return;
            }
            else if (creditAmount < creditNumericUpDown.Value)
            {
                MessageBox.Show("sorry je hebt niet genoeg geld om in te zetten");
            }
            else if (creditNumericUpDown.Value == 0)
            {
                MessageBox.Show("geen bedrag ingezet. voer aub een bedrag in");
            }
            else
            {
                int bettetAmount = (int)creditNumericUpDown.Value;
                Program.guy.Credits -= bettetAmount;
                creditAmount = Program.guy.Credits;
                creditLabel.Text = creditAmount.ToString();
                bettetAmount = Program.guy.BetAmount;
                winningteam = SelectedTeamName();
                winningteam = Program.guy.TeamBetOn;
                MessageBox.Show(string.Format("{0} heeft op {1} {2} euro gezet. ", Program.guy.Name, SelectedTeamName(), creditNumericUpDown.Value));
                   
                    historyListBox.Items.Add(string.Format("{0} heeft {1} euro op {2} gezet met als stand: {3} - {4}", Program.guy.Name, creditNumericUpDown.Value, SelectedTeamName(), scoreTeam1TextBox.Text, scoreTeam2TextBox.Text) );
                
                creditNumericUpDown.Value = 0;
            
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
        private void MatchComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            teamOneRadioButton.Text = Program.fifa.match[MatchComboBox.SelectedIndex].team1;
            teamTwoRadioButton.Text = Program.fifa.match[MatchComboBox.SelectedIndex].team2;
        }
    }
}
