namespace LAB01
{
    partial class Bai_1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Calculate = new Button();
            Result = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            SoThuHai = new Label();
            SoThuNhat = new Label();
            SuspendLayout();
            // 
            // Calculate
            // 
            Calculate.Location = new Point(628, 171);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(136, 35);
            Calculate.TabIndex = 13;
            Calculate.Text = "Tính";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click;
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Result.Location = new Point(153, 261);
            Result.Name = "Result";
            Result.Size = new Size(101, 32);
            Result.TabIndex = 12;
            Result.Text = "Kết quả:";
            Result.Click += Result_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(283, 261);
            textBox3.Name = "textBox3";
            textBox3.ReadOnly = true;
            textBox3.Size = new Size(289, 31);
            textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(283, 175);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(289, 31);
            textBox2.TabIndex = 10;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(283, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(289, 31);
            textBox1.TabIndex = 9;
            // 
            // SoThuHai
            // 
            SoThuHai.AutoSize = true;
            SoThuHai.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoThuHai.Location = new Point(119, 172);
            SoThuHai.Name = "SoThuHai";
            SoThuHai.Size = new Size(135, 32);
            SoThuHai.TabIndex = 8;
            SoThuHai.Text = "Số thứ hai: ";
            SoThuHai.Click += SoThuHai_Click;
            // 
            // SoThuNhat
            // 
            SoThuNhat.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SoThuNhat.Location = new Point(110, 80);
            SoThuNhat.Name = "SoThuNhat";
            SoThuNhat.Size = new Size(144, 41);
            SoThuNhat.TabIndex = 7;
            SoThuNhat.Text = "Số thứ nhất:";
            SoThuNhat.Click += SoThuNhat_Click;
            // 
            // Bai_1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Calculate);
            Controls.Add(Result);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(SoThuHai);
            Controls.Add(SoThuNhat);
            Name = "Bai_1";
            Text = "Bài 1: Tính tổng 2 số nguyên";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Calculate;
        private Label Result;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label SoThuHai;
        private Label SoThuNhat;
    }
}