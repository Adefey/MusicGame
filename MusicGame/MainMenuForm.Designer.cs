namespace MusicGame
{
    partial class MainMenuForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenuForm));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.exitButton = new System.Windows.Forms.Button();
            this.difficultyHintLabel = new System.Windows.Forms.Label();
            this.nameHintLabel = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.difficultyTrackBar = new System.Windows.Forms.TrackBar();
            this.playButton = new System.Windows.Forms.Button();
            this.mainMenuPictureBox = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 3;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel.Controls.Add(this.exitButton, 2, 2);
            this.tableLayoutPanel.Controls.Add(this.difficultyHintLabel, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.mainMenuPictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.nameHintLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.nameTextBox, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.difficultyTrackBar, 1, 2);
            this.tableLayoutPanel.Controls.Add(this.playButton, 2, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 3;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(784, 461);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // exitButton
            // 
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.exitButton.Location = new System.Drawing.Point(391, 414);
            this.exitButton.Margin = new System.Windows.Forms.Padding(0);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(393, 47);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            // 
            // difficultyHintLabel
            // 
            this.difficultyHintLabel.AutoSize = true;
            this.difficultyHintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyHintLabel.Location = new System.Drawing.Point(0, 414);
            this.difficultyHintLabel.Margin = new System.Windows.Forms.Padding(0);
            this.difficultyHintLabel.Name = "difficultyHintLabel";
            this.difficultyHintLabel.Size = new System.Drawing.Size(156, 47);
            this.difficultyHintLabel.TabIndex = 2;
            this.difficultyHintLabel.Text = "Выбери режим сложности";
            this.difficultyHintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameHintLabel
            // 
            this.nameHintLabel.AutoSize = true;
            this.nameHintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameHintLabel.Location = new System.Drawing.Point(0, 368);
            this.nameHintLabel.Margin = new System.Windows.Forms.Padding(0);
            this.nameHintLabel.Name = "nameHintLabel";
            this.nameHintLabel.Size = new System.Drawing.Size(156, 46);
            this.nameHintLabel.TabIndex = 1;
            this.nameHintLabel.Text = "Введи свое имя";
            this.nameHintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameTextBox.Location = new System.Drawing.Point(156, 368);
            this.nameTextBox.Margin = new System.Windows.Forms.Padding(0);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(235, 30);
            this.nameTextBox.TabIndex = 3;
            // 
            // difficultyTrackBar
            // 
            this.difficultyTrackBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyTrackBar.LargeChange = 1;
            this.difficultyTrackBar.Location = new System.Drawing.Point(156, 414);
            this.difficultyTrackBar.Margin = new System.Windows.Forms.Padding(0);
            this.difficultyTrackBar.Maximum = 3;
            this.difficultyTrackBar.Minimum = 1;
            this.difficultyTrackBar.Name = "difficultyTrackBar";
            this.difficultyTrackBar.Size = new System.Drawing.Size(235, 47);
            this.difficultyTrackBar.TabIndex = 4;
            this.difficultyTrackBar.Value = 1;
            // 
            // playButton
            // 
            this.playButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.playButton.Location = new System.Drawing.Point(391, 368);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(393, 46);
            this.playButton.TabIndex = 5;
            this.playButton.Text = "Играть!";
            this.playButton.UseVisualStyleBackColor = true;
            // 
            // mainMenuPictureBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.mainMenuPictureBox, 3);
            this.mainMenuPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainMenuPictureBox.Image = global::MusicGame.Properties.Resources.MainMenuBG;
            this.mainMenuPictureBox.Location = new System.Drawing.Point(0, 0);
            this.mainMenuPictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.mainMenuPictureBox.Name = "mainMenuPictureBox";
            this.mainMenuPictureBox.Size = new System.Drawing.Size(784, 368);
            this.mainMenuPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainMenuPictureBox.TabIndex = 0;
            this.mainMenuPictureBox.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenuForm";
            this.Text = "Музыкальная игра";
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.difficultyTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainMenuPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.PictureBox mainMenuPictureBox;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label difficultyHintLabel;
        private System.Windows.Forms.Label nameHintLabel;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TrackBar difficultyTrackBar;
        private System.Windows.Forms.Button playButton;
    }
}

