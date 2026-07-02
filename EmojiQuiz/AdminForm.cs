namespace EmojiQuiz;

public partial class AdminForm : Form
{
    private List<Question> allQuestions = new();

    public AdminForm()
    {
        InitializeComponent();
        LoadQuestions();
    }

    private void LoadQuestions()
    {
        allQuestions = Db.GetAll();
        listQuestions.Items.Clear();
        foreach (var q in allQuestions)
            listQuestions.Items.Add($"{q.Emoji}  {q.Answer}  [{q.Category}]");
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        string emoji = textEmoji.Text.Trim();
        string answer = textAnswer.Text.Trim();
        string cat = textCategory.Text.Trim();

        if (emoji == "" || answer == "")
        {
            NotifyForm.Show(this, "Заполните эмодзи и ответ.", "⚠️");
            return;
        }

        if (ContainsLettersOrDigits(emoji))
        {
            NotifyForm.Show(this, "В поле «Эмодзи» можно вводить только эмодзи, без букв и цифр.", "⚠️");
            return;
        }

        if (Db.Exists(answer))
        {
            NotifyForm.Show(this, "Такой вопрос уже есть в базе.", "🔁");
            return;
        }

        Db.Add(emoji, answer, cat);
        NotifyForm.Show(this, "Вопрос успешно добавлен!", "✅");

        textEmoji.Clear();
        textAnswer.Clear();
        textCategory.Text = "Фильмы";
        LoadQuestions();
    }

    private void buttonDelete_Click(object sender, EventArgs e)
    {
        if (listQuestions.SelectedIndex < 0)
        {
            NotifyForm.Show(this, "Выберите вопрос из списка для удаления.", "⚠️");
            return;
        }

        var selected = allQuestions[listQuestions.SelectedIndex];
        bool confirmed = ConfirmForm.Ask(this,
            $"Удалить вопрос «{selected.Answer}»?");

        if (confirmed)
        {
            Db.Delete(selected.Id);
            LoadQuestions();
            NotifyForm.Show(this, "Вопрос удалён.", "🗑");
        }
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        Close();
    }

    private bool ContainsLettersOrDigits(string text)
    {
        foreach (char c in text)
            if (char.IsLetterOrDigit(c)) return true;
        return false;
    }
}