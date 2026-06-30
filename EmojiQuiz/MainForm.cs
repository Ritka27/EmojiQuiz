namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        LoadCategories();
    }

    private void LoadCategories()
    {
        var categories = Db.GetCategories();
        comboCategory.Items.Add("Все категории");
        foreach (var c in categories)
            comboCategory.Items.Add(c);
        comboCategory.SelectedIndex = 0;
    }

    private void buttonPlay_Click(object sender, EventArgs e)
    {
        string? selected = comboCategory.SelectedItem?.ToString();
        string? category = (selected == "Все категории") ? null : selected;

        int available = Db.CountByCategory(category);
        if (available < 4)
        {
            bool proceed = ConfirmForm.Ask(this,
                "В этой категории мало вопросов (" + available + "). " +
                "Вариантов ответа будет меньше обычного. Всё равно продолжить?");
            if (!proceed) return;
        }


        new GameForm(category).Show();
    }

    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        new AdminForm().Show();
    }
}