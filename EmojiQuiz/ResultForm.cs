namespace EmojiQuiz;

public partial class ResultForm : Form
{
    public ResultForm(int correct, int total)
    {
        InitializeComponent();
        Db.UpdateStats(correct * 10);

        int pct = total > 0 ? (correct * 100 / total) : 0;

        string emoji, title;
        if (pct >= 90) { emoji = "🏆"; title = "Великолепно!"; }
        else if (pct >= 70) { emoji = "🥈"; title = "Очень хорошо!"; }
        else if (pct >= 50) { emoji = "👍"; title = "Неплохо!"; }
        else if (pct >= 30) { emoji = "📚"; title = "Есть куда расти"; }
        else { emoji = "😔"; title = "Попробуй ещё раз!"; }

        labelEmoji.Text = emoji;
        labelTitle.Text = title;
        labelScore.Text = correct + " / " + total;
        labelStats.Text = "Правильных ответов: " + pct + "%";
    }

    private void buttonAgain_Click(object sender, EventArgs e)
    {
        Close();
        new GameForm(null, GameForm.LastTimer, GameForm.LastQuestions).Show();
    }

    private void buttonMenu_Click(object sender, EventArgs e)
    {
        Close();
    }
}