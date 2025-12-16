namespace reppetitionaufgabe1
{
    public partial class Form1 : Form
    {
        int sekunden = 0;
        bool istgelciked = false;
        public Form1()
        {
            InitializeComponent();
            TmrStopUhr.Interval = 1000; // setzden den Timer auf 1 Tick pro Sekunde
            
        }

        private void TmrStopUhr_Tick(object sender, EventArgs e)
        {
            sekunden++;

            if (ChkGeradeZahlen.Checked)
            {
                if (sekunden % 2 == 0)
                {
                    LblAnzeige.Text = sekunden.ToString();
                }
            }
            else
            {
                LblAnzeige.Text = sekunden.ToString();
            }

        }
        private void CmdStart_Click(object sender, EventArgs e)
        {
            istgelciked = !istgelciked;
            if (istgelciked)
            {
                sekunden = 0;
                LblAnzeige.Text = "0";
                CmdStart.Text = "Stop";
                TmrStopUhr.Start();
            }
            else
            {
                CmdStart.Text = "Start";
                TmrStopUhr.Stop();
            }
            
            
            
            
        }
    }
}
