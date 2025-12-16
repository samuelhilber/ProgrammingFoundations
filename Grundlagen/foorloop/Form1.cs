using System.Diagnostics;

namespace foorloop
{
    public partial class Form1 : Form
    {
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CndStart_Click(object sender, EventArgs e)
        {
            for
                (counter = 1; counter <= 5; counter++)
                {
                    log(counter);
            }
        }

        private void log(string message)
        {
            Debug.WriteLine(message);
        }
        private void log(int nummer)
        {
            log(nummer.ToString()); 
        }
        private void TmrCounter_Tick(object sender, EventArgs e)
        {
        }
    }
}
