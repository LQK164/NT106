namespace LAB01
{
    partial class Overall
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
            bai04 = new Button();
            bai05 = new Button();
            bai03 = new Button();
            bai02 = new Button();
            Bai01 = new Button();
            SuspendLayout();
            // 
            // bai04
            // 
            bai04.Location = new Point(482, 60);
            bai04.Name = "bai04";
            bai04.Size = new Size(225, 72);
            bai04.TabIndex = 9;
            bai04.Text = "Bài 4";
            bai04.UseVisualStyleBackColor = true;
            bai04.Click += bai04_Click;
            // 
            // bai05
            // 
            bai05.Location = new Point(482, 186);
            bai05.Name = "bai05";
            bai05.Size = new Size(225, 72);
            bai05.TabIndex = 8;
            bai05.Text = "Bài 5";
            bai05.UseVisualStyleBackColor = true;
            bai05.Click += bai05_Click;
            // 
            // bai03
            // 
            bai03.Location = new Point(124, 312);
            bai03.Name = "bai03";
            bai03.Size = new Size(225, 72);
            bai03.TabIndex = 7;
            bai03.Text = "Bài 3";
            bai03.UseVisualStyleBackColor = true;
            bai03.Click += bai03_Click;
            // 
            // bai02
            // 
            bai02.Location = new Point(124, 186);
            bai02.Name = "bai02";
            bai02.Size = new Size(225, 72);
            bai02.TabIndex = 6;
            bai02.Text = "Bài 2";
            bai02.UseVisualStyleBackColor = true;
            bai02.Click += bai02_Click;
            // 
            // Bai01
            // 
            Bai01.Location = new Point(124, 60);
            Bai01.Name = "Bai01";
            Bai01.Size = new Size(225, 72);
            Bai01.TabIndex = 5;
            Bai01.Text = "Bài 1";
            Bai01.UseVisualStyleBackColor = true;
            Bai01.Click += bai01_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bai04);
            Controls.Add(bai05);
            Controls.Add(bai03);
            Controls.Add(bai02);
            Controls.Add(Bai01);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button bai04;
        private Button bai05;
        private Button bai03;
        private Button bai02;
        private Button Bai01;
    }
}