namespace repetition02
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
            TxtOutput = new TextBox();
            CmdZahl = new Button();
            LblZahl = new Label();
            TxtPreview = new TextBox();
            SuspendLayout();
            // 
            // CmdStart
            // 
            CmdStart.Location = new Point(625, 12);
            CmdStart.Name = "CmdStart";
            CmdStart.Size = new Size(148, 32);
            CmdStart.TabIndex = 0;
            CmdStart.Text = "Send";
            CmdStart.UseVisualStyleBackColor = true;
            CmdStart.Click += CmdStart_Click;
            // 
            // TxtOutput
            // 
            TxtOutput.Location = new Point(3, 50);
            TxtOutput.Multiline = true;
            TxtOutput.Name = "TxtOutput";
            TxtOutput.ReadOnly = true;
            TxtOutput.Size = new Size(770, 379);
            TxtOutput.TabIndex = 1;
            // 
            // CmdZahl
            // 
            CmdZahl.Location = new Point(396, 14);
            CmdZahl.Name = "CmdZahl";
            CmdZahl.Size = new Size(223, 29);
            CmdZahl.TabIndex = 2;
            CmdZahl.Text = "Generiere Zufallszahll";
            CmdZahl.UseVisualStyleBackColor = true;
            CmdZahl.Click += CmdZahl_Click;
            // 
            // LblZahl
            // 
            LblZahl.AutoSize = true;
            LblZahl.Location = new Point(3, 18);
            LblZahl.Name = "LblZahl";
            LblZahl.Size = new Size(41, 20);
            LblZahl.TabIndex = 3;
            LblZahl.Text = "Zahl:";
            LblZahl.Click += label1_Click;
            // 
            // TxtPreview
            // 
            TxtPreview.BorderStyle = BorderStyle.None;
            TxtPreview.Location = new Point(50, 14);
            TxtPreview.Name = "TxtPreview";
            TxtPreview.ReadOnly = true;
            TxtPreview.Size = new Size(125, 20);
            TxtPreview.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(TxtPreview);
            Controls.Add(LblZahl);
            Controls.Add(CmdZahl);
            Controls.Add(TxtOutput);
            Controls.Add(CmdStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CmdStart;
        private TextBox TxtOutput;
        private Button CmdZahl;
        private Label LblZahl;
        private TextBox TxtPreview;
    }
}
