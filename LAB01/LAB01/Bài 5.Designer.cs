namespace LAB01
{
    partial class Bai_5
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
            groupBox1 = new GroupBox();
            SumS3 = new TextBox();
            FactorialB = new TextBox();
            SumS1 = new TextBox();
            SumS2 = new TextBox();
            FactorialA = new TextBox();
            ValueA = new TextBox();
            ValueB = new TextBox();
            Exit = new Button();
            Delete = new Button();
            Calculate = new Button();
            Nhap_B = new Label();
            Nhap_A = new Label();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(SumS3);
            groupBox1.Controls.Add(FactorialB);
            groupBox1.Controls.Add(SumS1);
            groupBox1.Controls.Add(SumS2);
            groupBox1.Controls.Add(FactorialA);
            groupBox1.Location = new Point(73, 191);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(655, 230);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Kết quả";
            // 
            // SumS3
            // 
            SumS3.Location = new Point(31, 189);
            SumS3.Name = "SumS3";
            SumS3.ReadOnly = true;
            SumS3.Size = new Size(320, 31);
            SumS3.TabIndex = 17;
            // 
            // FactorialB
            // 
            FactorialB.Location = new Point(362, 30);
            FactorialB.Name = "FactorialB";
            FactorialB.ReadOnly = true;
            FactorialB.Size = new Size(287, 31);
            FactorialB.TabIndex = 18;
            // 
            // SumS1
            // 
            SumS1.Location = new Point(31, 80);
            SumS1.Name = "SumS1";
            SumS1.ReadOnly = true;
            SumS1.Size = new Size(320, 31);
            SumS1.TabIndex = 19;
            // 
            // SumS2
            // 
            SumS2.Location = new Point(31, 132);
            SumS2.Name = "SumS2";
            SumS2.ReadOnly = true;
            SumS2.Size = new Size(320, 31);
            SumS2.TabIndex = 20;
            // 
            // FactorialA
            // 
            FactorialA.Location = new Point(31, 30);
            FactorialA.Name = "FactorialA";
            FactorialA.ReadOnly = true;
            FactorialA.Size = new Size(320, 31);
            FactorialA.TabIndex = 21;
            // 
            // ValueA
            // 
            ValueA.Location = new Point(152, 30);
            ValueA.Name = "ValueA";
            ValueA.Size = new Size(211, 31);
            ValueA.TabIndex = 23;
            // 
            // ValueB
            // 
            ValueB.Location = new Point(505, 30);
            ValueB.Name = "ValueB";
            ValueB.Size = new Size(223, 31);
            ValueB.TabIndex = 22;
            // 
            // Exit
            // 
            Exit.Location = new Point(552, 139);
            Exit.Name = "Exit";
            Exit.Size = new Size(124, 34);
            Exit.TabIndex = 21;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(393, 139);
            Delete.Name = "Delete";
            Delete.Size = new Size(126, 34);
            Delete.TabIndex = 20;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Calculate
            // 
            Calculate.Location = new Point(152, 139);
            Calculate.Name = "Calculate";
            Calculate.Size = new Size(211, 34);
            Calculate.TabIndex = 19;
            Calculate.Text = "Tính các giá trị";
            Calculate.UseVisualStyleBackColor = true;
            Calculate.Click += Calculate_Click_1;
            // 
            // Nhap_B
            // 
            Nhap_B.AutoSize = true;
            Nhap_B.Location = new Point(406, 33);
            Nhap_B.Name = "Nhap_B";
            Nhap_B.Size = new Size(75, 25);
            Nhap_B.TabIndex = 18;
            Nhap_B.Text = "Nhập b:";
            // 
            // Nhap_A
            // 
            Nhap_A.AutoSize = true;
            Nhap_A.Location = new Point(73, 36);
            Nhap_A.Name = "Nhap_A";
            Nhap_A.Size = new Size(73, 25);
            Nhap_A.TabIndex = 17;
            Nhap_A.Text = "Nhập a:";
            // 
            // Bai_5
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(ValueA);
            Controls.Add(ValueB);
            Controls.Add(Exit);
            Controls.Add(Delete);
            Controls.Add(Calculate);
            Controls.Add(Nhap_B);
            Controls.Add(Nhap_A);
            Name = "Bai_5";
            Text = "Bài 5: Tính tổng và giai thừa";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox SumS3;
        private TextBox FactorialB;
        private TextBox SumS1;
        private TextBox SumS2;
        private TextBox FactorialA;
        private TextBox ValueA;
        private TextBox ValueB;
        private Button Exit;
        private Button Delete;
        private Button Calculate;
        private Label Nhap_B;
        private Label Nhap_A;
    }
}