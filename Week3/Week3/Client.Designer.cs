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
            Connect = new Button();
            Exit = new Button();
            Send = new Button();
            Message = new GroupBox();
            Message_Box = new TextBox();
            ChatBox = new ListBox();
            Message.SuspendLayout();
            SuspendLayout();
            // 
            // Connect
            // 
            Connect.Location = new Point(631, 80);
            Connect.Name = "Connect";
            Connect.Size = new Size(139, 52);
            Connect.TabIndex = 0;
            Connect.Text = "Connect";
            Connect.UseVisualStyleBackColor = true;
            Connect.Click += Connect_Click;
            // 
            // Exit
            // 
            Exit.Location = new Point(631, 225);
            Exit.Name = "Exit";
            Exit.Size = new Size(139, 57);
            Exit.TabIndex = 1;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Send
            // 
            Send.Location = new Point(631, 367);
            Send.Name = "Send";
            Send.Size = new Size(139, 57);
            Send.TabIndex = 2;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // Message
            // 
            Message.Controls.Add(Message_Box);
            Message.Location = new Point(16, 353);
            Message.Name = "Message";
            Message.Size = new Size(562, 75);
            Message.TabIndex = 3;
            Message.TabStop = false;
            Message.Text = "groupBox1";
            // 
            // Message_Box
            // 
            Message_Box.Location = new Point(3, 27);
            Message_Box.Multiline = true;
            Message_Box.Name = "Message_Box";
            Message_Box.Size = new Size(559, 29);
            Message_Box.TabIndex = 0;
            // 
            // ChatBox
            // 
            ChatBox.FormattingEnabled = true;
            ChatBox.ItemHeight = 25;
            ChatBox.Location = new Point(16, 50);
            ChatBox.Name = "ChatBox";
            ChatBox.Size = new Size(562, 254);
            ChatBox.TabIndex = 4;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(ChatBox);
            Controls.Add(Message);
            Controls.Add(Send);
            Controls.Add(Exit);
            Controls.Add(Connect);
            Name = "Client";
            Text = "Client";
            Message.ResumeLayout(false);
            Message.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Connect;
        private Button Exit;
        private Button Send;
        private GroupBox Message;
        private TextBox Message_Box;
        private ListBox ChatBox;
    }
}