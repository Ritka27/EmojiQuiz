namespace EmojiQuiz;

public partial class AdminForm : Form
{
    public AdminForm()
    {
        InitializeComponent();
    }

    private void buttonAdd_Click(object sender, EventArgs e)
    {
        string emoji = textEmoji.Text.Trim();
        string answer = textAnswer.Text.Trim();
        string cat = textCategory.Text.Trim();

        if (emoji == "" || answer == "")
        {
            MessageBox.Show("Заполните эмодзи и ответ.", "Ошибка");
            return;
        }

        Db.Add(emoji, answer, cat);
        MessageBox.Show("Вопрос добавлен!", "Готово");

        textEmoji.Clear();
        textAnswer.Clear();
        textCategory.Text = "Фильмы";
    }

    private void buttonBack_Click(object sender, EventArgs e)
    {
        Close();
    }
}