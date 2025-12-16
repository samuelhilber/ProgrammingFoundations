namespace reppetitionaufgabe1
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
            components = new System.ComponentModel.Container();
            LblZeitinSekunden = new Label();
            LblAnzeige = new Label();
            ChkGeradeZahlen = new CheckBox();
            CmdStart = new Button();
            TmrStopUhr = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LblZeitinSekunden
            // 
            LblZeitinSekunden.AutoSize = true;
            LblZeitinSekunden.Location = new Point(49, 28);
            LblZeitinSekunden.Name = "LblZeitinSekunden";
            LblZeitinSekunden.Size = new Size(119, 20);
            LblZeitinSekunden.TabIndex = 0;
            LblZeitinSekunden.Text = "Zeit in Sekunden";
            // 
            // LblAnzeige
            // 
            LblAnzeige.AutoSize = true;
            LblAnzeige.Location = new Point(79, 85);
            LblAnzeige.Name = "LblAnzeige";
            LblAnzeige.Size = new Size(17, 20);
            LblAnzeige.TabIndex = 1;
            LblAnzeige.Text = "0";
            // 
            // ChkGeradeZahlen
            // 
            ChkGeradeZahlen.AutoSize = true;
            ChkGeradeZahlen.Location = new Point(196, 81);
            ChkGeradeZahlen.Name = "ChkGeradeZahlen";
            ChkGeradeZahlen.Size = new Size(153, 24);
            ChkGeradeZahlen.TabIndex = 2;
            ChkGeradeZahlen.Text = "nur Gerade Zahlen";
            ChkGeradeZahlen.UseVisualStyleBackColor = true;
            // 
            // CmdStart
            // 
            CmdStart.AllowDrop = true;
            CmdStart.Location = new Point(49, 130);
            CmdStart.Name = "CmdStart";
            CmdStart.Size = new Size(94, 29);
            CmdStart.TabIndex = 3;
            CmdStart.Text = "Start";
            CmdStart.TextImageRelation = TextImageRelation.ImageAboveText;
            CmdStart.UseVisualStyleBackColor = true;
            CmdStart.Click += CmdStart_Click;
            // 
            // TmrStopUhr
            // 
            TmrStopUhr.Tick += TmrStopUhr_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 238);
            Controls.Add(CmdStart);
            Controls.Add(ChkGeradeZahlen);
            Controls.Add(LblAnzeige);
            Controls.Add(LblZeitinSekunden);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblZeitinSekunden;
        private Label LblAnzeige;
        private CheckBox ChkGeradeZahlen;
        private Button CmdStart;
        private System.Windows.Forms.Timer TmrStopUhr;
    }
}
