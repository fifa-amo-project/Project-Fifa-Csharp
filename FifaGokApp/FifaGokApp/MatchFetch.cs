using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace FifaGokApp
{
    class MatchFetch
    {
       
            [JsonProperty("id")]
            public int id { get; set; }
            [JsonProperty("team1")]
            public string team1 { get; set; }

            [JsonProperty("team2")] 
             public string team2 { get; set;}

            [JsonProperty("uitslag")]
            public string uitslag { get; set; }
        
       

    }
}
