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
using System.Diagnostics;

namespace FifaGokApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>

        // public static string match = new WebClient().DownloadString("http://jaibreyonlourens.nl/Project-Fifa-PHP/API/readmatch.php");
        // public static string json = new WebClient().DownloadString("http://jaibreyonlourens.nl/Project-Fifa-PHP/API/read.php");
        // public static MatchFetch[] fetchedmatch = JsonConvert.DeserializeObject<MatchFetch[]>(match);
        //public static Record[] fetchedTeams = JsonConvert.DeserializeObject<Record[]>(json);
        public static Fifa fifa = new Fifa();
        
        public static Gokker guy = new Gokker("", 50, false, 0, "");

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RegisterForm());
        }
    }
}
