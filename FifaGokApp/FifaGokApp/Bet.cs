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
    public class Bet
    {
        public int Amount { get; set; }
        public int Match { get; set; }
        public Gokker Gokker;
        

        public int Payout(int winner)
        {
            if(Match == winner)
            {
                Gokker = Program.guy;
                int amount = Program.guy.BetAmount;
                MessageBox.Show("je hebt het geld gewonnen!");
                amount *= 2;
                Clearbet();
                return Gokker.Credits += amount;
                
                
                
            }
            else
            {
                Clearbet();
                return 0;
            }
        }

        public int PayOutEven()
        {
            
            
                Gokker = Program.guy;
                int amount = Program.guy.BetAmount;
                
                amount *= 1;
                Clearbet();
                return Gokker.Credits += amount;


            
            
        }

            private void Clearbet()
        {
            Gokker = Program.guy;
            int amount = Program.guy.BetAmount;
            MessageBox.Show("Je weddenschappen zijn verwijdert en je kan opnieuw gokken!");
            Program.guy.BetAmount = 0;
            
        }

    }
}
