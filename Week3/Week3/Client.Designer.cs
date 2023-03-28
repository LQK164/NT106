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
            Sending = new Button();
            Input_Port = new TextBox();
            Input_IP = new TextBox();
            Destination_port = new Label();
            Destination_IP = new Label();
            Client_Message = new RichTextBox();
            Exit = new Button();
            SuspendLayout();
            // 
            // Sending
            // 
            Sending.Location = new Point(677, 146);
            Sending.Name = "Sending";
            Sending.Size = new Size(120, 42);
            Sending.TabIndex = 6;
            Sending.Text = "Send";
            Sending.UseVisualStyleBackColor = true;
            Sending.Click += Sending_Click;
            // 
            // Input_Port
            // 
            Input_Port.Location = new Point(599, 21);
            Input_Port.Name = "Input_Port";
            Input_Port.Size = new Size(150, 31);
            Input_Port.TabIndex = 10;
            // 
            // Input_IP
            // 
            Input_IP.Location = new Point(189, 21);
            Input_IP.Name = "Input_IP";
            Input_IP.Size = new Size(227, 31);
            Input_IP.TabIndex = 9;
            // 
            // Destination_port
            // 
            Destination_port.AutoSize = true;
            Destination_port.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Destination_port.Location = new Point(422, 24);
            Destination_port.Name = "Destination_port";
            Destination_port.Size = new Size(162, 28);
            Destination_port.TabIndex = 8;
            Destination_port.Text = "Destination Port :";
            // 
            // Destination_IP
            // 
            Destination_IP.AutoSize = true;
            Destination_IP.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Destination_IP.Location = new Point(37, 24);
            Destination_IP.Name = "Destination_IP";
            Destination_IP.Size = new Size(147, 28);
            Destination_IP.TabIndex = 7;
            Destination_IP.Text = "Destination IP : ";
            // 
            // Client_Message
            // 
            Client_Message.Location = new Point(3, 127);
            Client_Message.Name = "Client_Message";
            Client_Message.Size = new Size(668, 320);
            Client_Message.TabIndex = 11;
            Client_Message.Text = "";
            // 
            // Exit
            // 
            Exit.Location = new Point(676, 216);
            Exit.Name = "Exit";
            Exit.Size = new Size(121, 42);
            Exit.TabIndex = 12;
            Exit.Text = "Exit";
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // Client
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Exit);
            Controls.Add(Client_Message);
            Controls.Add(Sending);
            Controls.Add(Input_Port);
            Controls.Add(Input_IP);
            Controls.Add(Destination_port);
            Controls.Add(Destination_IP);
            Name = "Client";
            Text = "Client";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Sending;
        private TextBox Input_Port;
        private TextBox Input_IP;
        private Label Destination_port;
        private Label Destination_IP;
        private RichTextBox Client_Message;
        private Button Exit;
    }
}