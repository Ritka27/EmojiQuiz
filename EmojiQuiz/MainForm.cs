namespace EmojiQuiz;

public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
    }
    private void Form1_Load(object sender, EventArgs e)
    {

    }
    private void buttonPlay_Click(object sender, EventArgs e)
    {
        new GameForm().Show();
    }

    private void buttonAdmin_Click(object sender, EventArgs e)
    {
        new AdminForm().Show();
    }
}