namespace MB01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lblGelb.Text = "gelb ausgewählt";
            lblGelb.BackColor = Color.Yellow;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cmdRot_Click(object sender, EventArgs e)
        {
            lblRot.Text = "rot ausgewählt";
            lblRot.BackColor = Color.Red;
        }

        private void cmdBlau_Click(object sender, EventArgs e)
        {
            LblBlau.Text = "blau ausgewählt";
            LblBlau.BackColor = Color.Blue;
        }

        private void cmdgruen_Click(object sender, EventArgs e)
        {
            LblGruen.Text = "grün ausgewählt";
            LblGruen.BackColor = Color.Green;
        }

        private void lblRot_Click(object sender, EventArgs e)
        {

        }

        private void LblBlau_Click(object sender, EventArgs e)
        {

        }

        private void LblGruen_Click(object sender, EventArgs e)
        {

        }
    }
}
