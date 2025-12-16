namespace Interface_Zoo_uebung
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
            SuspendLayout();
            // 
            // CmdStart
            // 
            CmdStart.Location = new Point(12, 12);
            CmdStart.Name = "CmdStart";
            CmdStart.Size = new Size(94, 29);
            CmdStart.TabIndex = 0;
            CmdStart.Text = "Start";
            CmdStart.UseVisualStyleBackColor = true;
            CmdStart.Click += CmdStart_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(443, 155);
            Controls.Add(CmdStart);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdStart;
    }
}
