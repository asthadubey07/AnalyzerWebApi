public class TestClass
{
    public string? Name;

    public void DoStuff()
    {
        string? risky = null;
        Console.WriteLine(risky.Length); // Nullable warning!
    }
}
