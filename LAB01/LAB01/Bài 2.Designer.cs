namespace LAB01
{
    partial class Bai_2
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
            SoNhoNhat = new TextBox();
            SoLonNhat = new TextBox();
            Max_Num = new Label();
            Min_Num = new Label();
            NhapNo3 = new TextBox();
            NhapNo2 = new TextBox();
            NhapNo1 = new TextBox();
            SoThuNhat = new Label();
            SoThuBa = new Label();
            SoThuHai = new Label();
            Delete = new Button();
            Checking = new Button();
            Exit = new Button();
            SuspendLayout();
            // 
            // SoNhoNhat
            // 
            SoNhoNhat.Location = new Point(549, 274);
            SoNhoNhat.Name = "SoNhoNhat";
            SoNhoNhat.ReadOnly = true;
            SoNhoNhat.Size = new Size(150, 31);
            SoNhoNhat.TabIndex = 25;
            // 
            // SoLonNhat
            // 
            SoLonNhat.Location = new Point(237, 274);
            SoLonNhat.Name = "SoLonNhat";
            SoLonNhat.ReadOnly = true;
            SoLonNhat.Size = new Size(150, 31);
            SoLonNhat.TabIndex = 24;
            // 
            // Max_Num
            // 
            Max_Num.AutoSize = true;
            Max_Num.Location = new Point(111, 280);
            Max_Num.Name = "Max_Num";
            Max_Num.Size = new Size(103, 25);
            Max_Num.TabIndex = 23;
            Max_Num.Text = "Số lớn nhất";
            // 
            // Min_Num
            // 
            Min_Num.AutoSize = true;
            Min_Num.Location = new Point(409, 280);
            Min_Num.Name = "Min_Num";
            Min_Num.Size = new Size(109, 25);
            Min_Num.TabIndex = 22;
            Min_Num.Text = "Số nhỏ nhất";
            // 
            // NhapNo3
            // 
            NhapNo3.Location = new Point(646, 81);
            NhapNo3.Name = "NhapNo3";
            NhapNo3.Size = new Size(150, 31);
            NhapNo3.TabIndex = 21;
            // 
            // NhapNo2
            // 
            NhapNo2.Location = new Point(393, 81);
            NhapNo2.Name = "NhapNo2";
            NhapNo2.Size = new Size(150, 31);
            NhapNo2.TabIndex = 20;
            // 
            // NhapNo1
            // 
            NhapNo1.Location = new Point(126, 81);
            NhapNo1.Name = "NhapNo1";
            NhapNo1.Size = new Size(150, 31);
            NhapNo1.TabIndex = 19;
            // 
            // SoThuNhat
            // 
            SoThuNhat.AutoSize = true;
            SoThuNhat.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            SoThuNhat.Location = new Point(15, 84);
            SoThuNhat.Name = "SoThuNhat";
            SoThuNhat.Size = new Size(105, 25);
            SoThuNhat.TabIndex = 18;
            SoThuNhat.Text = "Số thứ nhất";
            // 
            // SoThuBa
            // 
            SoThuBa.AutoSize = true;
            SoThuBa.Location = new Point(549, 87);
            SoThuBa.Name = "SoThuBa";
            SoThuBa.Size = new Size(90, 25);
            SoThuBa.TabIndex = 17;
            SoThuBa.Text = "Số thứ ba";
            // 
            // SoThuHai
            // 
            SoThuHai.AutoSize = true;
            SoThuHai.Location = new Point(282, 87);
            SoThuHai.Name = "SoThuHai";
            SoThuHai.Size = new Size(93, 25);
            SoThuHai.TabIndex = 16;
            SoThuHai.Text = "Số thứ hai";
            // 
            // Delete
            // 
            Delete.Location = new Point(393, 185);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 34);
            Delete.TabIndex = 15;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Checking
            // 
            Checking.Location = new Point(126, 185);
            Checking.Name = "Checking";
            Checking.Size = new Size(112, 34);
            Checking.TabIndex = 14;
            Checking.Text = "Tìm";
            Checking.UseVisualStyleBackColor = true;
            Checking.Click += Checking_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(646, 185);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 34);
            Exit.TabIndex = 13;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Bai_2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SoNhoNhat);
            Controls.Add(SoLonNhat);
            Controls.Add(Max_Num);
            Controls.Add(Min_Num);
            Controls.Add(NhapNo3);
            Controls.Add(NhapNo2);
            Controls.Add(NhapNo1);
            Controls.Add(SoThuNhat);
            Controls.Add(SoThuBa);
            Controls.Add(SoThuHai);
            Controls.Add(Delete);
            Controls.Add(Checking);
            Controls.Add(Exit);
            Name = "Bai_2";
            Text = "Bài 2: Tìm max, min";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SoNhoNhat;
        private TextBox SoLonNhat;
        private Label Max_Num;
        private Label Min_Num;
        private TextBox NhapNo3;
        private TextBox NhapNo2;
        private TextBox NhapNo1;
        private Label SoThuNhat;
        private Label SoThuBa;
        private Label SoThuHai;
        private Button Delete;
        private Button Checking;
        private Button Exit;
    }
}