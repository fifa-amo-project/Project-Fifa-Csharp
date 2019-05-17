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
    public class Gokker
    {
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool Guyhasbet = false;

        public Gokker(string name, int credits)
        {
            this.Name = name;
            this.Credits = credits;
        }
        public Gokker(string name, int credits, bool hasBet)
        {
            this.Name = name;
            this.Credits = credits;
            this.Guyhasbet = hasBet;
        }
        public void LoadGokker()
        {
            if (File.Exists(@".\InfoGokker.dat"))
            {
                Program.guy = JsonConvert.DeserializeObject<Gokker>(File.ReadAllText(@".\InfoGokker.dat"));
            }
        }

        public void SaveGokker()
        {
            File.WriteAllText(@".\InfoGokker.dat", JsonConvert.SerializeObject(Program.guy));
        }
    }
}
