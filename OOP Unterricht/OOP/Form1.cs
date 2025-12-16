namespace OOP

{
    using System.Diagnostics;
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

        private void CmdNeu_Click(object sender, EventArgs e)
        {
            /*      
             *      Es wurde kommentiert das diese nicht mehr Funktioniert weil Konstruktoren verwendet wurden
             *      
            Tier meinTier = new Tier();
            meinTier.Name = "Dobby";
            meinTier.Alter = 3;

            Tier bagira = new Tier();
            bagira.Name = "Bagira";
            bagira.Alter = 20;

            log("Mein neues Tier heisst: " + meinTier.Name + " und er ist " + bagira.Alter + " Jahre alt!");
            log("Mein neues Tier heisst: " + bagira.Name + " und er ist " + meinTier.Alter + " Jahre alt!");  
            
            */

            Tier Katze = new Tier("Bagira",20);
            Tier Hund = new Tier("Dobby", 3);

            log(Katze.Ausgabe());
            log(Hund.Ausgabe());

        }
    }
}
