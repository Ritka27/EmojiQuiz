namespace EmojiQuiz;

partial class AdminForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private Label labelTitle;
    private Label labelEmoji;
    private TextBox textEmoji;
    private Label labelAnswer;
    private TextBox textAnswer;
    private Label labelCategory;
    private TextBox textCategory;
    private Button buttonAdd;
    private Button buttonBack;
    private Label labelListTitle;
    private ListBox listQuestions;
    private Button buttonDelete;

    private void InitializeComponent()
    {
        labelTitle = new Label();
        labelEmoji = new Label();
        textEmoji = new TextBox();
        labelAnswer = new Label();
        textAnswer = new TextBox();
        labelCategory = new Label();
        textCategory = new TextBox();
        buttonAdd = new Button();
        buttonBack = new Button();
        labelListTitle = new Label();
        listQuestions = new ListBox();
        buttonDelete = new Button();
        SuspendLayout();

        labelTitle.Text = "⚙ Администратор";
        labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(168, 154, 249);
        labelTitle.AutoSize = false;
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        labelTitle.Location = new Point(0, 20);
        labelTitle.Size = new Size(420, 40);

        labelEmoji.Text = "Эмодзи";
        labelEmoji.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        labelEmoji.ForeColor = Color.FromArgb(136, 133, 170);
        labelEmoji.Location = new Point(60, 70);
        labelEmoji.Size = new Size(300, 18);

        textEmoji.Font = new Font("Segoe UI Emoji", 12F);
        textEmoji.ForeColor = Color.White;
        textEmoji.BackColor = Color.FromArgb(30, 30, 46);
        textEmoji.BorderStyle = BorderStyle.FixedSingle;
        textEmoji.Location = new Point(60, 88);
        textEmoji.Size = new Size(300, 28);

        labelAnswer.Text = "Ответ (название)";
        labelAnswer.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        labelAnswer.ForeColor = Color.FromArgb(136, 133, 170);
        labelAnswer.Location = new Point(60, 123);
        labelAnswer.Size = new Size(300, 18);

        textAnswer.Font = new Font("Segoe UI", 11F);
        textAnswer.ForeColor = Color.White;
        textAnswer.BackColor = Color.FromArgb(30, 30, 46);
        textAnswer.BorderStyle = BorderStyle.FixedSingle;
        textAnswer.Location = new Point(60, 141);
        textAnswer.Size = new Size(300, 28);

        labelCategory.Text = "Категория";
        labelCategory.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        labelCategory.ForeColor = Color.FromArgb(136, 133, 170);
        labelCategory.Location = new Point(60, 176);
        labelCategory.Size = new Size(300, 18);

        textCategory.Font = new Font("Segoe UI", 11F);
        textCategory.ForeColor = Color.White;
        textCategory.BackColor = Color.FromArgb(30, 30, 46);
        textCategory.BorderStyle = BorderStyle.FixedSingle;
        textCategory.Text = "Фильмы";
        textCategory.Location = new Point(60, 194);
        textCategory.Size = new Size(300, 28);

        buttonAdd.Text = "+ Добавить";
        buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        buttonAdd.ForeColor = Color.White;
        buttonAdd.BackColor = Color.FromArgb(124, 108, 248);
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.FlatAppearance.BorderSize = 0;
        buttonAdd.Location = new Point(60, 235);
        buttonAdd.Size = new Size(300, 42);
        buttonAdd.Cursor = Cursors.Hand;
        buttonAdd.Click += buttonAdd_Click;

        labelListTitle.Text = "ВОПРОСЫ В БАЗЕ";
        labelListTitle.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
        labelListTitle.ForeColor = Color.FromArgb(136, 133, 170);
        labelListTitle.Location = new Point(60, 290);
        labelListTitle.Size = new Size(300, 18);

        listQuestions.Font = new Font("Segoe UI", 9F);
        listQuestions.ForeColor = Color.White;
        listQuestions.BackColor = Color.FromArgb(30, 30, 46);
        listQuestions.BorderStyle = BorderStyle.FixedSingle;
        listQuestions.Location = new Point(60, 308);
        listQuestions.Size = new Size(300, 110);

        buttonDelete.Text = "🗑 Удалить выбранный";
        buttonDelete.Font = new Font("Segoe UI", 10F);
        buttonDelete.ForeColor = Color.FromArgb(248, 113, 113);
        buttonDelete.BackColor = Color.FromArgb(30, 30, 46);
        buttonDelete.FlatStyle = FlatStyle.Flat;
        buttonDelete.FlatAppearance.BorderColor = Color.FromArgb(248, 113, 113);
        buttonDelete.FlatAppearance.BorderSize = 1;
        buttonDelete.Location = new Point(60, 425);
        buttonDelete.Size = new Size(300, 36);
        buttonDelete.Cursor = Cursors.Hand;
        buttonDelete.Click += buttonDelete_Click;

        buttonBack.Text = "← Назад в меню";
        buttonBack.Font = new Font("Segoe UI", 10F);
        buttonBack.ForeColor = Color.FromArgb(136, 133, 170);
        buttonBack.BackColor = Color.FromArgb(13, 13, 20);
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.FlatAppearance.BorderSize = 0;
        buttonBack.Location = new Point(60, 470);
        buttonBack.Size = new Size(300, 30);
        buttonBack.Cursor = Cursors.Hand;
        buttonBack.Click += buttonBack_Click;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(13, 13, 20);
        ClientSize = new Size(420, 520);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        Controls.Add(labelTitle);
        Controls.Add(labelEmoji);
        Controls.Add(textEmoji);
        Controls.Add(labelAnswer);
        Controls.Add(textAnswer);
        Controls.Add(labelCategory);
        Controls.Add(textCategory);
        Controls.Add(buttonAdd);
        Controls.Add(labelListTitle);
        Controls.Add(listQuestions);
        Controls.Add(buttonDelete);
        Controls.Add(buttonBack);
        Text = "Администратор";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
        PerformLayout();
    }
}