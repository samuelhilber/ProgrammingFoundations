using System;
using System.Diagnostics;

namespace Methoden
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void log(string message)
        {
            Debug.WriteLine(message);
        }
        private void log(int nummer)
        {
            log(nummer.ToString());
        }
        private void CmdAction_Click(object sender, EventArgs e)
        {
            int erstezahl = 8;
            int zweitezahl = 10;
            log("Die groessere Zahl ist " + bestimmeMax(erstezahl, zweitezahl));
        }
        private int bestimmeMax(int zahl1, int zahl2)
        {
            int max = zahl2;
            if (zahl1 > zahl2)
            {
                max = zahl1;
            }
            return max;
        }
        private int bestimmeMax(int zahl1, int zahl2, int zahl3) 
        {
            //noch implementieren
        }
        private int bestimmeMax(int zahl1, int zahl2, int zahl3, int zahl4)
        {
            //noch implementieren
        }
    }
}
