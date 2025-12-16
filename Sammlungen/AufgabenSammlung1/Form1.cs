using System.Diagnostics;

namespace AufgabenSammlung
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CmdStart1_Click(object sender, EventArgs e)
        {
            int[] zahlen = new int[20];
            for (int i = 0; i < zahlen.Length; i++)
            {
                Random ran = new Random();
                int zufall = ran.Next(0, 100);
                zahlen[i] = zufall;
            }

            for (int x = 0; x < zahlen.Length; x++)
            { Debug.WriteLine("Das ist Index " + x + ": " + zahlen[x]);
                TxtAusgabe1.Text += Convert.ToString(zahlen[x]) + "\r\n";

            }
        }
    }
}
