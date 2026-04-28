class Program
{
    static void Main()
    {
        using var context = new AppDbContext();
        context.Database.EnsureCreated();

        Console.WriteLine("Database Created 👍");
    }
}