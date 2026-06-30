namespace EmojiQuiz;

partial class GameForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private Label labelEmoji;
    private Label labelCategory;
    private Label labelScore;
    private Label labelProgress;
    private Label labelTimer;
    private Label labelResult;
    private Panel panelProgressBar;
    private Panel panelProgressFill;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;
    private Button buttonExit;
    private System.Windows.Forms.Timer gameTimer;

    private void InitializeComponent()
    {
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        labelScore = new Label();
        labelProgress = new Label();
        buttonExit = new Button();
        panelProgressBar = new Panel();
        panelProgressFill = new Panel();
        labelEmoji = new Label();
        labelTimer = new Label();
        labelCategory = new Label();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        labelResult = new Label();
        gameTimer = new System.Windows.Forms.Timer();
        SuspendLayout();

        // верхняя строка: счёт / прогресс / кнопка выйти
        labelScore.Text = "⭐ 0 очков";
        labelScore.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
        labelScore.ForeColor = Color.FromArgb(251, 191, 36);
        labelScore.AutoSize = false;
        labelScore.TextAlign = ContentAlignment.MiddleLeft;
        labelScore.Location = new Point(15, 12);
        labelScore.Size = new Size(140, 25);

        labelProgress.Text = "1/10";
        labelProgress.Font = new Font("Segoe UI", 10F);
        labelProgress.ForeColor = Color.FromArgb(136, 133, 170);
        labelProgress.AutoSize = false;
        labelProgress.TextAlign = ContentAlignment.MiddleRight;
        labelProgress.Location = new Point(200, 12);
        labelProgress.Size = new Size(95, 25);

        buttonExit.Text = "Выйти";
        buttonExit.Font = new Font("Segoe UI", 9F);
        buttonExit.ForeColor = Color.FromArgb(240, 238, 252);
        buttonExit.BackColor = Color.FromArgb(30, 30, 46);
        buttonExit.FlatStyle = FlatStyle.Flat;
        buttonExit.FlatAppearance.BorderSize = 0;
        buttonExit.Location = new Point(305, 8);
        buttonExit.Size = new Size(95, 32);
        buttonExit.Cursor = Cursors.Hand;
        buttonExit.Click += buttonExit_Click;

        // полоса прогресса
        panelProgressBar.BackColor = Color.FromArgb(37, 37, 56);
        panelProgressBar.Location = new Point(15, 48);
        panelProgressBar.Size = new Size(385, 4);

        panelProgressFill.BackColor = Color.FromArgb(124, 108, 248);
        panelProgressFill.Location = new Point(0, 0);
        panelProgressFill.Size = new Size(38, 4);

        // карточка эмодзи
        labelEmoji.Font = new Font("Segoe UI Emoji", 34F);
        labelEmoji.ForeColor = Color.White;
        labelEmoji.BackColor = Color.FromArgb(30, 30, 46);
        labelEmoji.AutoSize = false;
        labelEmoji.TextAlign = ContentAlignment.MiddleCenter;
        labelEmoji.Location = new Point(15, 65);
        labelEmoji.Size = new Size(385, 130);

        // таймер (цифра по центру) + категория
        labelTimer.Text = "15";
        labelTimer.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        labelTimer.ForeColor = Color.FromArgb(124, 108, 248);
        labelTimer.BackColor = Color.FromArgb(30, 30, 46);
        labelTimer.AutoSize = false;
        labelTimer.TextAlign = ContentAlignment.MiddleCenter;
        labelTimer.Location = new Point(170, 205);
        labelTimer.Size = new Size(40, 40);

        labelCategory.Text = "";
        labelCategory.Font = new Font("Segoe UI", 9F);
        labelCategory.ForeColor = Color.FromArgb(168, 154, 249);
        labelCategory.AutoSize = false;
        labelCategory.TextAlign = ContentAlignment.MiddleCenter;
        labelCategory.Location = new Point(220, 213);
        labelCategory.Size = new Size(110, 24);

        // 4 кнопки ответов
        button1.Font = new Font("Segoe UI", 10.5F);
        button1.ForeColor = Color.White;
        button1.BackColor = Color.FromArgb(30, 30, 46);
        button1.FlatStyle = FlatStyle.Flat;
        button1.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        button1.Location = new Point(15, 260);
        button1.Size = new Size(187, 55);
        button1.Cursor = Cursors.Hand;
        button1.Click += button1_Click;

        button2.Font = new Font("Segoe UI", 10.5F);
        button2.ForeColor = Color.White;
        button2.BackColor = Color.FromArgb(30, 30, 46);
        button2.FlatStyle = FlatStyle.Flat;
        button2.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        button2.Location = new Point(213, 260);
        button2.Size = new Size(187, 55);
        button2.Cursor = Cursors.Hand;
        button2.Click += button2_Click;

        button3.Font = new Font("Segoe UI", 10.5F);
        button3.ForeColor = Color.White;
        button3.BackColor = Color.FromArgb(30, 30, 46);
        button3.FlatStyle = FlatStyle.Flat;
        button3.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        button3.Location = new Point(15, 325);
        button3.Size = new Size(187, 55);
        button3.Cursor = Cursors.Hand;
        button3.Click += button3_Click;

        button4.Font = new Font("Segoe UI", 10.5F);
        button4.ForeColor = Color.White;
        button4.BackColor = Color.FromArgb(30, 30, 46);
        button4.FlatStyle = FlatStyle.Flat;
        button4.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        button4.Location = new Point(213, 325);
        button4.Size = new Size(187, 55);
        button4.Cursor = Cursors.Hand;
        button4.Click += button4_Click;

        labelResult.Text = "";
        labelResult.Font = new Font("Segoe UI", 10.5F, FontStyle.Bold);
        labelResult.ForeColor = Color.FromArgb(74, 222, 128);
        labelResult.AutoSize = false;
        labelResult.TextAlign = ContentAlignment.MiddleCenter;
        labelResult.Location = new Point(15, 390);
        labelResult.Size = new Size(385, 30);

        gameTimer.Interval = 1000;
        gameTimer.Tick += gameTimer_Tick;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(13, 13, 20);
        ClientSize = new Size(420, 430);
        panelProgressBar.Controls.Add(panelProgressFill);
        Controls.Add(labelScore);
        Controls.Add(labelProgress);
        Controls.Add(buttonExit);
        Controls.Add(panelProgressBar);
        Controls.Add(labelEmoji);
        Controls.Add(labelTimer);
        Controls.Add(labelCategory);
        Controls.Add(button1);
        Controls.Add(button2);
        Controls.Add(button3);
        Controls.Add(button4);
        Controls.Add(labelResult);
        Text = "Игра";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
    }
}