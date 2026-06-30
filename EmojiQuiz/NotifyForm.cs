namespace EmojiQuiz;

public partial class NotifyForm : Form
{
    public NotifyForm(string message, string icon = "ℹ️")
    {
        InitializeComponent();
        labelMessage.Text = message;
        labelIcon.Text = icon;
    }

    public static void Show(IWin32Window? owner, string message, string icon = "ℹ️")
    {
        using var f = new NotifyForm(message, icon);
        if (owner != null)
            f.ShowDialog(owner);
        else
            f.ShowDialog();
    }
}