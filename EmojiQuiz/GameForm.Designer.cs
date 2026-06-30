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
    private Label labelResult;
    private Button button1;
    private Button button2;
    private Button button3;
    private Button button4;

    private void InitializeComponent()
    {
        labelEmoji = new Label();
        labelCategory = new Label();
        labelScore = new Label();
        labelResult = new Label();
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        button4 = new Button();
        SuspendLayout();

        // счёт сверху
        labelScore.Text = "Счёт: 0";
        labelScore.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        labelScore.ForeColor = Color.FromArgb(168, 154, 249);
        labelScore.AutoSize = false;
        labelScore.TextAlign = ContentAlignment.MiddleLeft;
        labelScore.Location = new Point(20, 15);
        labelScore.Size = new Size(150, 30);

        // категория
        labelCategory.Text = "Фильмы";
        labelCategory.Font = new Font("Segoe UI", 9F);
        labelCategory.ForeColor = Color.FromArgb(136, 133, 170);
        labelCategory.AutoSize = false;
        labelCategory.TextAlign = ContentAlignment.MiddleRight;
        labelCategory.Location = new Point(250, 15);
        labelCategory.Size = new Size(150, 30);

        // карточка с эмодзи
        labelEmoji.Text = "🎬";
        labelEmoji.Font = new Font("Segoe UI Emoji", 36F);
        labelEmoji.ForeColor = Color.White;
        labelEmoji.BackColor = Color.FromArgb(30, 30, 46);
        labelEmoji.AutoSize = false;
        labelEmoji.TextAlign = ContentAlignment.MiddleCenter;
        labelEmoji.Location = new Point(20, 60);
        labelEmoji.Size = new Size(380, 140);

        // 4 кнопки ответов, сетка 2x2
        button1.Font = new Font("Segoe UI", 11F);
        button1.ForeColor = Color.White;
        button1.BackColor = Color.FromArgb(30, 30, 46);
        button1.FlatStyle = FlatStyle.Flat;
        button1.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        button1.Location = new Point(20, 220);
        button1.Size = new Size(185, 60);
        button1.Cursor = Cursors.Hand;
        button1.Click += button1_Click;

        button2.Font = new Font("Segoe UI", 11F);
        button2.ForeColor = Color.White;
        button2.BackColor = Color.FromArgb(30, 30, 46);
        button2.FlatStyle = FlatStyle.Flat;
        button2.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        button2.Location = new Point(215, 220);
        button2.Size = new Size(185, 60);
        button2.Cursor = Cursors.Hand;
        button2.Click += button2_Click;

        button3.Font = new Font("Segoe UI", 11F);
        button3.ForeColor = Color.White;
        button3.BackColor = Color.FromArgb(30, 30, 46);
        button3.FlatStyle = FlatStyle.Flat;
        button3.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        button3.Location = new Point(20, 290);
        button3.Size = new Size(185, 60);
        button3.Cursor = Cursors.Hand;
        button3.Click += button3_Click;

        button4.Font = new Font("Segoe UI", 11F);
        button4.ForeColor = Color.White;
        button4.BackColor = Color.FromArgb(30, 30, 46);
        button4.FlatStyle = FlatStyle.Flat;
        button4.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        button4.Location = new Point(215, 290);
        button4.Size = new Size(185, 60);
        button4.Cursor = Cursors.Hand;
        button4.Click += button4_Click;

        // результат ответа (верно/неверно)
        labelResult.Text = "";
        labelResult.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        labelResult.ForeColor = Color.FromArgb(74, 222, 128);
        labelResult.AutoSize = false;
        labelResult.TextAlign = ContentAlignment.MiddleCenter;
        labelResult.Location = new Point(20, 365);
        labelResult.Size = new Size(380, 30);

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(13, 13, 20);
        ClientSize = new Size(420, 420);
        Controls.Add(labelScore);
        Controls.Add(labelCategory);
        Controls.Add(labelEmoji);
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