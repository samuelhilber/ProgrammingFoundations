using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_Zoo_uebung
{
    internal interface IZooTier
    {
        string Name { get; set; }
        string Lebensraum();
        string Nahrung();
        string Feinde();
    }
}
