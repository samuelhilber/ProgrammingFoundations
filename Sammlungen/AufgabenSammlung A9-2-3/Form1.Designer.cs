namespace A9_2_3
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
            Cmdgenerieren = new Button();
            TxtData = new TextBox();
            CmdCopy = new Button();
            TxtCopy = new TextBox();
            SuspendLayout();
            // 
            // Cmdgenerieren
            // 
            Cmdgenerieren.Location = new Point(12, 12);
            Cmdgenerieren.Name = "Cmdgenerieren";
            Cmdgenerieren.Size = new Size(776, 29);
            Cmdgenerieren.TabIndex = 0;
            Cmdgenerieren.Text = "Generiere Zahlen für Array data";
            Cmdgenerieren.UseVisualStyleBackColor = true;
            Cmdgenerieren.Click += Cmdgenerieren_Click;
            // 
            // TxtData
            // 
            TxtData.Location = new Point(12, 47);
            TxtData.Name = "TxtData";
            TxtData.ReadOnly = true;
            TxtData.Size = new Size(776, 27);
            TxtData.TabIndex = 1;
            // 
            // CmdCopy
            // 
            CmdCopy.Location = new Point(12, 80);
            CmdCopy.Name = "CmdCopy";
            CmdCopy.Size = new Size(776, 29);
            CmdCopy.TabIndex = 2;
            CmdCopy.Text = "Kopieren Zahlen in Array dataCopy";
            CmdCopy.UseVisualStyleBackColor = true;
            CmdCopy.Click += CmdCopy_Click;
            // 
            // TxtCopy
            // 
            TxtCopy.Location = new Point(12, 115);
            TxtCopy.Name = "TxtCopy";
            TxtCopy.ReadOnly = true;
            TxtCopy.Size = new Size(776, 27);
            TxtCopy.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 179);
            Controls.Add(TxtCopy);
            Controls.Add(CmdCopy);
            Controls.Add(TxtData);
            Controls.Add(Cmdgenerieren);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cmdgenerieren;
        private TextBox TxtData;
        private Button CmdCopy;
        private TextBox TxtCopy;
    }
}
