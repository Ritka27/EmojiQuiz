namespace EmojiQuiz;

public partial class MainForm : Form
{
    private int selectedTimer = 15;
    private int selectedQuestions = 10;

    public MainForm()
    {
        

        InitializeComponent();

        btnTimerOff.Click += (s, e) => SelectTimer(0);
        btnTimer15.Click += (s, e) => SelectTimer(15);
        btnTimer30.Click += (s, e) => SelectTimer(30);
        btnQ5.Click += (s, e) => SelectQuestions(5);
        btnQ10.Click += (s, e) => SelectQuestions(10);
        btnQ15.Click += (s, e) => SelectQuestions(15);

        LoadCategories();
        LoadStats();
        SelectTimer(15);
        SelectQuestions(10);
    }

    private void SelectTimer(int seconds)
    {
        selectedTimer = seconds;
        var active = Color.FromArgb(124, 108, 248);
        var inactive = Color.FromArgb(30, 30, 46);
        var activeBorder = Color.FromArgb(168, 154, 249);
        var inactiveBorder = Color.FromArgb(60, 60, 80);

        btnTimerOff.BackColor = seconds == 0 ? active : inactive;
        btnTimerOff.FlatAppearance.BorderColor = seconds == 0 ? activeBorder : inactiveBorder;
        btnTimerOff.ForeColor = seconds == 0 ? Color.White : Color.FromArgb(136, 133, 170);

        btnTimer15.BackColor = seconds == 15 ? active : inactive;
        btnTimer15.FlatAppearance.BorderColor = seconds == 15 ? activeBorder : inactiveBorder;
        btnTimer15.ForeColor = seconds == 15 ? Color.White : Color.FromArgb(136, 133, 170);

        btnTimer30.BackColor = seconds == 30 ? active : inactive;
        btnTimer30.FlatAppearance.BorderColor = seconds == 30 ? activeBorder : inactiveBorder;
        btnTimer30.ForeColor = seconds == 30 ? Color.White : Color.FromArgb(136, 133, 170);
    }

    private void SelectQuestions(int count)
    {
        selectedQuestions = count;
        var active = Color.FromArgb(124, 108, 248);
        var inactive = Color.FromArgb(30, 30, 46);
        var activeBorder = Color.FromArgb(168, 154, 249);
        var inactiveBorder = Color.FromArgb(60, 60, 80);

        btnQ5.BackColor = count == 5 ? active : inactive;
        btnQ5.FlatAppearance.BorderColor = count == 5 ? activeBorder : inactiveBorder;
        btnQ5.ForeColor = count == 5 ? Color.White : Color.FromArgb(136, 133, 170);

        btnQ10.BackColor = count == 10 ? active : inactive;
        btnQ10.FlatAppearance.BorderColor = count == 10 ? activeBorder : inactiveBorder;
        btnQ10.ForeColor = count == 10 ? Color.White : Color.FromArgb(136, 133, 170);

        btnQ15.BackColor = count == 15 ? active : inactive;
        btnQ15.FlatAppearance.BorderColor = count == 15 ? activeBorder : inactiveBorder;
        btnQ15.ForeColor = count == 15 ? Color.White : Color.FromArgb(136, 133, 170);
    }

    private void LoadCategories()
    {
        var categories = Db.GetCategories();
        comboCategory.Items.Add("Все категории");
        foreach (var c in categories)
            comboCategory.Items.Add(c);
        comboCategory.SelectedIndex = 0;
    }

    private void LoadStats()
    {
        var stats = Db.GetStats();
        labelQuestionsCount.Text = Db.Count().ToString();
        labelGamesCount.Text = stats.GamesPlayed.ToString();
        labelRecordCount.Text = stats.BestScore.ToString();
    }

    protected override void OnShown(EventArgs e)
    {
        base.OnShown(e);
        LoadStats();
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

        var game = new GameForm(category, selectedTimer, selectedQuestions);
        game.FormClosed += (s, e) => { Show(); LoadStats(); };
        Hide();
        game.Show();
    }

    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        var admin = new AdminForm();
        admin.FormClosed += (s, e) => LoadStats();
        admin.Show();
    }
}