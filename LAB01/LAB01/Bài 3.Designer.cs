namespace LAB01
{
    partial class Bai_3
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
            label2 = new Label();
            Ket_Qua = new TextBox();
            Exit = new Button();
            Delete = new Button();
            Read = new Button();
            Nhap_Tu_0_Den_9 = new TextBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(204, 316);
            label2.Name = "label2";
            label2.Size = new Size(79, 28);
            label2.TabIndex = 13;
            label2.Text = "Kết quả";
            // 
            // Ket_Qua
            // 
            Ket_Qua.Location = new Point(309, 316);
            Ket_Qua.Name = "Ket_Qua";
            Ket_Qua.ReadOnly = true;
            Ket_Qua.Size = new Size(201, 31);
            Ket_Qua.TabIndex = 12;
            // 
            // Exit
            // 
            Exit.Location = new Point(576, 297);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 34);
            Exit.TabIndex = 11;
            Exit.Text = "Thoát";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Delete
            // 
            Delete.Location = new Point(576, 210);
            Delete.Name = "Delete";
            Delete.Size = new Size(112, 34);
            Delete.TabIndex = 10;
            Delete.Text = "Xóa";
            Delete.UseVisualStyleBackColor = true;
            Delete.Click += Delete_Click;
            // 
            // Read
            // 
            Read.Location = new Point(576, 127);
            Read.Name = "Read";
            Read.Size = new Size(112, 34);
            Read.TabIndex = 9;
            Read.Text = "Đọc";
            Read.UseVisualStyleBackColor = true;
            Read.Click += Read_Click;
            // 
            // Nhap_Tu_0_Den_9
            // 
            Nhap_Tu_0_Den_9.Location = new Point(309, 104);
            Nhap_Tu_0_Den_9.Name = "Nhap_Tu_0_Den_9";
            Nhap_Tu_0_Den_9.Size = new Size(202, 31);
            Nhap_Tu_0_Den_9.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(113, 104);
            label1.Name = "label1";
            label1.Size = new Size(190, 28);
            label1.TabIndex = 7;
            label1.Text = "Nhập số thừ 0 đến 9";
            // 
            // Bai_3
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(Ket_Qua);
            Controls.Add(Exit);
            Controls.Add(Delete);
            Controls.Add(Read);
            Controls.Add(Nhap_Tu_0_Den_9);
            Controls.Add(label1);
            Name = "Bai_3";
            Text = "Bài 3: Đếm từ 0 đến 9";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private TextBox Ket_Qua;
        private Button Exit;
        private Button Delete;
        private Button Read;
        private TextBox Nhap_Tu_0_Den_9;
        private Label label1;
    }
}