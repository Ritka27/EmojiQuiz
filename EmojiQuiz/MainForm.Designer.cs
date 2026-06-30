namespace EmojiQuiz;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private Label labelTitle;
    private Label labelSubtitle;
    private Button buttonPlay;
    private Button buttonAdmin;

    private void InitializeComponent()
    {
        labelTitle = new Label();
        labelSubtitle = new Label();
        buttonPlay = new Button();
        buttonAdmin = new Button();
        SuspendLayout();

        labelTitle.Text = "🎬 Угадай по эмодзи";
        labelTitle.Font = new Font("Segoe UI", 20F, FontStyle.Bold);
        labelTitle.ForeColor = Color.FromArgb(168, 154, 249);
        labelTitle.AutoSize = false;
        labelTitle.TextAlign = ContentAlignment.MiddleCenter;
        labelTitle.Location = new Point(0, 60);
        labelTitle.Size = new Size(420, 50);

        labelSubtitle.Text = "Викторина по фильмам";
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
        buttonPlay.Location = new Point(60, 220);
        buttonPlay.Size = new Size(300, 60);
        buttonPlay.Cursor = Cursors.Hand;
        buttonPlay.Click += buttonPlay_Click;

        buttonAdmin.Text = "⚙  Администратор";
        buttonAdmin.Font = new Font("Segoe UI", 12F);
        buttonAdmin.ForeColor = Color.FromArgb(240, 238, 252);
        buttonAdmin.BackColor = Color.FromArgb(30, 30, 46);
        buttonAdmin.FlatStyle = FlatStyle.Flat;
        buttonAdmin.FlatAppearance.BorderColor = Color.White;
        buttonAdmin.FlatAppearance.BorderSize = 1;
        buttonAdmin.Location = new Point(60, 300);
        buttonAdmin.Size = new Size(300, 50);
        buttonAdmin.Cursor = Cursors.Hand;
        buttonAdmin.Click += buttonAdmin_Click;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(13, 13, 20);
        ClientSize = new Size(420, 420);
        Controls.Add(labelTitle);
        Controls.Add(labelSubtitle);
        Controls.Add(buttonPlay);
        Controls.Add(buttonAdmin);
        Text = "Угадай по эмодзи";
        StartPosition = FormStartPosition.CenterScreen;
        ResumeLayout(false);
    }
}