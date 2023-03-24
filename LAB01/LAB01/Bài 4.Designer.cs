namespace LAB01
{
    partial class Bai_4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Bai_4));
            label1 = new Label();
            Currency = new ComboBox();
            MoneyIsChanged = new TextBox();
            MoneyNeedsToChange = new TextBox();
            SoTienDaDoi = new Label();
            SoTienCanDoi = new Label();
            Exchange = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(160, 281);
            label1.Name = "label1";
            label1.Size = new Size(330, 125);
            label1.TabIndex = 13;
            label1.Text = resources.GetString("label1.Text");
            // 
            // Currency
            // 
            Currency.FormattingEnabled = true;
            Currency.Items.AddRange(new object[] { "USD", "EUR", "GBP", "SGD", "JPY" });
            Currency.Location = new Point(481, 46);
            Currency.Name = "Currency";
            Currency.Size = new Size(182, 33);
            Currency.TabIndex = 12;
            // 
            // MoneyIsChanged
            // 
            MoneyIsChanged.Location = new Point(276, 227);
            MoneyIsChanged.Name = "MoneyIsChanged";
            MoneyIsChanged.ReadOnly = true;
            MoneyIsChanged.Size = new Size(153, 31);
            MoneyIsChanged.TabIndex = 11;
            // 
            // MoneyNeedsToChange
            // 
            MoneyNeedsToChange.Location = new Point(275, 48);
            MoneyNeedsToChange.Name = "MoneyNeedsToChange";
            MoneyNeedsToChange.Size = new Size(153, 31);
            MoneyNeedsToChange.TabIndex = 10;
            // 
            // SoTienDaDoi
            // 
            SoTienDaDoi.AutoSize = true;
            SoTienDaDoi.Location = new Point(138, 233);
            SoTienDaDoi.Name = "SoTienDaDoi";
            SoTienDaDoi.Size = new Size(132, 25);
            SoTienDaDoi.TabIndex = 9;
            SoTienDaDoi.Text = "Số tiền đã đổi: ";
            // 
            // SoTienCanDoi
            // 
            SoTienCanDoi.AutoSize = true;
            SoTienCanDoi.Location = new Point(138, 54);
            SoTienCanDoi.Name = "SoTienCanDoi";
            SoTienCanDoi.Size = new Size(134, 25);
            SoTienCanDoi.TabIndex = 8;
            SoTienCanDoi.Text = "Số tiền cần đổi:";
            // 
            // Exchange
            // 
            Exchange.Location = new Point(275, 144);
            Exchange.Name = "Exchange";
            Exchange.Size = new Size(153, 34);
            Exchange.TabIndex = 7;
            Exchange.Text = "Chuyển đổi";
            Exchange.UseVisualStyleBackColor = true;
            Exchange.Click += Exchange_Click;
            // 
            // Bai_4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Currency);
            Controls.Add(MoneyIsChanged);
            Controls.Add(MoneyNeedsToChange);
            Controls.Add(SoTienDaDoi);
            Controls.Add(SoTienCanDoi);
            Controls.Add(Exchange);
            Name = "Bai_4";
            Text = "Bài 4: Chuyển đổi tiền tệ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox Currency;
        private TextBox MoneyIsChanged;
        private TextBox MoneyNeedsToChange;
        private Label SoTienDaDoi;
        private Label SoTienCanDoi;
        private Button Exchange;
    }
}