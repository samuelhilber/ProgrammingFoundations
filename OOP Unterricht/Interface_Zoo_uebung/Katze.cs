using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Zoo_uebung
{
    internal class Tiger : IZooTier
    {
        private string name;
        public string Name
        {
            get { return name; }
            set { name = value != null ? value : "not definiert"; }
        }

        public string Lebensraum()
        {
            return "Der Lebensraum vom " + name + " ist verteilt auf mehrere Kontinente vor allem leben sie in: Indien, Südostasien & Russland";
        }

        public string Nahrung()
        {
            return "Der " + name + " hat eine strikte carnivore diet (wie einige sogenannte Fitness Influencer)";

        }

        public string Feinde()
        {
            return "Die Natürliche feinde des " + name + " sind Mensch, Elefanten, Büffel, Krokodile, Andere Tiger";
        }

    }
}
