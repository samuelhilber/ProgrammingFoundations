namespace AufgabenSammlung2
{
    partial class TxtOutput
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
            LblEingane1 = new Label();
            LblEingabe2 = new Label();
            LblEingabe3 = new Label();
            CmdGenerieren = new Button();
            CmdRead = new Button();
            LblOutpout = new Label();
            TxtSize = new TextBox();
            TxtPosition = new TextBox();
            TxtIndex = new TextBox();
            TxtOutputFinal = new TextBox();
            SuspendLayout();
            // 
            // LblEingane1
            // 
            LblEingane1.AutoSize = true;
            LblEingane1.Location = new Point(12, 9);
            LblEingane1.Name = "LblEingane1";
            LblEingane1.Size = new Size(139, 20);
            LblEingane1.TabIndex = 0;
            LblEingane1.Text = "Gewünschte Grösse:";
            LblEingane1.Click += LblEingane1_Click;
            // 
            // LblEingabe2
            // 
            LblEingabe2.AutoSize = true;
            LblEingabe2.Location = new Point(12, 87);
            LblEingabe2.Name = "LblEingabe2";
            LblEingabe2.Size = new Size(115, 20);
            LblEingabe2.TabIndex = 1;
            LblEingabe2.Text = "Position wählen:";
            // 
            // LblEingabe3
            // 
            LblEingabe3.AutoSize = true;
            LblEingabe3.Location = new Point(331, 87);
            LblEingabe3.Name = "LblEingabe3";
            LblEingabe3.Size = new Size(133, 20);
            LblEingabe3.TabIndex = 2;
            LblEingabe3.Text = "Gespeicherte Wert:";
            // 
            // CmdGenerieren
            // 
            CmdGenerieren.Location = new Point(454, 6);
            CmdGenerieren.Name = "CmdGenerieren";
            CmdGenerieren.Size = new Size(133, 29);
            CmdGenerieren.TabIndex = 3;
            CmdGenerieren.Text = "Daten generieren";
            CmdGenerieren.UseVisualStyleBackColor = true;
            CmdGenerieren.Click += CmdGenerieren_Click;
            // 
            // CmdRead
            // 
            CmdRead.Location = new Point(12, 123);
            CmdRead.Name = "CmdRead";
            CmdRead.Size = new Size(575, 29);
            CmdRead.TabIndex = 4;
            CmdRead.Text = "Wert der gewünschten Position auslesen";
            CmdRead.UseVisualStyleBackColor = true;
            CmdRead.Click += CmdRead_Click;
            // 
            // LblOutpout
            // 
            LblOutpout.AutoSize = true;
            LblOutpout.Location = new Point(12, 190);
            LblOutpout.Name = "LblOutpout";
            LblOutpout.Size = new Size(131, 20);
            LblOutpout.TabIndex = 5;
            LblOutpout.Text = "Erfolgte Abfragen:";
            // 
            // TxtSize
            // 
            TxtSize.Location = new Point(157, 6);
            TxtSize.Name = "TxtSize";
            TxtSize.Size = new Size(99, 27);
            TxtSize.TabIndex = 6;
            // 
            // TxtPosition
            // 
            TxtPosition.Location = new Point(157, 80);
            TxtPosition.Name = "TxtPosition";
            TxtPosition.Size = new Size(99, 27);
            TxtPosition.TabIndex = 7;
            // 
            // TxtIndex
            // 
            TxtIndex.Location = new Point(470, 84);
            TxtIndex.Name = "TxtIndex";
            TxtIndex.ReadOnly = true;
            TxtIndex.Size = new Size(117, 27);
            TxtIndex.TabIndex = 8;
            // 
            // TxtOutputFinal
            // 
            TxtOutputFinal.Location = new Point(157, 190);
            TxtOutputFinal.Multiline = true;
            TxtOutputFinal.Name = "TxtOutputFinal";
            TxtOutputFinal.Size = new Size(430, 228);
            TxtOutputFinal.TabIndex = 9;
            // 
            // TxtOutput
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(616, 450);
            Controls.Add(TxtOutputFinal);
            Controls.Add(TxtIndex);
            Controls.Add(TxtPosition);
            Controls.Add(TxtSize);
            Controls.Add(LblOutpout);
            Controls.Add(CmdRead);
            Controls.Add(CmdGenerieren);
            Controls.Add(LblEingabe3);
            Controls.Add(LblEingabe2);
            Controls.Add(LblEingane1);
            Name = "TxtOutput";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblEingane1;
        private Label LblEingabe2;
        private Label LblEingabe3;
        private Button CmdGenerieren;
        private Button CmdRead;
        private Label LblOutpout;
        private TextBox TxtSize;
        private TextBox TxtPosition;
        private TextBox TxtIndex;
        private TextBox TxtOutputFinal;
    }
}
