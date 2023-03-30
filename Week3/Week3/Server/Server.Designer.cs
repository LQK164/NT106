namespace Server
{
    partial class Server
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
            SEND = new Button();
            ChatBox = new ListBox();
            Message_Box = new TextBox();
            groupBox1 = new GroupBox();
            Exit = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // SEND
            // 
            SEND.Location = new Point(77, 436);
            SEND.Margin = new Padding(4, 4, 4, 4);
            SEND.Name = "SEND";
            SEND.Size = new Size(134, 37);
            SEND.TabIndex = 0;
            SEND.Text = "Send";
            SEND.UseVisualStyleBackColor = true;
            SEND.Click += SEND_Click;
            // 
            // ChatBox
            // 
            ChatBox.FormattingEnabled = true;
            ChatBox.ItemHeight = 25;
            ChatBox.Location = new Point(15, 15);
            ChatBox.Margin = new Padding(4, 4, 4, 4);
            ChatBox.Name = "ChatBox";
            ChatBox.Size = new Size(618, 279);
            ChatBox.TabIndex = 1;
            // 
            // Message_Box
            // 
            Message_Box.Location = new Point(17, 31);
            Message_Box.Margin = new Padding(4, 4, 4, 4);
            Message_Box.Multiline = true;
            Message_Box.Name = "Message_Box";
            Message_Box.Size = new Size(594, 37);
            Message_Box.TabIndex = 2;
            Message_Box.TextChanged += Message_Box_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(Message_Box);
            groupBox1.Location = new Point(15, 331);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(618, 84);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Message";
            // 
            // Exit
            // 
            Exit.Location = new Point(403, 436);
            Exit.Name = "Exit";
            Exit.Size = new Size(134, 37);
            Exit.TabIndex = 4;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            // 
            // Server
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 602);
            Controls.Add(Exit);
            Controls.Add(groupBox1);
            Controls.Add(ChatBox);
            Controls.Add(SEND);
            Margin = new Padding(4, 4, 4, 4);
            Name = "Server";
            Text = "Server";
            Load += Server_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button SEND;
        private ListBox ChatBox;
        private TextBox Message_Box;
        private GroupBox groupBox1;
        private Button Exit;
    }
}