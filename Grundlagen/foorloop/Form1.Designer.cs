namespace foorloop
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
            LblOutput = new Label();
            CndStart = new Button();
            TmrCounter = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // LblOutput
            // 
            LblOutput.AutoSize = true;
            LblOutput.Location = new Point(167, 84);
            LblOutput.Name = "LblOutput";
            LblOutput.Size = new Size(17, 20);
            LblOutput.TabIndex = 0;
            LblOutput.Text = "0";
            // 
            // CndStart
            // 
            CndStart.Location = new Point(167, 130);
            CndStart.Name = "CndStart";
            CndStart.Size = new Size(94, 29);
            CndStart.TabIndex = 1;
            CndStart.Text = "Start";
            CndStart.UseVisualStyleBackColor = true;
            CndStart.Click += CndStart_Click;
            // 
            // TmrCounter
            // 
            TmrCounter.Interval = 1000;
            TmrCounter.Tick += TmrCounter_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CndStart);
            Controls.Add(LblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LblOutput;
        private Button CndStart;
        private System.Windows.Forms.Timer TmrCounter;
    }
}
