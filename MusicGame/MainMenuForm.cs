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

        private void playButton_Click(object sender, EventArgs e) //Нажатие на кнопку Играть
        {
            PlayerInfo.SetPlayer(nameTextBox.Text, difficultyTrackBar.Value); //настройка имени игрока
            if (PlayerInfo.IsReady()) //Если игрок настроен, то открыть новый экземпляр игрового окна. Если не введено имя, то игра не начнется.
            {
                GameWindow gameWindow = new GameWindow();
                gameWindow.Show();
            }
            else
            {
                //Если не введено имя, выдается сообщение о том, что его надо ввести
                MessageBox.Show("Похоже, вы не ввели имя. Введите его, чтобы отображаться в списке лидеров", "Ошибка, введите данные", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void exitButton_Click(object sender, EventArgs e) //нажатие на кнопку для выхода
        {
            PlayerInfo.ForgetPlayer(); //Вообще удалять данные об игроке не обязательно. И вообще в этой программе много спорных решений. Был бы больше срок - я бы переделал gamewindow, вынеся из него логику и оставив только взаимодействие с формой.
            Close();
        }
    }
}
