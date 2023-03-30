namespace Week3
{
    partial class Server
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
            Send = new Button();
            gbMessage = new GroupBox();
            Message_Box = new TextBox();
            ChatBox = new ListBox();
            Exit = new Button();
            gbMessage.SuspendLayout();
            SuspendLayout();
            // 
            // Send
            // 
            Send.Location = new Point(666, 79);
            Send.Name = "Send";
            Send.Size = new Size(122, 45);
            Send.TabIndex = 0;
            Send.Text = "Send";
            Send.UseVisualStyleBackColor = true;
            Send.Click += Send_Click;
            // 
            // gbMessage
            // 
            gbMessage.Controls.Add(Message_Box);
            gbMessage.Location = new Point(36, 64);
            gbMessage.Name = "gbMessage";
            gbMessage.Size = new Size(613, 66);
            gbMessage.TabIndex = 1;
            gbMessage.TabStop = false;
            gbMessage.Text = "Message";
            // 
            // Message_Box
            // 
            Message_Box.Location = new Point(6, 29);
            Message_Box.Name = "Message_Box";
            Message_Box.Size = new Size(601, 31);
            Message_Box.TabIndex = 0;
            Message_Box.TextChanged += Message_Box_TextChanged;
            // 
            // ChatBox
            // 
            ChatBox.FormattingEnabled = true;
            ChatBox.ItemHeight = 25;
            ChatBox.Location = new Point(36, 152);
            ChatBox.Name = "ChatBox";
            ChatBox.Size = new Size(613, 279);
            ChatBox.TabIndex = 1;
            // 
            // Exit
            // 
            Exit.Location = new Point(666, 205);
            Exit.Name = "Exit";
            Exit.Size = new Size(122, 45);
            Exit.TabIndex = 2;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(ChatBox);
            Controls.Add(gbMessage);
            Controls.Add(Send);
            Name = "Server";
            Text = "Server";
            gbMessage.ResumeLayout(false);
            gbMessage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button Send;
        private GroupBox gbMessage;
        private TextBox Message_Box;
        private ListBox ChatBox;
        private Button Exit;
    }
}