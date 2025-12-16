namespace OOP
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
            CmdNeu = new Button();
            SuspendLayout();
            // 
            // CmdNeu
            // 
            CmdNeu.Location = new Point(12, 12);
            CmdNeu.Name = "CmdNeu";
            CmdNeu.Size = new Size(94, 29);
            CmdNeu.TabIndex = 0;
            CmdNeu.Text = "Neu";
            CmdNeu.UseVisualStyleBackColor = true;
            CmdNeu.Click += CmdNeu_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(316, 156);
            Controls.Add(CmdNeu);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CmdNeu;
    }
}
