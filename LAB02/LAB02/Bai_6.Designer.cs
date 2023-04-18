namespace LAB02
{
    partial class Bai_6
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
            treeFolder = new TreeView();
            listView = new ListView();
            pictureBoxShow = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).BeginInit();
            SuspendLayout();
            // 
            // treeFolder
            // 
            treeFolder.Location = new Point(0, 0);
            treeFolder.Name = "treeFolder";
            treeFolder.Size = new Size(318, 458);
            treeFolder.TabIndex = 0;
            treeFolder.AfterSelect += treeFolder_AfterSelect;
            // 
            // listView
            // 
            listView.Location = new Point(343, 12);
            listView.Name = "listView";
            listView.Size = new Size(286, 61);
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            listView.SelectedIndexChanged += listView_SelectedIndexChanged;
            // 
            // pictureBoxShow
            // 
            pictureBoxShow.Location = new Point(343, 79);
            pictureBoxShow.Name = "pictureBoxShow";
            pictureBoxShow.Size = new Size(685, 379);
            pictureBoxShow.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxShow.TabIndex = 2;
            pictureBoxShow.TabStop = false;
            // 
            // Bai_6
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 473);
            Controls.Add(pictureBoxShow);
            Controls.Add(listView);
            Controls.Add(treeFolder);
            Name = "Bai_6";
            Text = "Bai_6";
            Load += Bai_6_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxShow).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeFolder;
        private ListView listView;
        private PictureBox pictureBoxShow;
    }
}