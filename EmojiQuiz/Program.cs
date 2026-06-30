namespace EmojiQuiz;

static class Program
{
    public static MainForm MainWindow { get; private set; } = null!;

    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.SetCompatibleTextRenderingDefault(false);

        Db.EnsureCreated();
        Db.SeedFromFile("movies_ru_emoji.tsv");

        MainWindow = new MainForm();
        Application.Run(MainWindow);
    }
}