namespace EmojiQuiz;

partial class NotifyForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null)) components.Dispose();
        base.Dispose(disposing);
    }

    private Label labelIcon;
    private Label labelMessage;
    private Button buttonOk;

    private void InitializeComponent()
    {
        labelIcon = new Label();
        labelMessage = new Label();
        buttonOk = new Button();
        SuspendLayout();

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
        labelMessage.Size = new Size(300, 70);

        buttonOk.Text = "ОК";
        buttonOk.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
        buttonOk.ForeColor = Color.White;
        buttonOk.BackColor = Color.FromArgb(124, 108, 248);
        buttonOk.FlatStyle = FlatStyle.Flat;
        buttonOk.FlatAppearance.BorderSize = 0;
        buttonOk.Location = new Point(110, 165);
        buttonOk.Size = new Size(120, 42);
        buttonOk.Cursor = Cursors.Hand;
        buttonOk.DialogResult = DialogResult.OK;
        buttonOk.Click += (s, e) => Close();

        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(18, 18, 28);
        ClientSize = new Size(340, 225);
        ControlBox = false;
        FormBorderStyle = FormBorderStyle.FixedDialog;
        Controls.Add(labelIcon);
        Controls.Add(labelMessage);
        Controls.Add(buttonOk);
        Text = "";
        StartPosition = FormStartPosition.CenterParent;
        ResumeLayout(false);
    }
}