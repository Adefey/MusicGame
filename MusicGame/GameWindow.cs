using System;
using System.Drawing;
using System.Windows.Forms;

namespace MusicGame
{
    public partial class GameWindow : Form
    {
        MIDIPlayer player;
        LevelData currentLevel;
        int score = 0;
        int playerInputNum = 0;
        Random random = new Random();
        Graphics gfx;
        Brush RandomBrush;
        Pen UserCorrectClickPen = new Pen(Color.Green, 5);
        Pen UserBadClickPen = new Pen(Color.Red, 5);
        Pen BlackPen = new Pen(Color.Black, 5);
        Bitmap bmp;

        public GameWindow()
        {
            player = new MIDIPlayer();
            InitializeComponent();
            Size = Screen.PrimaryScreen.Bounds.Size;
            bmp = new Bitmap(gamePictureBox.Width, gamePictureBox.Height);
            gfx = Graphics.FromImage(bmp);
            LevelFactory.SetStart();
            RedrawOctave();
            LevelFactory.maxLevel = PlayerInfo.difficulty;
        }

        private void SetLevel(int number = 0)
        {
            if (number == 0)
            {
                currentLevel = LevelFactory.GetNext();
                noteGeneratorTimer.Interval = currentLevel.delay;
            }
            else
            {
                currentLevel = LevelFactory.GetLevel(number);
                noteGeneratorTimer.Interval = currentLevel.delay;
            }
        }

        private void gamePictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (currentLevel == null) return;
            int pressedNote = (e.X / (bmp.Width / 7));
            if (pressedNote == currentLevel.notes[playerInputNum])
            {
                score += 10;
                playerInputNum++;
            }
            else
            {
                MessageBox.Show($"Игра окончена. {PlayerInfo.name}, ваш счет: {score}", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
                return;
            }
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
            scoreLabel.Text = score.ToString();
            if (playerInputNum == currentLevel.notes.Count && LevelFactory.currentLevel == LevelFactory.maxLevel)
            {
                MessageBox.Show($"Игра пройдена!  {PlayerInfo.name}, ваш счет: {score}", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                Close();
            }
            else if (playerInputNum == currentLevel.notes.Count)
            {
                MessageBox.Show($"Уровень пройден", "Результаты", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nextLevelButton_Click(sender, e);
            }
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
            player.Note(127, 60 + number, 200, lane);
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {
            RandomBrush = new SolidBrush(Color.FromArgb(random.Next(255), random.Next(255), random.Next(255)));
            gamePictureBox.Image = bmp;
        }

        private void noteGeneratorTimer_Tick(object sender, EventArgs e)
        {
            int note;
            if (LevelData.count < currentLevel.notes.Count)
            {
                note = currentLevel.notes[LevelData.count];
                LevelData.count++;
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
            else
            {
                noteGeneratorTimer.Enabled = false;
            }
        }

        private void nextLevelButton_Click(object sender, EventArgs e)
        {
            playerInputNum = 0;
            noteGeneratorTimer.Enabled = true;
            nextLevelButton.Visible = false;            
            SetLevel();
            levelLabel.Text = LevelFactory.currentLevel.ToString();
        }

        private void GameWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            player.Close();
        }
    }
}
