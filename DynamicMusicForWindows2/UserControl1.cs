using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace DynamicMusicForWindows
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }

        private string _name;
        private Image _Img;

        [Category("CustomProps")]
        public string nameTitle
        {
            get { return _name; }
            set { _name = value; Title.Text = value; }
        }
        [Category("CustomProps")]
        public Image Image
        {
            get { return _Img; }
            set { _Img = value; Sprite.Image = value; }
        }




        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void UserControl1_MouseLeave(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(0, 12, 12, 12);
        }

        private void UserControl1_MouseEnter(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(20, 100, 100, 100);
            Cursor = Cursors.Hand;
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            if (Name == "Idle")
            {
                Form1.SelectMusicToPlay(activity.Idle);
            }

            if (Name == "Run")
            {
                Form1.SelectMusicToPlay(activity.Activity);
            }

            Form1.OpenMusic($"Select {_name} music");
            BackColor = Color.FromArgb(50, 100, 100, 100);

            Form1.instance.ReloadMusics();
        }
    }
}
