namespace DynamicMusicForWindows
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Title = new System.Windows.Forms.Label();
            this.moreButton = new System.Windows.Forms.Label();
            this.Sprite = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Sprite)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.Title.BackColor = System.Drawing.Color.Transparent;
            this.Title.Font = new System.Drawing.Font("Microsoft JhengHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Title.Location = new System.Drawing.Point(68, 28);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(249, 18);
            this.Title.TabIndex = 1;
            this.Title.Text = "Title";
            this.Title.Click += new System.EventHandler(this.UserControl1_Click);
            this.Title.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.Title.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            // 
            // moreButton
            // 
            this.moreButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.moreButton.AutoSize = true;
            this.moreButton.BackColor = System.Drawing.Color.Transparent;
            this.moreButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moreButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.moreButton.Location = new System.Drawing.Point(314, 39);
            this.moreButton.Name = "moreButton";
            this.moreButton.Size = new System.Drawing.Size(31, 29);
            this.moreButton.TabIndex = 2;
            this.moreButton.Text = "...";
            this.moreButton.Click += new System.EventHandler(this.UserControl1_Click);
            // 
            // Sprite
            // 
            this.Sprite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Sprite.BackColor = System.Drawing.Color.Transparent;
            this.Sprite.Image = global::DynamicMusicForWindows.Properties.Resources.ZZZ_Sleep;
            this.Sprite.InitialImage = global::DynamicMusicForWindows.Properties.Resources.ZZZ_Sleep;
            this.Sprite.Location = new System.Drawing.Point(22, 14);
            this.Sprite.Name = "Sprite";
            this.Sprite.Size = new System.Drawing.Size(33, 44);
            this.Sprite.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Sprite.TabIndex = 0;
            this.Sprite.TabStop = false;
            this.Sprite.Click += new System.EventHandler(this.UserControl1_Click);
            this.Sprite.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.Sprite.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            // 
            // UserControl1
            // 
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.moreButton);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Sprite);
            this.DoubleBuffered = true;
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(350, 72);
            this.Click += new System.EventHandler(this.UserControl1_Click);
            this.MouseEnter += new System.EventHandler(this.UserControl1_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.UserControl1_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.Sprite)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Sprite;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label moreButton;
    }
}
