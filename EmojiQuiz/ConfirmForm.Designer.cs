namespace EmojiQuiz;

partial class ConfirmForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private Label labelIcon;
    private Label labelMessage;
    private Button buttonYes;
    private Button buttonNo;

    private void InitializeComponent()
    {
        labelIcon = new Label();
        labelMessage = new Label();
        buttonYes = new Button();
        buttonNo = new Button();
        SuspendLayout();

        labelIcon.Text = "❓";
        labelIcon.Font = new Font("Segoe UI Emoji", 26F);
        labelIcon.ForeColor = Color.White;
        labelIcon.AutoSize = false;
        labelIcon.TextAlign = ContentAlignment.MiddleCenter;
        labelIcon.Location = new Point(0, 25);
        labelIcon.Size = new Size(340, 45);

        labelMessage.Font = new Font("Segoe UI", 11F);
        labelMessage.ForeColor = Color.FromArgb(240, 238, 252);
        labelMessage.AutoSize = false;
        labelMessage.TextAlign = ContentAlignment.MiddleCenter;
        labelMessage.Location = new Point(20, 80);
        labelMessage.Size = new Size(300, 60);

        buttonYes.Text = "Да";
        buttonYes.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        buttonYes.ForeColor = Color.White;
        buttonYes.BackColor = Color.FromArgb(124, 108, 248);
        buttonYes.FlatStyle = FlatStyle.Flat;
        buttonYes.FlatAppearance.BorderSize = 0;
        buttonYes.Location = new Point(40, 160);
        buttonYes.Size = new Size(120, 42);
        buttonYes.Cursor = Cursors.Hand;
        buttonYes.Click += buttonYes_Click;

        buttonNo.Text = "Нет";
        buttonNo.Font = new Font("Segoe UI", 11F);
        buttonNo.ForeColor = Color.FromArgb(240, 238, 252);
        buttonNo.BackColor = Color.FromArgb(30, 30, 46);
        buttonNo.FlatStyle = FlatStyle.Flat;
        buttonNo.FlatAppearance.BorderColor = Color.FromArgb(60, 60, 80);
        buttonNo.FlatAppearance.BorderSize = 1;
        buttonNo.Location = new Point(180, 160);
        buttonNo.Size = new Size(120, 42);
        buttonNo.Cursor = Cursors.Hand;
        buttonNo.Click += buttonNo_Click;

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(18, 18, 28);
        ClientSize = new Size(340, 225);
        ControlBox = false;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Controls.Add(labelIcon);
        Controls.Add(labelMessage);
        Controls.Add(buttonYes);
        Controls.Add(buttonNo);
        Text = "";
        StartPosition = FormStartPosition.CenterParent;
        ResumeLayout(false);
    }
}