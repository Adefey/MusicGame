using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicGame
{
    public partial class GameWindow : Form
    {
        MIDIPlayer player = new MIDIPlayer();
        Random random = new Random();
        Graphics gfx;
        Brush RandomBrush;
        Pen UserCorrectClickPen = new Pen(Color.Green, 5);
        Pen UserBadClickPen = new Pen(Color.Red, 5);
        Pen BlackPen = new Pen(Color.Black, 5);
        Bitmap bmp;

        public GameWindow()
        {
            InitializeComponent();
            bmp = new Bitmap(gamePictureBox.Width, gamePictureBox.Height);
            gfx = Graphics.FromImage(bmp);
            tickTimer.Enabled = true;
            noteGeneratorTimer.Enabled = false;
            RedrawOctave();
        }

        private void gamePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            int pressedNote = (e.X / (bmp.Width / 7));
            
            RedrawOctave();
            DrawNote(pressedNote);
            PlayNote(pressedNote, 2);
            noteLabel.Text = pressedNote.ToString();
            delayTimer.Enabled = true;
            delayTimer.Tick += new EventHandler((s, a) =>
            {
                delayTimer.Enabled = false;
                RedrawOctave();
                noteLabel.Text = "-";
            });
        }

        private void RedrawOctave()
        {
            gfx.Clear(Color.White);
            for (int x = 0; x < bmp.Width; x += bmp.Width / 7)
            {
                gfx.DrawLine(BlackPen, x, 0, x, gamePictureBox.Height);
            }
        }

        private void DrawNote(int number) //Начинаются от нуля
        {
            gfx.FillRectangle(RandomBrush, number * (bmp.Width / 7), 0, (bmp.Width / 7), bmp.Height);
        }

        private void PlayNote(int number, int lane)
        {
            player.Note(127, 50+number, 200, lane);
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            RandomBrush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
            gamePictureBox.Image = bmp;
        }

        private void noteGeneratorTimer_Tick(object sender, EventArgs e)
        {
            int note = random.Next(7);
            RedrawOctave();
            DrawNote(note);
            PlayNote(note, 1);
            noteLabel.Text = note.ToString();
            delayTimer.Enabled = true;
            delayTimer.Tick += new EventHandler((s, a) =>
            {
                delayTimer.Enabled = false;
                RedrawOctave();
                noteLabel.Text = "-";
            });
        }
    }
}
