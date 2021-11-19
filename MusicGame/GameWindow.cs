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
        Pen RandomPen;
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
            noteGeneratorTimer.Enabled = true;
            RedrawOctave();
        }

        private void gamePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            int pressedNote = (e.X / (bmp.Width / 7));
            
            RedrawOctave();
            DrawNote(pressedNote);
            PlayNote(pressedNote);
            noteLabel.Text = pressedNote.ToString();
            playerNoteTImer.Enabled = true;
            playerNoteTImer.Tick += new EventHandler((s, a) =>
            {
                playerNoteTImer.Enabled = false;
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

        private void PlayNote(int number)
        {
            player.Note(127, 50+number, 200, 1);
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            RandomPen = new Pen(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)), 5);
            RandomBrush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
            gamePictureBox.Image = bmp;
        }

        private void noteGeneratorTimer_Tick(object sender, EventArgs e)
        {
            //DrawOctave();
            //int note = random.Next(7);
            //noteLabel.Text = note.ToString();
            //DrawNote(note);
            //PlayNote(note);
        }
    }
}
