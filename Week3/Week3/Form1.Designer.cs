namespace Week3
{
    partial class udp_chat
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
            Server = new Button();
            Client = new Button();
            SuspendLayout();
            // 
            // Server
            // 
            Server.Location = new Point(69, 97);
            Server.Name = "Server";
            Server.Size = new Size(217, 98);
            Server.TabIndex = 0;
            Server.Text = "Server";
            Server.UseVisualStyleBackColor = true;
            Server.Click += Server_Click;
            // 
            // Client
            // 
            Client.Location = new Point(428, 97);
            Client.Name = "Client";
            Client.Size = new Size(218, 98);
            Client.TabIndex = 1;
            Client.Text = "Client";
            Client.UseVisualStyleBackColor = true;
            Client.Click += Client_Click;
            // 
            // udp_chat
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Client);
            Controls.Add(Server);
            Name = "udp_chat";
            Text = "UDP chat";
            ResumeLayout(false);
        }

        #endregion

        private Button Server;
        private Button Client;
    }
}