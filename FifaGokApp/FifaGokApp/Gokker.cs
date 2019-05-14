using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifaGokApp
{
    class Gokker
    {
        public string Name { get; set; }
        public int Credits { get; set; }
        public bool Guyhasbet = false;

        public Gokker(string name, int credits)
        {
            this.Name = name;
            this.Credits = credits;
        }
    }
}
