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
            Input_IP = new TextBox();
            Port = new Label();
            Stảt = new Button();
            Stop = new Button();
            Server_Message = new RichTextBox();
            Exit = new Button();
            SuspendLayout();
            // 
            // Input_IP
            // 
            Input_IP.Location = new Point(165, 21);
            Input_IP.Name = "Input_IP";
            Input_IP.Size = new Size(227, 31);
            Input_IP.TabIndex = 14;
            // 
            // Port
            // 
            Port.AutoSize = true;
            Port.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Port.Location = new Point(87, 24);
            Port.Name = "Port";
            Port.Size = new Size(62, 28);
            Port.TabIndex = 12;
            Port.Text = "Port : ";
            // 
            // Stảt
            // 
            Stảt.Location = new Point(435, 18);
            Stảt.Name = "Stảt";
            Stảt.Size = new Size(127, 34);
            Stảt.TabIndex = 15;
            Stảt.Text = "Start";
            Stảt.UseVisualStyleBackColor = true;
            Stảt.Click += Start_Click;
            // 
            // Stop
            // 
            Stop.Location = new Point(589, 18);
            Stop.Name = "Stop";
            Stop.Size = new Size(127, 34);
            Stop.TabIndex = 16;
            Stop.Text = "Stop";
            Stop.UseVisualStyleBackColor = true;
            Stop.Click += Stop_Click;
            // 
            // Server_Message
            // 
            Server_Message.Location = new Point(9, 103);
            Server_Message.Name = "Server_Message";
            Server_Message.Size = new Size(650, 347);
            Server_Message.TabIndex = 17;
            Server_Message.Text = "";
            // 
            // Exit
            // 
            Exit.Location = new Point(676, 121);
            Exit.Name = "Exit";
            Exit.Size = new Size(112, 34);
            Exit.TabIndex = 18;
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
            Controls.Add(Server_Message);
            Controls.Add(Stop);
            Controls.Add(Stảt);
            Controls.Add(Input_IP);
            Controls.Add(Port);
            Name = "Server";
            Text = "Server";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Input_IP;
        private Label Port;
        private Button Stảt;
        private Button Stop;
        private RichTextBox Server_Message;
        private Button Exit;
    }
}