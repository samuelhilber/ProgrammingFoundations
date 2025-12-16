namespace Test01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CmdStart = new Button();
            CmdWhileLoop = new Button();
            CmdDoWhile = new Button();
            TxtAusgabe = new TextBox();
            CmdFehler = new Button();
            TxtNummerEins = new TextBox();
            TxtNummerZwei = new TextBox();
            SuspendLayout();
            // 
            // CmdStart
            // 
            CmdStart.Location = new Point(12, 12);
            CmdStart.Name = "CmdStart";
            CmdStart.Size = new Size(182, 29);
            CmdStart.TabIndex = 0;
            CmdStart.Text = "foor Loop";
            CmdStart.UseVisualStyleBackColor = true;
            CmdStart.Click += CmdStart_Click;
            // 
            // CmdWhileLoop
            // 
            CmdWhileLoop.Location = new Point(200, 12);
            CmdWhileLoop.Name = "CmdWhileLoop";
            CmdWhileLoop.Size = new Size(182, 29);
            CmdWhileLoop.TabIndex = 1;
            CmdWhileLoop.Text = "While - Loop";
            CmdWhileLoop.UseVisualStyleBackColor = true;
            CmdWhileLoop.Click += CmdWhileLoop_Click;
            // 
            // CmdDoWhile
            // 
            CmdDoWhile.Location = new Point(388, 12);
            CmdDoWhile.Name = "CmdDoWhile";
            CmdDoWhile.Size = new Size(182, 29);
            CmdDoWhile.TabIndex = 2;
            CmdDoWhile.Text = "Do-While-Loop";
            CmdDoWhile.UseVisualStyleBackColor = true;
            CmdDoWhile.Click += CmdDoWhile_Click;
            // 
            // TxtAusgabe
            // 
            TxtAusgabe.Location = new Point(12, 47);
            TxtAusgabe.Multiline = true;
            TxtAusgabe.Name = "TxtAusgabe";
            TxtAusgabe.Size = new Size(558, 255);
            TxtAusgabe.TabIndex = 3;
            // 
            // CmdFehler
            // 
            CmdFehler.Location = new Point(576, 47);
            CmdFehler.Name = "CmdFehler";
            CmdFehler.Size = new Size(133, 255);
            CmdFehler.TabIndex = 4;
            CmdFehler.Text = "Fehlergenerator: Es wird Feld 1 durch Feld 2 divitiert";
            CmdFehler.UseVisualStyleBackColor = true;
            CmdFehler.Click += CmdFehler_Click;
            // 
            // TxtNummerEins
            // 
            TxtNummerEins.Location = new Point(576, 308);
            TxtNummerEins.Name = "TxtNummerEins";
            TxtNummerEins.Size = new Size(125, 27);
            TxtNummerEins.TabIndex = 5;
            // 
            // TxtNummerZwei
            // 
            TxtNummerZwei.Location = new Point(576, 341);
            TxtNummerZwei.Name = "TxtNummerZwei";
            TxtNummerZwei.Size = new Size(125, 27);
            TxtNummerZwei.TabIndex = 6;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtNummerZwei);
            Controls.Add(TxtNummerEins);
            Controls.Add(CmdFehler);
            Controls.Add(TxtAusgabe);
            Controls.Add(CmdDoWhile);
            Controls.Add(CmdWhileLoop);
            Controls.Add(CmdStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdStart;
        private Button CmdWhileLoop;
        private Button CmdDoWhile;
        private TextBox TxtAusgabe;
        private Button CmdFehler;
        private TextBox TxtNummerEins;
        private TextBox TxtNummerZwei;
    }
}
