namespace MusicGame
{
    partial class GameWindow
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameWindow));
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.noteLabel = new System.Windows.Forms.Label();
            this.noteHintLabel = new System.Windows.Forms.Label();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreHintLabel = new System.Windows.Forms.Label();
            this.gamePictureBox = new System.Windows.Forms.PictureBox();
            this.tickTimer = new System.Windows.Forms.Timer(this.components);
            this.noteGeneratorTimer = new System.Windows.Forms.Timer(this.components);
            this.delayTimer = new System.Windows.Forms.Timer(this.components);
            this.nextLevelButton = new System.Windows.Forms.Button();
            this.levelHintLabel = new System.Windows.Forms.Label();
            this.levelLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.ColumnCount = 7;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel.Controls.Add(this.levelLabel, 5, 1);
            this.tableLayoutPanel.Controls.Add(this.levelHintLabel, 4, 1);
            this.tableLayoutPanel.Controls.Add(this.noteLabel, 3, 1);
            this.tableLayoutPanel.Controls.Add(this.noteHintLabel, 2, 1);
            this.tableLayoutPanel.Controls.Add(this.scoreLabel, 1, 1);
            this.tableLayoutPanel.Controls.Add(this.scoreHintLabel, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.gamePictureBox, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.nextLevelButton, 6, 1);
            this.tableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 2;
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel.Size = new System.Drawing.Size(1904, 1041);
            this.tableLayoutPanel.TabIndex = 0;
            // 
            // noteLabel
            // 
            this.noteLabel.AutoSize = true;
            this.noteLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteLabel.Location = new System.Drawing.Point(816, 988);
            this.noteLabel.Margin = new System.Windows.Forms.Padding(0);
            this.noteLabel.Name = "noteLabel";
            this.noteLabel.Size = new System.Drawing.Size(272, 53);
            this.noteLabel.TabIndex = 6;
            this.noteLabel.Text = "-";
            this.noteLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // noteHintLabel
            // 
            this.noteHintLabel.AutoSize = true;
            this.noteHintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.noteHintLabel.Location = new System.Drawing.Point(544, 988);
            this.noteHintLabel.Margin = new System.Windows.Forms.Padding(0);
            this.noteHintLabel.Name = "noteHintLabel";
            this.noteHintLabel.Size = new System.Drawing.Size(272, 53);
            this.noteHintLabel.TabIndex = 5;
            this.noteHintLabel.Text = "Играет нота:";
            this.noteHintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreLabel.Location = new System.Drawing.Point(272, 988);
            this.scoreLabel.Margin = new System.Windows.Forms.Padding(0);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(272, 53);
            this.scoreLabel.TabIndex = 3;
            this.scoreLabel.Text = "0";
            this.scoreLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scoreHintLabel
            // 
            this.scoreHintLabel.AutoSize = true;
            this.scoreHintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scoreHintLabel.Location = new System.Drawing.Point(0, 988);
            this.scoreHintLabel.Margin = new System.Windows.Forms.Padding(0);
            this.scoreHintLabel.Name = "scoreHintLabel";
            this.scoreHintLabel.Size = new System.Drawing.Size(272, 53);
            this.scoreHintLabel.TabIndex = 2;
            this.scoreHintLabel.Text = "Ваш счет:";
            this.scoreHintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gamePictureBox
            // 
            this.tableLayoutPanel.SetColumnSpan(this.gamePictureBox, 7);
            this.gamePictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gamePictureBox.Location = new System.Drawing.Point(0, 0);
            this.gamePictureBox.Margin = new System.Windows.Forms.Padding(0);
            this.gamePictureBox.Name = "gamePictureBox";
            this.gamePictureBox.Size = new System.Drawing.Size(1904, 988);
            this.gamePictureBox.TabIndex = 4;
            this.gamePictureBox.TabStop = false;
            this.gamePictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.gamePictureBox_MouseDown);
            // 
            // tickTimer
            // 
            this.tickTimer.Enabled = true;
            this.tickTimer.Interval = 15;
            this.tickTimer.Tick += new System.EventHandler(this.tickTimer_Tick);
            // 
            // noteGeneratorTimer
            // 
            this.noteGeneratorTimer.Interval = 500;
            this.noteGeneratorTimer.Tick += new System.EventHandler(this.noteGeneratorTimer_Tick);
            // 
            // delayTimer
            // 
            this.delayTimer.Interval = 200;
            // 
            // nextLevelButton
            // 
            this.nextLevelButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nextLevelButton.Location = new System.Drawing.Point(1632, 988);
            this.nextLevelButton.Margin = new System.Windows.Forms.Padding(0);
            this.nextLevelButton.Name = "nextLevelButton";
            this.nextLevelButton.Size = new System.Drawing.Size(272, 53);
            this.nextLevelButton.TabIndex = 7;
            this.nextLevelButton.Text = "Играть";
            this.nextLevelButton.UseVisualStyleBackColor = true;
            this.nextLevelButton.Click += new System.EventHandler(this.nextLevelButton_Click);
            // 
            // levelHintLabel
            // 
            this.levelHintLabel.AutoSize = true;
            this.levelHintLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelHintLabel.Location = new System.Drawing.Point(1088, 988);
            this.levelHintLabel.Margin = new System.Windows.Forms.Padding(0);
            this.levelHintLabel.Name = "levelHintLabel";
            this.levelHintLabel.Size = new System.Drawing.Size(272, 53);
            this.levelHintLabel.TabIndex = 8;
            this.levelHintLabel.Text = "Уровень:";
            this.levelHintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelLabel.Location = new System.Drawing.Point(1360, 988);
            this.levelLabel.Margin = new System.Windows.Forms.Padding(0);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(272, 53);
            this.levelLabel.TabIndex = 9;
            this.levelLabel.Text = "-";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.tableLayoutPanel);
            this.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GameWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameWindow";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gamePictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Label scoreHintLabel;
        private System.Windows.Forms.PictureBox gamePictureBox;
        private System.Windows.Forms.Timer tickTimer;
        private System.Windows.Forms.Timer noteGeneratorTimer;
        private System.Windows.Forms.Label noteLabel;
        private System.Windows.Forms.Label noteHintLabel;
        private System.Windows.Forms.Timer delayTimer;
        private System.Windows.Forms.Button nextLevelButton;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label levelHintLabel;
    }
}