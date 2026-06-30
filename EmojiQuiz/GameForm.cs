namespace EmojiQuiz;

public partial class GameForm : Form
{
    private static readonly Random rng = new();
    private Question? current;
    private int score = 0;

    public GameForm()
    {
        InitializeComponent();
        NextQuestion();
    }

    private void NextQuestion()
    {
        current = Db.GetRandom();
        if (current == null)
        {
            labelEmoji.Text = "База пуста";
            return;
        }

        labelEmoji.Text = current.Emoji;
        labelCategory.Text = current.Category;
        labelResult.Text = "";

        var options = Db.GetWrongAnswers(current.Answer, 3);
        options.Add(current.Answer);
        Shuffle(options);

        var buttons = new[] { button1, button2, button3, button4 };
        for (int i = 0; i < buttons.Length; i++)
        {
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
    }

    private void CheckAnswer(string chosen)
    {
        if (current == null) return;

        if (chosen == current.Answer)
        {
            score++;
            labelResult.Text = "Верно";
            labelResult.ForeColor = Color.FromArgb(74, 222, 128);
        }
        else
        {
            labelResult.Text = "Неверно, это " + current.Answer;
            labelResult.ForeColor = Color.FromArgb(248, 113, 113);
        }
        labelScore.Text = "Счёт: " + score;
        NextQuestion();
    }

    private void Shuffle(List<string> list)
    {
        for (int i = list.Count - 1; i > 0; i--)
        {
            int j = rng.Next(i + 1);
            (list[i], list[j]) = (list[j], list[i]);
        }
    }

    private void button1_Click(object sender, EventArgs e) => CheckAnswer(button1.Text);
    private void button2_Click(object sender, EventArgs e) => CheckAnswer(button2.Text);
    private void button3_Click(object sender, EventArgs e) => CheckAnswer(button3.Text);
    private void button4_Click(object sender, EventArgs e) => CheckAnswer(button4.Text);
}