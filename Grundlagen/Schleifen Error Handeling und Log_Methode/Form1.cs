using System;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

namespace Test01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void log(int nummer)
        {
            log(nummer.ToString());
        }

        private void log(string nachricht)
        {
            Debug.WriteLine(nachricht);
        }
        private int generateNumber()
        {
            Random ran = new Random();
            int zufallszahl = ran.Next(10, 1000);
            return zufallszahl;
        }
        private void CmdStart_Click(object sender, EventArgs e)
        {
            log("- for schleife -");
            for (int I = 1; I <= 5; I++)
            {
                log(generateNumber());
                TxtAusgabe.Text = generateNumber().ToString();
            }
            log("- for schleife -");
        }

        private void CmdWhileLoop_Click(object sender, EventArgs e)
        {
            int counter = 1;
            log("- while schleife -");
            while (counter <= 5)
            {
                counter++;
                log(generateNumber()); // fehler beim verwenden ACHTUNG () ist notwendig da die Methode aufgerufen wird
                TxtAusgabe.Text = generateNumber().ToString();

            }
            log("- while schleife -");
        }

        private void CmdDoWhile_Click(object sender, EventArgs e)
        {
            TxtAusgabe.Text = "";
            int counter = 1; // setzt den wert wieder auf 0
            log("- do / while schleife -"); // nur damit im Log deklariert wird welche Schleife verwendet wurde

            do
            {
                log(generateNumber());
                TxtAusgabe.Text += generateNumber() + "\r\n";
                counter++;
            }
            while (counter <= 5);
            log("- do / while schleife -");
        }

        private void CmdFehler_Click(object sender, EventArgs e)
        {
            try
            {
                int ZahlEins = 9;
                int Zahlzwei = 1;
                ZahlEins = Convert.ToInt32(TxtNummerEins.Text);
                Zahlzwei = Convert.ToInt32(TxtNummerZwei.Text);
                int Resultat = ZahlEins / Zahlzwei;
                TxtAusgabe.Text = ("Resultat: " + Resultat);
            }
            catch (DivideByZeroException ex)
            {
                MessageBox.Show("Es kann nicht durch 0 geteilt werden");
                log(ex.Message);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Es müssen Zahlen verwendet werden!");
                log(ex.Message);
            }
            catch (OverflowException ex)
            {
                MessageBox.Show("Es wurden zu hoche Zahlen werdendet");
                log(ex.Message);
            }

        }
    }
}
