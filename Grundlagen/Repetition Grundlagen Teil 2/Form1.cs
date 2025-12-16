namespace repetition02
{
    public partial class Form1 : Form
    {
        int zwischenspeicher = 8;
        int ausgabe = 0;
        public Form1()
        {
            InitializeComponent();
        }
        private int generateNumber()
        {
            Random ran = new Random();
            int zufallszahl = ran.Next(10, 1000);
            return zufallszahl;
        }

        private void CmdStart_Click(object sender, EventArgs e)
        {
            while (zwischenspeicher > 1)
            {
                ausgabe += zwischenspeicher / 2;
                TxtOutput.Text = ausgabe.ToString();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void CmdZahl_Click(object sender, EventArgs e)
        {
            Convert.ToString(zwischenspeicher += generateNumber());
            TxtPreview.Text = string.Empty;
            TxtPreview.Text += zwischenspeicher;
        }
    }
}
