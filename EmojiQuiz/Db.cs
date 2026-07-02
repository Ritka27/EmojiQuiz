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
    public static int CountByCategory(string? category)
    {
        using var ctx = new QuizContext();
        if (string.IsNullOrEmpty(category))
            return ctx.Questions.Count();
        return ctx.Questions.Count(q => q.Category == category);
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
    public static Question? GetRandom(string? category = null)
    {
        using var ctx = new QuizContext();
        var query = ctx.Questions.AsQueryable();
        if (!string.IsNullOrEmpty(category))
            query = query.Where(q => q.Category == category);

        return query
            .OrderBy(q => EF.Functions.Random())
            .FirstOrDefault();
    }
    public static List<string> GetWrongAnswers(string correct, int count, string? category = null)
    {
        using var ctx = new QuizContext();

        // сначала пробуем найти неправильные ответы в той же категории
        var fromCategory = ctx.Questions
            .Where(q => q.Answer != correct);
        if (!string.IsNullOrEmpty(category))
            fromCategory = fromCategory.Where(q => q.Category == category);

        var result = fromCategory
            .OrderBy(q => EF.Functions.Random())
            .Select(q => q.Answer)
            .Take(count)
            .ToList();

        // если не хватило — добираем из всех остальных категорий
        if (result.Count < count)
        {
            int missing = count - result.Count;
            var extra = ctx.Questions
                .Where(q => q.Answer != correct && !result.Contains(q.Answer))
                .OrderBy(q => EF.Functions.Random())
                .Select(q => q.Answer)
                .Take(missing)
                .ToList();
            result.AddRange(extra);
        }

        return result;
    }
    public static List<string> GetCategories()
    {
        using var ctx = new QuizContext();
        return ctx.Questions
            .Select(q => q.Category)
            .Distinct()
            .OrderBy(c => c)
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
    public static Stats GetStats()
    {
        using var ctx = new QuizContext();
        var stats = ctx.Stats.FirstOrDefault();
        if (stats == null)
        {
            stats = new Stats();
            ctx.Stats.Add(stats);
            ctx.SaveChanges();
        }
        return stats;
    }

    public static void UpdateStats(int score)
    {
        using var ctx = new QuizContext();
        var stats = ctx.Stats.FirstOrDefault();
        if (stats == null)
        {
            stats = new Stats();
            ctx.Stats.Add(stats);
        }
        stats.GamesPlayed++;
        if (score > stats.BestScore)
            stats.BestScore = score;
        ctx.SaveChanges();
    }

    public static List<Question> GetAll()
    {
        using var ctx = new QuizContext();
        return ctx.Questions.OrderBy(q => q.Category).ThenBy(q => q.Answer).ToList();
    }

    public static void Delete(int id)
    {
        using var ctx = new QuizContext();
        var q = ctx.Questions.Find(id);
        if (q != null)
        {
            ctx.Questions.Remove(q);
            ctx.SaveChanges();
        }
    }
}