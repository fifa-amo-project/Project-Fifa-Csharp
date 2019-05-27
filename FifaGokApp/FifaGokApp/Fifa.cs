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
    public class Team
    {
        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("teamname")]
        public string TeamName { get; set; }

        [JsonProperty("players")]
        public string Players { get; set; }

        [JsonProperty("created_by")]
        public string created_by { get; set; }

        [JsonProperty("points")]
        public string points { get; set; }



        ///matches 
        ///
        
    }
    public class Match
    {

        [JsonProperty("id")]
        public string id { get; set; }

        [JsonProperty("team1")]
        public string team1 { get; set; }

        [JsonProperty("team2")]
        public string team2 { get; set; }

        [JsonProperty("uitslag")]
        public string uitslag { get; set; }

        [JsonProperty("result_team1")]
        public int result_team1 { get; set; }

        [JsonProperty("result_team2")]
        public int result_team2 { get; set; }

    }
    public class Fifa
   {

        public List<Match> match = new List<Match>();
        public List<Team> team = new List<Team>();

        public Fifa()
        {
            GetMatches();
            GetTeams();
        }
        public void GetMatches()
        {
            string strMatch = new WebClient().DownloadString("http://jaibreyonlourens.nl/Project-Fifa-PHP/API/readmatch.php?key=Gr03n3Cactus");
             match = JsonConvert.DeserializeObject<List<Match>>(strMatch);
        }

        public void GetTeams()
        {
            string strTeams = new WebClient().DownloadString("http://jaibreyonlourens.nl/Project-Fifa-PHP/API/read.php?key=Gr03n3Cactus");
             team = JsonConvert.DeserializeObject<List<Team>>(strTeams);
        }

    }
}
