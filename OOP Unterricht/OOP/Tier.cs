using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace OOP
{
    internal class Tier
    {
        private string name;
        private int alter;

        public string Ausgabe()
        {
            return "Mein neues Tier heisst: " + Name + " und er ist " + Alter + " Jahre alt!";
        }

        public string Name
        {
            get { return name; }
            set { name = value != null ? value : "not definiert"; }
        }
        public int Alter
        {
            get { return alter; }
            set { alter = value != 0 ? value : 0; }
        }

        public Tier(string name, int alter)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            Alter = alter;
        }
    }
}
