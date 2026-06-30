namespace EmojiQuiz;

public partial class ConfirmForm : Form
{
    public bool Confirmed { get; private set; } = false;

    public ConfirmForm(string message)
    {
        InitializeComponent();
        labelMessage.Text = message;
    }

    private void buttonYes_Click(object sender, EventArgs e)
    {
        Confirmed = true;
        DialogResult = DialogResult.Yes;
    }

    private void buttonNo_Click(object sender, EventArgs e)
    {
        Confirmed = false;
        DialogResult = DialogResult.No;
    }
    public static bool Ask(IWin32Window owner, string message)
    {
        using var f = new ConfirmForm(message);
        f.ShowDialog(owner);
        return f.Confirmed;
    }
}