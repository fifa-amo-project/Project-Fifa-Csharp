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
                int amount = Amount;
                MessageBox.Show("je hebt het geld gewonnen!");
                Clearbet();
                return Gokker.Credits;
            }
            else
            {
                Clearbet();
                return 0;
            }
        }
        private void Clearbet()
        {
            Amount = 0;
        }

    }
}
