namespace MB01
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
            cmdGelb = new Button();
            cmdRot = new Button();
            cmdBlau = new Button();
            cmdgruen = new Button();
            lblGelb = new Label();
            lblRot = new Label();
            LblBlau = new Label();
            LblGruen = new Label();
            SuspendLayout();
            // 
            // cmdGelb
            // 
            cmdGelb.Location = new Point(111, 68);
            cmdGelb.Name = "cmdGelb";
            cmdGelb.Size = new Size(94, 29);
            cmdGelb.TabIndex = 0;
            cmdGelb.Text = "gelb";
            cmdGelb.UseVisualStyleBackColor = true;
            cmdGelb.Click += button1_Click;
            // 
            // cmdRot
            // 
            cmdRot.Location = new Point(111, 103);
            cmdRot.Name = "cmdRot";
            cmdRot.Size = new Size(94, 29);
            cmdRot.TabIndex = 1;
            cmdRot.Text = "Rot";
            cmdRot.UseVisualStyleBackColor = true;
            cmdRot.Click += cmdRot_Click;
            // 
            // cmdBlau
            // 
            cmdBlau.Location = new Point(111, 138);
            cmdBlau.Name = "cmdBlau";
            cmdBlau.Size = new Size(94, 29);
            cmdBlau.TabIndex = 2;
            cmdBlau.Text = "blau";
            cmdBlau.UseVisualStyleBackColor = true;
            cmdBlau.Click += cmdBlau_Click;
            // 
            // cmdgruen
            // 
            cmdgruen.Location = new Point(111, 173);
            cmdgruen.Name = "cmdgruen";
            cmdgruen.Size = new Size(94, 29);
            cmdgruen.TabIndex = 3;
            cmdgruen.Text = "Grün";
            cmdgruen.UseVisualStyleBackColor = true;
            cmdgruen.Click += cmdgruen_Click;
            // 
            // lblGelb
            // 
            lblGelb.AutoSize = true;
            lblGelb.Location = new Point(249, 72);
            lblGelb.Name = "lblGelb";
            lblGelb.Size = new Size(92, 20);
            lblGelb.TabIndex = 4;
            lblGelb.Text = "beispiel Text";
            lblGelb.Click += label1_Click;
            // 
            // lblRot
            // 
            lblRot.AutoSize = true;
            lblRot.Location = new Point(249, 107);
            lblRot.Name = "lblRot";
            lblRot.Size = new Size(92, 20);
            lblRot.TabIndex = 5;
            lblRot.Text = "beispiel Text";
            lblRot.Click += lblRot_Click;
            // 
            // LblBlau
            // 
            LblBlau.AutoSize = true;
            LblBlau.Location = new Point(249, 142);
            LblBlau.Name = "LblBlau";
            LblBlau.Size = new Size(92, 20);
            LblBlau.TabIndex = 6;
            LblBlau.Text = "beispiel Text";
            LblBlau.Click += LblBlau_Click;
            // 
            // LblGruen
            // 
            LblGruen.AutoSize = true;
            LblGruen.Location = new Point(249, 177);
            LblGruen.Name = "LblGruen";
            LblGruen.Size = new Size(92, 20);
            LblGruen.TabIndex = 7;
            LblGruen.Text = "beispiel Text";
            LblGruen.Click += LblGruen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(673, 310);
            Controls.Add(LblGruen);
            Controls.Add(LblBlau);
            Controls.Add(lblRot);
            Controls.Add(lblGelb);
            Controls.Add(cmdgruen);
            Controls.Add(cmdBlau);
            Controls.Add(cmdRot);
            Controls.Add(cmdGelb);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cmdGelb;
        private Button cmdRot;
        private Button cmdBlau;
        private Button cmdgruen;
        private Label lblGelb;
        private Label lblRot;
        private Label LblBlau;
        private Label LblGruen;
    }
}
