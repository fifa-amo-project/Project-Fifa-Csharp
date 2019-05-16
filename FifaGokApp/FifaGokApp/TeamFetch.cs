using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FifaGokApp
{
    public class Record
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

        public Record(string teamName)
        {
            TeamName = teamName;
        }
    }
    /* class TeamFetch
     {


        /* public class RootObject
         {
             [JsonProperty("records")]
             public List<Record> records { get; set; }
         }


     }*/
}
