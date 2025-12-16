using System.Diagnostics;

namespace Interface_Zoo_uebung
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

        private void CmdStart_Click(object sender, EventArgs e)
        {
            IZooTier Tiger = new Tiger();
            Tiger.Name = "Talon";

            infoTafel(Tiger);

        }

        private void infoTafel (IZooTier tier)
        {
            log("Name: " + tier.Name);
            log("Lebensraum: " + tier.Lebensraum());
            log("Nahrung: " + tier.Nahrung());
            log("Feinde: " + tier.Feinde());
        }
    }
}
