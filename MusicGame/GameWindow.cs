using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicGame
{
    public partial class GameWindow : Form
    {
        Random random = new Random();
        Graphics gfx;
        Pen ClickPen;
        Pen UserClick;

        public GameWindow()
        {
            InitializeComponent();
            gfx = gamePictureBox.CreateGraphics();
            timer.Enabled = true;
        }

        private void gamePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            gfx.DrawEllipse(ClickPen, e.X-10, e.Y-10, 20, 20);
        }

        private void timer_Tick(object sender, System.EventArgs e)
        {
            ClickPen = new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)), 5);
        }
    }
}
