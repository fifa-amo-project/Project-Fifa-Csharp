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
    public class Bet
    {
        public int Amount { get; set; }
        public int Match { get; set; }
        
        

        public int Payout(int winner)
        {
            if(Match == winner)
            {
                Amount = Program.guy.BetAmount;
                
                MessageBox.Show("je hebt het geld gewonnen!");
                Amount *= 2;
               Program.guy.Credits += Amount;
                Clearbet();
                return Program.guy.Credits;
                


            }
            else
            {
                Clearbet();
                return 0;
            }
        }

        public int PayOutEven()
        {
            
            
               
                int amount = Program.guy.BetAmount;
                
                Amount *= 1;
                Clearbet();
                return Program.guy.Credits += Amount;


            
            
        }

            private void Clearbet()
            {
                
                Amount = Program.guy.BetAmount;
                MessageBox.Show("Je weddenschappen zijn verwijdert en je kan opnieuw gokken!");
                Amount = 0;
            
            }

    }
}
