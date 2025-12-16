namespace A9_2_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        int[] data;

        private void Cmdgenerieren_Click(object sender, EventArgs e)
        {
            data = new int[10];
            for (int i = 0; i < data.Length; i++) {
                Random ran = new Random();
                int zahlen = ran.Next(1, 100);
                data[i] = zahlen;
            }
            foreach (int i in data)
            {
                TxtData.Text += i + ", ";
            }
        }

        private void CmdCopy_Click(object sender, EventArgs e)
        {
            int[] copy = new int [10];

            for (int i = 0; i < copy.Length; i++)
            {
                copy[i] = data[9-i];
            }
            
            foreach (int i in copy)
            {
                TxtCopy.Text += i + ", ";
            }
        }
    }
}
