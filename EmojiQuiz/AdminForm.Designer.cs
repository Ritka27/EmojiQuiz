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

    private void InitializeComponent()
    {
        FormBorderStyle = FormBorderStyle.FixedSingle;
        MaximizeBox = false;
        labelTitle = new Label();
        labelEmoji = new Label();
        textEmoji = new TextBox();
        labelAnswer = new Label();
        textAnswer = new TextBox();
        labelCategory = new Label();
        textCategory = new TextBox();
        buttonAdd = new Button();
        buttonBack = new Button();
        SuspendLayout();

        labelTitle.Text = "⚙ Администратор";
        labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(168, 154, 249);
        labelTitle.AutoSize = false;
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        labelTitle.Location = new Point(0, 20);
        labelTitle.Size = new Size(420, 40);

        labelEmoji.Text = "Эмодзи:";
        labelEmoji.Font = new Font("Segoe UI", 10F);
        labelEmoji.ForeColor = Color.FromArgb(136, 133, 170);
        labelEmoji.Location = new Point(30, 90);
        labelEmoji.Size = new Size(150, 25);

        textEmoji.Font = new Font("Segoe UI Emoji", 12F);
        textEmoji.ForeColor = Color.White;
        textEmoji.BackColor = Color.FromArgb(30, 30, 46);
        textEmoji.BorderStyle = BorderStyle.FixedSingle;
        textEmoji.Location = new Point(30, 115);
        textEmoji.Size = new Size(360, 30);

        labelAnswer.Text = "Ответ (название):";
        labelAnswer.Font = new Font("Segoe UI", 10F);
        labelAnswer.ForeColor = Color.FromArgb(136, 133, 170);
        labelAnswer.Location = new Point(30, 160);
        labelAnswer.Size = new Size(200, 25);

        textAnswer.Font = new Font("Segoe UI", 11F);
        textAnswer.ForeColor = Color.White;
        textAnswer.BackColor = Color.FromArgb(30, 30, 46);
        textAnswer.BorderStyle = BorderStyle.FixedSingle;
        textAnswer.Location = new Point(30, 185);
        textAnswer.Size = new Size(360, 30);

        labelCategory.Text = "Категория:";
        labelCategory.Font = new Font("Segoe UI", 10F);
        labelCategory.ForeColor = Color.FromArgb(136, 133, 170);
        labelCategory.Location = new Point(30, 230);
        labelCategory.Size = new Size(200, 25);

        textCategory.Font = new Font("Segoe UI", 11F);
        textCategory.ForeColor = Color.White;
        textCategory.BackColor = Color.FromArgb(30, 30, 46);
        textCategory.BorderStyle = BorderStyle.FixedSingle;
        textCategory.Text = "Фильмы";
        textCategory.Location = new Point(30, 255);
        textCategory.Size = new Size(360, 30);

        buttonAdd.Text = "➕ Добавить";
        buttonAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
        buttonAdd.ForeColor = Color.White;
        buttonAdd.BackColor = Color.FromArgb(124, 108, 248);
        buttonAdd.FlatStyle = FlatStyle.Flat;
        buttonAdd.FlatAppearance.BorderSize = 0;
        buttonAdd.Location = new Point(30, 310);
        buttonAdd.Size = new Size(360, 50);
        buttonAdd.Cursor = Cursors.Hand;
        buttonAdd.Click += buttonAdd_Click;

        buttonBack.Text = "← Назад в меню";
        buttonBack.Font = new Font("Segoe UI", 10F);
        buttonBack.ForeColor = Color.FromArgb(136, 133, 170);
        buttonBack.BackColor = Color.FromArgb(13, 13, 20);
        buttonBack.FlatStyle = FlatStyle.Flat;
        buttonBack.FlatAppearance.BorderSize = 0;
        buttonBack.Location = new Point(30, 370);
        buttonBack.Size = new Size(360, 35);
        buttonBack.Cursor = Cursors.Hand;
        buttonBack.Click += buttonBack_Click;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(13, 13, 20);
        ClientSize = new Size(420, 430);
        Controls.Add(labelTitle);
        Controls.Add(labelEmoji);
        Controls.Add(textEmoji);
        Controls.Add(labelAnswer);
        Controls.Add(textAnswer);
        Controls.Add(labelCategory);
        Controls.Add(textCategory);
        Controls.Add(buttonAdd);
        Controls.Add(buttonBack);
        Text = "Администратор";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
        PerformLayout();
    }
}