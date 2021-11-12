namespace CSharp10;

internal class Lambda
{
    void f()
    {
        var f =
            [A]
            [return: B]
            static int ([C] int x)
            => x;
    }

    void f1()
    {
        // C# 9.0 までは
        // Func<string, int> f = m;
        // みたいに書かないとダメだった(ターゲット型推論)。
        var f = m;
        Delegate d = m;
        MulticastDelegate md = m;
    }
}

internal class PropertyPatternEx
{
    void run()
    {
        m(null);
        m(new X { Name = "" });
        m(new X { Name = "a" });
        m(new X { Name = "abc" });
    }

    static void m(X? x)
    {
        if (x is { Name.Length: 1 }) // { Name: { Length: 1 } } と同じ
        {
            Console.WriteLine("single-char Name");
        }
    }

    class X
    {
        public string? Name { get; set; }
    }
}

internal class Disassembly
{
    void run()
    {
        int x;
        (x, var u) = (1, 2);
    }
}