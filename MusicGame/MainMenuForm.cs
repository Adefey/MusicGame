using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicGame
{
    public partial class MainMenuForm : Form
    {
        public MainMenuForm()
        {
            InitializeComponent();
        }     

        private void playButton_Click(object sender, EventArgs e)
        {
            PlayerInfo.SetPlayer(nameTextBox.Text, difficultyTrackBar.Value);
            if (PlayerInfo.IsReady())
            {
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
            }
            else
            {
                MessageBox.Show("Похоже, вы не ввели имя. Введите его, чтобы отображаться в списке лидеров", "Ошибка, введите данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            PlayerInfo.ForgetPlayer();
            Close();
        }
    }
}
