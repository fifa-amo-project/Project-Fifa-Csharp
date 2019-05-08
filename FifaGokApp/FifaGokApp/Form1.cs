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

namespace FifaGokApp
{
    public partial class Form1 : Form
    {

        string jsonTeams;
        public Form1()
        {
            InitializeComponent();
        }

        private void creditAmountLabel_Click(object sender, EventArgs e)
        {

        }

        public async Task<string> fetchTeams()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    string url = "http://localhost/Project-Fifa-PHP/simpleAPI/read.php";
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
        public void Form1_Load(object sender, EventArgs e)
        {

                string team = "teams";
                
                
                string url = string.Format("http://jaibreyonlourens.nl/Project-Fifa-PHP/API/read.php?team=teams{0}", team);
            using (var webClient = new WebClient())
            {
                var response = webClient.DownloadString(url);
                label1.Text = response;
            }              
               
           
        }

        private void LoadTeamsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
