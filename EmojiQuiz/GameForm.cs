namespace EmojiQuiz;

public partial class GameForm : Form
{
    private int TotalQuestions = 10;
    private const int TimerSeconds = 15;

    private static readonly Random rng = new();
    private Question? current;
    private int score = 0;
    private int correctCount = 0;
    private int questionIndex = 0;
    private int timeLeft;
    private bool answered = false;

    private readonly string? selectedCategory;

    public GameForm(string? category = null)
    {
        InitializeComponent();
        selectedCategory = category;

        int available = Db.CountByCategory(category);
        TotalQuestions = Math.Min(10, available);
        if (TotalQuestions < 1) TotalQuestions = 1;

        NextQuestion();
    }

    private void NextQuestion()
    {
        gameTimer.Stop();

        if (questionIndex >= TotalQuestions)
        {
            ShowResults();
            return;
        }

        questionIndex++;
        labelProgress.Text = questionIndex + "/" + TotalQuestions;
        UpdateProgressBar();

        current = Db.GetRandom(selectedCategory);
        if (current == null)
        {
            labelEmoji.Text = "База пуста";
            return;
        }

        answered = false;
        labelEmoji.Text = current.Emoji;
        labelCategory.Text = current.Category;
        labelResult.Text = "";

        var options = Db.GetWrongAnswers(current.Answer, 3, selectedCategory);
        options.Add(current.Answer);
        Shuffle(options);

        var buttons = new[] { button1, button2, button3, button4 };
        for (int i = 0; i < buttons.Length; i++)
        {
            buttons[i].BackColor = Color.FromArgb(30, 30, 46);
            buttons[i].ForeColor = Color.White;
            buttons[i].Font = new Font("Segoe UI", 10.5F, FontStyle.Regular);
            buttons[i].FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
            buttons[i].FlatAppearance.BorderSize = 1;
            buttons[i].Enabled = true;

            if (i < options.Count)
            {
                buttons[i].Text = options[i];
                buttons[i].Visible = true;
            }
            else
            {
                buttons[i].Visible = false;
            }
        }

        timeLeft = TimerSeconds;
        labelTimer.Text = timeLeft.ToString();
        labelTimer.ForeColor = Color.FromArgb(124, 108, 248);
        gameTimer.Start();
    }

    private void UpdateProgressBar()
    {
        int fullWidth = panelProgressBar.Width;
        int filled = (int)(fullWidth * (double)questionIndex / TotalQuestions);
        panelProgressFill.Size = new Size(Math.Max(filled, 4), panelProgressFill.Height);
    }

    private void gameTimer_Tick(object sender, EventArgs e)
    {
        timeLeft--;
        labelTimer.Text = timeLeft.ToString();
        if (timeLeft <= 5)
            labelTimer.ForeColor = Color.FromArgb(248, 113, 113);

        if (timeLeft <= 0)
        {
            gameTimer.Stop();
            if (!answered) CheckAnswer(null);
        }
    }

    private void CheckAnswer(string? chosenText)
    {
        if (current == null || answered) return;
        answered = true;
        gameTimer.Stop();

        var buttons = new[] { button1, button2, button3, button4 };
        Button? chosenButton = null;
        foreach (var b in buttons)
        {
            if (b.Visible && b.Text == chosenText) chosenButton = b;
            b.Enabled = false;
        }

        bool isRight = chosenText == current.Answer;

        if (isRight)
        {
            score += 10;
            correctCount++;
            labelResult.Text = "✅ Верно!";
            labelResult.ForeColor = Color.FromArgb(74, 222, 128);
            if (chosenButton != null)
            {
                chosenButton.BackColor = Color.FromArgb(22, 101, 52);
                chosenButton.ForeColor = Color.White;
                chosenButton.Font = new Font(chosenButton.Font, FontStyle.Bold);
                chosenButton.FlatAppearance.BorderColor = Color.FromArgb(74, 222, 128);
                chosenButton.FlatAppearance.BorderSize = 2;
            }
        }
        else
        {
            labelResult.Text = "❌ Правильный ответ: " + current.Answer;
            labelResult.ForeColor = Color.FromArgb(248, 113, 113);
            if (chosenButton != null)
            {
                chosenButton.BackColor = Color.FromArgb(127, 29, 29);
                chosenButton.ForeColor = Color.White;
                chosenButton.Font = new Font(chosenButton.Font, FontStyle.Bold);
                chosenButton.FlatAppearance.BorderColor = Color.FromArgb(248, 113, 113);
                chosenButton.FlatAppearance.BorderSize = 2;
            }
            // подсветить правильный ответ ярко-зелёным
            foreach (var b in buttons)
            {
                if (b.Visible && b.Text == current.Answer)
                {
                    b.BackColor = Color.FromArgb(22, 101, 52);
                    b.ForeColor = Color.White;
                    b.Font = new Font(b.Font, FontStyle.Bold);
                    b.FlatAppearance.BorderColor = Color.FromArgb(74, 222, 128);
                    b.FlatAppearance.BorderSize = 2;
                }
            }
        }
        labelScore.Text = "⭐ " + score + " очков";

        // короткая пауза перед следующим вопросом
        System.Windows.Forms.Timer pause = new() { Interval = 1200 };
        pause.Tick += (s, e) =>
        {
            pause.Stop();
            pause.Dispose();
            if (!IsDisposed) NextQuestion();
        };
        pause.Start();
    }

    private void ShowResults()
    {
        Hide();
        new ResultForm(correctCount, TotalQuestions).Show();
        Close();
    }

    private void Shuffle(List<string> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    private void buttonExit_Click(object sender, EventArgs e)
    {
        gameTimer.Stop();
        bool confirmed = ConfirmForm.Ask(this, "Выйти из игры? Прогресс будет потерян.");
        if (confirmed)
        {

            this.Close();
        }
        else if (!answered)
        {
            gameTimer.Start();
        }
    }

    private void button1_Click(object sender, EventArgs e) => CheckAnswer(button1.Text);
    private void button2_Click(object sender, EventArgs e) => CheckAnswer(button2.Text);
    private void button3_Click(object sender, EventArgs e) => CheckAnswer(button3.Text);
    private void button4_Click(object sender, EventArgs e) => CheckAnswer(button4.Text);
}