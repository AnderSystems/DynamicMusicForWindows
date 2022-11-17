

using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace DynamicMusicForWindows
{
    partial class Form1
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.IdlePlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.RunPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.Volume = new System.Windows.Forms.TrackBar();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.Debug = new System.Windows.Forms.Label();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.VolumeIcon = new System.Windows.Forms.PictureBox();
            this.Run = new DynamicMusicForWindows.UserControl1();
            this.Idle = new DynamicMusicForWindows.UserControl1();
            this.MoreOptions = new System.Windows.Forms.Panel();
            this.Close = new System.Windows.Forms.Label();
            this.Minimize = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IdlePlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeIcon)).BeginInit();
            this.MoreOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // IdlePlayer
            // 
            this.IdlePlayer.Enabled = true;
            this.IdlePlayer.Location = new System.Drawing.Point(0, 0);
            this.IdlePlayer.Name = "IdlePlayer";
            this.IdlePlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("IdlePlayer.OcxState")));
            this.IdlePlayer.Size = new System.Drawing.Size(10, 10);
            this.IdlePlayer.TabIndex = 2;
            this.IdlePlayer.Visible = false;
            // 
            // RunPlayer
            // 
            this.RunPlayer.Enabled = true;
            this.RunPlayer.Location = new System.Drawing.Point(0, 0);
            this.RunPlayer.Name = "RunPlayer";
            this.RunPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("RunPlayer.OcxState")));
            this.RunPlayer.Size = new System.Drawing.Size(10, 10);
            this.RunPlayer.TabIndex = 3;
            this.RunPlayer.Visible = false;
            // 
            // Volume
            // 
            this.Volume.Location = new System.Drawing.Point(57, 162);
            this.Volume.Maximum = 100;
            this.Volume.Name = "Volume";
            this.Volume.Size = new System.Drawing.Size(305, 45);
            this.Volume.TabIndex = 4;
            this.Volume.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Volume.Value = 100;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flowLayoutPanel1.ForeColor = System.Drawing.SystemColors.Control;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 147);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(324, 1);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // Debug
            // 
            this.Debug.AutoSize = true;
            this.Debug.BackColor = System.Drawing.Color.Transparent;
            this.Debug.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Debug.Location = new System.Drawing.Point(363, 167);
            this.Debug.Name = "Debug";
            this.Debug.Size = new System.Drawing.Size(25, 13);
            this.Debug.TabIndex = 7;
            this.Debug.Text = "100";
            this.Debug.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Dynamic Music";
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DynamicMusicForWindows.Properties.Resources.Down_Minimize_Arrow;
            this.pictureBox1.InitialImage = global::DynamicMusicForWindows.Properties.Resources.Close_X;
            this.pictureBox1.Location = new System.Drawing.Point(377, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // VolumeIcon
            // 
            this.VolumeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.VolumeIcon.BackColor = System.Drawing.Color.Transparent;
            this.VolumeIcon.Image = global::DynamicMusicForWindows.Properties.Resources.Audio_Volume_Speaker_Sound;
            this.VolumeIcon.InitialImage = global::DynamicMusicForWindows.Properties.Resources.ZZZ_Sleep;
            this.VolumeIcon.Location = new System.Drawing.Point(27, 148);
            this.VolumeIcon.Name = "VolumeIcon";
            this.VolumeIcon.Size = new System.Drawing.Size(24, 51);
            this.VolumeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VolumeIcon.TabIndex = 5;
            this.VolumeIcon.TabStop = false;
            // 
            // Run
            // 
            this.Run.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Run.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Run.Dock = System.Windows.Forms.DockStyle.Top;
            this.Run.Image = global::DynamicMusicForWindows.Properties.Resources.Awake_Rail_lightning_bolt;
            this.Run.Location = new System.Drawing.Point(0, 71);
            this.Run.Name = "Run";
            this.Run.nameTitle = "Run";
            this.Run.Size = new System.Drawing.Size(400, 71);
            this.Run.TabIndex = 1;
            // 
            // Idle
            // 
            this.Idle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.Idle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Idle.Dock = System.Windows.Forms.DockStyle.Top;
            this.Idle.Image = global::DynamicMusicForWindows.Properties.Resources.ZZZ_Sleep;
            this.Idle.Location = new System.Drawing.Point(0, 0);
            this.Idle.Name = "Idle";
            this.Idle.nameTitle = "Idle";
            this.Idle.Size = new System.Drawing.Size(400, 71);
            this.Idle.TabIndex = 0;
            // 
            // MoreOptions
            // 
            this.MoreOptions.BackColor = System.Drawing.Color.Transparent;
            this.MoreOptions.Controls.Add(this.Close);
            this.MoreOptions.Controls.Add(this.Minimize);
            this.MoreOptions.Location = new System.Drawing.Point(304, 27);
            this.MoreOptions.Name = "MoreOptions";
            this.MoreOptions.Size = new System.Drawing.Size(88, 74);
            this.MoreOptions.TabIndex = 9;
            this.MoreOptions.Visible = false;
            // 
            // Close
            // 
            this.Close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Close.Dock = System.Windows.Forms.DockStyle.Top;
            this.Close.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Close.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Close.Location = new System.Drawing.Point(0, 35);
            this.Close.Margin = new System.Windows.Forms.Padding(3);
            this.Close.Name = "Close";
            this.Close.Padding = new System.Windows.Forms.Padding(3);
            this.Close.Size = new System.Drawing.Size(88, 35);
            this.Close.TabIndex = 11;
            this.Close.Text = "Close";
            this.Close.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            this.Close.Leave += new System.EventHandler(this.CloseMoreOps);
            this.Close.MouseEnter += new System.EventHandler(this.Close_MouseEnter);
            this.Close.MouseLeave += new System.EventHandler(this.Close_MouseLeave);
            // 
            // Minimize
            // 
            this.Minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.Minimize.Dock = System.Windows.Forms.DockStyle.Top;
            this.Minimize.Font = new System.Drawing.Font("Microsoft YaHei UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Minimize.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Minimize.Location = new System.Drawing.Point(0, 0);
            this.Minimize.Margin = new System.Windows.Forms.Padding(3);
            this.Minimize.Name = "Minimize";
            this.Minimize.Padding = new System.Windows.Forms.Padding(3);
            this.Minimize.Size = new System.Drawing.Size(88, 35);
            this.Minimize.TabIndex = 10;
            this.Minimize.Text = "Minimize";
            this.Minimize.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Minimize.Click += new System.EventHandler(this.Minimize_Click);
            this.Minimize.Leave += new System.EventHandler(this.CloseMoreOps);
            this.Minimize.MouseEnter += new System.EventHandler(this.Minimize_MouseEnter);
            this.Minimize.MouseLeave += new System.EventHandler(this.Minimize_MouseLeave);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipTitle = "asdasd";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(22)))), ((int)(((byte)(22)))));
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.MoreOptions);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Debug);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.VolumeIcon);
            this.Controls.Add(this.Volume);
            this.Controls.Add(this.RunPlayer);
            this.Controls.Add(this.IdlePlayer);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Idle);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Dynamic Music For Windows";
            this.TransparencyKey = System.Drawing.Color.Black;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.IdlePlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RunPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Volume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeIcon)).EndInit();
            this.MoreOptions.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UserControl1 Idle;
        private UserControl1 Run;
        private AxWMPLib.AxWindowsMediaPlayer IdlePlayer;
        private AxWMPLib.AxWindowsMediaPlayer RunPlayer;
        private TrackBar Volume;
        private PictureBox VolumeIcon;
        private FlowLayoutPanel flowLayoutPanel1;
        private Label Debug;
        private PictureBox pictureBox1;
        private NotifyIcon notifyIcon1;
        private Panel MoreOptions;
        private Label Close;
        private Label Minimize;
        private ToolTip toolTip1;
    }
}

