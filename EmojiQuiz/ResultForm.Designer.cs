namespace EmojiQuiz;

partial class ResultForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private Label labelEmoji;
    private Label labelTitle;
    private Label labelScore;
    private Label labelStats;
    private Button buttonAgain;
    private Button buttonMenu;

    private void InitializeComponent()
    {
        labelEmoji = new Label();
        labelTitle = new Label();
        labelScore = new Label();
        labelStats = new Label();
        buttonAgain = new Button();
        buttonMenu = new Button();
        SuspendLayout();

        labelEmoji.Font = new Font("Segoe UI Emoji", 40F);
        labelEmoji.ForeColor = Color.White;
        labelEmoji.AutoSize = false;
        labelEmoji.TextAlign = ContentAlignment.MiddleCenter;
        labelEmoji.Location = new Point(0, 40);
        labelEmoji.Size = new Size(420, 70);

        labelTitle.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(240, 238, 252);
        labelTitle.AutoSize = false;
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        labelTitle.Location = new Point(0, 115);
        labelTitle.Size = new Size(420, 35);

        labelScore.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
        labelScore.ForeColor = Color.FromArgb(168, 154, 249);
        labelScore.AutoSize = false;
        labelScore.TextAlign = ContentAlignment.MiddleCenter;
        labelScore.Location = new Point(0, 165);
        labelScore.Size = new Size(420, 60);

        labelStats.Font = new Font("Segoe UI", 11F);
        labelStats.ForeColor = Color.FromArgb(136, 133, 170);
        labelStats.AutoSize = false;
        labelStats.TextAlign = ContentAlignment.MiddleCenter;
        labelStats.Location = new Point(0, 230);
        labelStats.Size = new Size(420, 40);

        buttonAgain.Text = "🔄  Играть снова";
        buttonAgain.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
        buttonAgain.ForeColor = Color.White;
        buttonAgain.BackColor = Color.FromArgb(124, 108, 248);
        buttonAgain.FlatStyle = FlatStyle.Flat;
        buttonAgain.FlatAppearance.BorderSize = 0;
        buttonAgain.Location = new Point(60, 300);
        buttonAgain.Size = new Size(300, 55);
        buttonAgain.Cursor = Cursors.Hand;
        buttonAgain.Click += buttonAgain_Click;

        buttonMenu.Text = "В главное меню";
        buttonMenu.Font = new Font("Segoe UI", 11F);
        buttonMenu.ForeColor = Color.FromArgb(136, 133, 170);
        buttonMenu.BackColor = Color.FromArgb(13, 13, 20);
        buttonMenu.FlatStyle = FlatStyle.Flat;
        buttonMenu.FlatAppearance.BorderSize = 0;
        buttonMenu.Location = new Point(60, 365);
        buttonMenu.Size = new Size(300, 35);
        buttonMenu.Cursor = Cursors.Hand;
        buttonMenu.Click += buttonMenu_Click;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(13, 13, 20);
        ClientSize = new Size(420, 430);
        Controls.Add(labelEmoji);
        Controls.Add(labelTitle);
        Controls.Add(labelScore);
        Controls.Add(labelStats);
        Controls.Add(buttonAgain);
        Controls.Add(buttonMenu);
        Text = "Результат";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
    }
}