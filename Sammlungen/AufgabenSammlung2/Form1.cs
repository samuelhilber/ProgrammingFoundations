namespace AufgabenSammlung2
{
    public partial class TxtOutput : Form
    {
        public TxtOutput()
        {
            InitializeComponent();

        }

        int[] zahlen;
        int aufrufe = 0;

        private void CmdGenerieren_Click(object sender, EventArgs e)
        {
            try
            {
                zahlen = new int[Convert.ToInt32(TxtSize.Text)];
                for (int i = 0; i < zahlen.Length; i++)
                {
                    Random ran = new Random();
                    int zufall = ran.Next(1, 1000);
                    zahlen[i] = zufall;

                }
            }

            catch (FormatException)
            {
                MessageBox.Show("Es müssen Zahlen verwendet werden im Feld Gewünschte Grösse!");
            }
        }


        private void CmdRead_Click(object sender, EventArgs e)
        {
            try
            {
                aufrufe++;
                int gefragtezahl = Convert.ToInt32(TxtPosition.Text);
                TxtIndex.Text = zahlen[gefragtezahl-1].ToString();
                TxtOutputFinal.Text += aufrufe + ". " + "Zugriff auf Position: " + TxtPosition.Text + " Wert: " + TxtIndex.Text + "\r\n";
            }

            catch (FormatException)
            {
                MessageBox.Show("Alle felder Müssen mit Zahlen bestückt sein");
            }


        }

        private void LblEingane1_Click(object sender, EventArgs e)
        {

        }
    }
}
