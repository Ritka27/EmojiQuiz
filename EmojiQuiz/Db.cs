using Microsoft.EntityFrameworkCore;
namespace EmojiQuiz;
static class Db
{
    public static void EnsureCreated()
    {
        using var ctx = new QuizContext();
        ctx.Database.EnsureCreated();
    }
    public static int Count()
    {
        using var ctx = new QuizContext();
        return ctx.Questions.Count();
    }
    public static void Add(string emoji, string answer, string category)
    {
        using var ctx = new QuizContext();
        ctx.Questions.Add(new Question { Emoji = emoji, Answer = answer, Category = category ?? "" });
        ctx.SaveChanges();
    }
    public static bool Exists(string answer)
    {
        using var ctx = new QuizContext();
        return ctx.Questions.Any(q => q.Answer.ToLower() == answer.ToLower());
    }
    public static Question? GetRandom()
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .OrderBy(q => EF.Functions.Random())
            .FirstOrDefault();
    }
    public static List<string> GetWrongAnswers(string correct, int count)
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .Where(q => q.Answer != correct)
            .OrderBy(q => EF.Functions.Random())
            .Select(q => q.Answer)
            .Take(count)
            .ToList();
    }
    public static void SeedFromFile(string path)
    {
        if (Count() > 0) return;
        using var ctx = new QuizContext();
        foreach (var line in File.ReadLines(path, System.Text.Encoding.UTF8).Skip(1))
        {
            var p = line.Split('\t');
            if (p.Length < 3) continue;
            ctx.Questions.Add(new Question { Emoji = p[2], Answer = p[1], Category = "Фильмы" });
        }
        ctx.SaveChanges();
    }
}