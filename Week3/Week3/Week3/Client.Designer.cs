namespace Week3
{
    partial class Client
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
            Exit = new Button();
            Send = new Button();
            ChatBox = new ListBox();
            Message_Box = new TextBox();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // Exit
            // 
            Exit.Location = new Point(461, 393);
            Exit.Margin = new Padding(2);
            Exit.Name = "Exit";
            Exit.Size = new Size(131, 45);
            Exit.TabIndex = 1;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Send
            // 
            Send.Location = new Point(141, 393);
            Send.Margin = new Padding(2);
            Send.Name = "Send";
            Send.Size = new Size(131, 46);
            Send.TabIndex = 2;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // ChatBox
            // 
            ChatBox.FormattingEnabled = true;
            ChatBox.ItemHeight = 25;
            ChatBox.Location = new Point(91, 26);
            ChatBox.Margin = new Padding(2);
            ChatBox.Name = "ChatBox";
            ChatBox.Size = new Size(562, 254);
            ChatBox.TabIndex = 4;
            // 
            // Message_Box
            // 
            Message_Box.Location = new Point(7, 29);
            Message_Box.Margin = new Padding(2);
            Message_Box.Multiline = true;
            Message_Box.Name = "Message_Box";
            Message_Box.Size = new Size(559, 29);
            Message_Box.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Message_Box);
            groupBox1.Location = new Point(91, 307);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(566, 71);
            groupBox1.TabIndex = 5;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox1);
            Controls.Add(ChatBox);
            Controls.Add(Send);
            Controls.Add(Exit);
            Margin = new Padding(2);
            Name = "Client";
            Text = "Client";
            Load += Client_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Button Exit;
        private Button Send;
        private ListBox ChatBox;
        private TextBox Message_Box;
        private GroupBox groupBox1;
    }
}