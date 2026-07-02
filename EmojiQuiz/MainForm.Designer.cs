namespace EmojiQuiz;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }
    private ComboBox comboCategory;
    private Label labelTitle;
    private Label labelSubtitle;
    private Button buttonPlay;
    private Button buttonAdmin;

    private Panel panelStats;
    private Label labelQuestionsCount;
    private Label labelQuestionsLabel;
    private Label labelGamesCount;
    private Label labelGamesLabel;
    private Label labelRecordCount;
    private Label labelRecordLabel;

    private Label labelTimerSetting;
    private Button btnTimerOff;
    private Button btnTimer15;
    private Button btnTimer30;
    private Label labelQuestionsSetting;
    private Button btnQ5;
    private Button btnQ10;
    private Button btnQ15;

    private Button MakeToggleButton(string text, Point location)
    {
        var btn = new Button();
        btn.Text = text;
        btn.Font = new Font("Segoe UI", 9F);
        btn.ForeColor = Color.FromArgb(136, 133, 170);
        btn.BackColor = Color.FromArgb(30, 30, 46);
        btn.FlatStyle = FlatStyle.Flat;
        btn.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        btn.FlatAppearance.BorderSize = 1;
        btn.Location = location;
        btn.Size = new Size(70, 26);
        btn.Cursor = Cursors.Hand;
        return btn;
    }
    private void InitializeComponent()
    {
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        labelTitle = new Label();
        labelSubtitle = new Label();
        buttonPlay = new Button();
        buttonAdmin = new Button();
        comboCategory = new ComboBox();
        panelStats = new Panel();
        labelQuestionsCount = new Label();
        labelQuestionsLabel = new Label();
        labelGamesCount = new Label();
        labelGamesLabel = new Label();
        labelRecordCount = new Label();
        labelRecordLabel = new Label();
        // --- Таймер ---
        labelTimerSetting = new Label();
        labelTimerSetting.Text = "ТАЙМЕР";
        labelTimerSetting.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        labelTimerSetting.ForeColor = Color.FromArgb(136, 133, 170);
        labelTimerSetting.Location = new Point(75, 230);
        labelTimerSetting.Size = new Size(390, 20);

        btnTimerOff = MakeToggleButton("Выкл", new Point(75, 253));
        btnTimer15 = MakeToggleButton("15 сек", new Point(170, 253));
        btnTimer30 = MakeToggleButton("30 сек", new Point(265, 253));

       

        // --- Количество вопросов ---
        labelQuestionsSetting = new Label();
        labelQuestionsSetting.Text = "ВОПРОСОВ В РАУНДЕ";
        labelQuestionsSetting.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        labelQuestionsSetting.ForeColor = Color.FromArgb(136, 133, 170);
        labelQuestionsSetting.Location = new Point(75, 290);
        labelQuestionsSetting.Size = new Size(390, 20);

        btnQ5 = MakeToggleButton("5", new Point(75, 313));
        btnQ10 = MakeToggleButton("10", new Point(170, 313));
        btnQ15 = MakeToggleButton("15", new Point(265, 313));

      
        SuspendLayout();

        labelTitle.Text = "🎬 Угадай по эмодзи";
        labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(168, 154, 249);
        labelTitle.AutoSize = false;
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        labelTitle.Location = new Point(0, 60);
        labelTitle.Size = new Size(420, 50);

        // панель статистики (три карточки в ряд)
        panelStats.BackColor = Color.FromArgb(13, 13, 20);
        panelStats.Location = new Point(15, 145);
        panelStats.Size = new Size(390, 70);

        // карточка 1 — количество вопросов
        var card1 = new Panel();
        card1.BackColor = Color.FromArgb(30, 30, 46);
        card1.Location = new Point(0, 0);
        card1.Size = new Size(120, 60);

        labelQuestionsCount.Text = "0";
        labelQuestionsCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        labelQuestionsCount.ForeColor = Color.White;
        labelQuestionsCount.AutoSize = false;
        labelQuestionsCount.TextAlign = ContentAlignment.MiddleCenter;
        labelQuestionsCount.Location = new Point(0, 5);
        labelQuestionsCount.Size = new Size(120, 30);

        labelQuestionsLabel.Text = "Вопросов";
        labelQuestionsLabel.Font = new Font("Segoe UI", 8F);
        labelQuestionsLabel.ForeColor = Color.FromArgb(136, 133, 170);
        labelQuestionsLabel.AutoSize = false;
        labelQuestionsLabel.TextAlign = ContentAlignment.MiddleCenter;
        labelQuestionsLabel.Location = new Point(0, 35);
        labelQuestionsLabel.Size = new Size(120, 20);

        card1.Controls.Add(labelQuestionsCount);
        card1.Controls.Add(labelQuestionsLabel);

        // карточка 2 — игр сыграно
        var card2 = new Panel();
        card2.BackColor = Color.FromArgb(30, 30, 46);
        card2.Location = new Point(135, 0);
        card2.Size = new Size(120, 60);

        labelGamesCount.Text = "0";
        labelGamesCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        labelGamesCount.ForeColor = Color.White;
        labelGamesCount.AutoSize = false;
        labelGamesCount.TextAlign = ContentAlignment.MiddleCenter;
        labelGamesCount.Location = new Point(0, 5);
        labelGamesCount.Size = new Size(120, 30);

        labelGamesLabel.Text = "Игр сыграно";
        labelGamesLabel.Font = new Font("Segoe UI", 8F);
        labelGamesLabel.ForeColor = Color.FromArgb(136, 133, 170);
        labelGamesLabel.AutoSize = false;
        labelGamesLabel.TextAlign = ContentAlignment.MiddleCenter;
        labelGamesLabel.Location = new Point(0, 35);
        labelGamesLabel.Size = new Size(120, 20);

        card2.Controls.Add(labelGamesCount);
        card2.Controls.Add(labelGamesLabel);

        // карточка 3 — рекорд
        var card3 = new Panel();
        card3.BackColor = Color.FromArgb(30, 30, 46);
        card3.Location = new Point(270, 0);
        card3.Size = new Size(120, 60);

        labelRecordCount.Text = "0";
        labelRecordCount.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        labelRecordCount.ForeColor = Color.White;
        labelRecordCount.AutoSize = false;
        labelRecordCount.TextAlign = ContentAlignment.MiddleCenter;
        labelRecordCount.Location = new Point(0, 5);
        labelRecordCount.Size = new Size(120, 30);

        labelRecordLabel.Text = "Рекорд";
        labelRecordLabel.Font = new Font("Segoe UI", 8F);
        labelRecordLabel.ForeColor = Color.FromArgb(136, 133, 170);
        labelRecordLabel.AutoSize = false;
        labelRecordLabel.TextAlign = ContentAlignment.MiddleCenter;
        labelRecordLabel.Location = new Point(0, 35);
        labelRecordLabel.Size = new Size(120, 20);

        card3.Controls.Add(labelRecordCount);
        card3.Controls.Add(labelRecordLabel);

        panelStats.Controls.Add(card1);
        panelStats.Controls.Add(card2);
        panelStats.Controls.Add(card3);

        labelSubtitle.Text = "Кино, сериалы и не только";
        labelSubtitle.Font = new Font("Segoe UI", 11F);
        labelSubtitle.ForeColor = Color.FromArgb(136, 133, 170);
        labelSubtitle.AutoSize = false;
        labelSubtitle.TextAlign = ContentAlignment.MiddleCenter;
        labelSubtitle.Location = new Point(0, 110);
        labelSubtitle.Size = new Size(420, 30);

        buttonPlay.Text = "▶  Играть";
        buttonPlay.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        buttonPlay.ForeColor = Color.White;
        buttonPlay.BackColor = Color.FromArgb(124, 108, 248);
        buttonPlay.FlatStyle = FlatStyle.Flat;
        buttonPlay.FlatAppearance.BorderSize = 0;
        buttonPlay.Location = new Point(60, 400);
        buttonPlay.Size = new Size(300, 60);
        buttonPlay.Cursor = Cursors.Hand;
        buttonPlay.Click += buttonPlay_Click;

        comboCategory.Font = new Font("Segoe UI", 10F);
        comboCategory.ForeColor = Color.White;
        comboCategory.BackColor = Color.FromArgb(30, 30, 46);
        comboCategory.FlatStyle = FlatStyle.Flat;
        comboCategory.DropDownStyle = ComboBoxStyle.DropDownList;
        comboCategory.Location = new Point(15, 355);
        comboCategory.Size = new Size(390, 30);

        buttonAdmin.Text = "⚙  Администратор";
        buttonAdmin.Font = new Font("Segoe UI", 12F);
        buttonAdmin.ForeColor = Color.FromArgb(240, 238, 252);
        buttonAdmin.BackColor = Color.FromArgb(30, 30, 46);
        buttonAdmin.FlatStyle = FlatStyle.Flat;
        buttonAdmin.FlatAppearance.BorderColor = Color.White;
        buttonAdmin.FlatAppearance.BorderSize = 1;
        buttonAdmin.Location = new Point(60, 475);
        buttonAdmin.Size = new Size(300, 50);
        buttonAdmin.Cursor = Cursors.Hand;
        buttonAdmin.Click += buttonAdmin_Click;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(13, 13, 20);
        ClientSize = new Size(420, 540);

        Controls.Add(labelTitle);
        Controls.Add(labelSubtitle);
        Controls.Add(buttonPlay);
        Controls.Add(buttonAdmin);
        Controls.Add(panelStats);
        Controls.Add(labelTimerSetting);
        Controls.Add(btnTimerOff);
        Controls.Add(btnTimer15);
        Controls.Add(btnTimer30);
        Controls.Add(labelQuestionsSetting);
        Controls.Add(btnQ5);
        Controls.Add(btnQ10);
        Controls.Add(btnQ15);
        Text = "Угадай по эмодзи";
        StartPosition = FormStartPosition.CenterScreen;
        Controls.Add(comboCategory);
        ResumeLayout(false);
    }
}