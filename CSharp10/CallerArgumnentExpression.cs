using System.Runtime.CompilerServices;

class CAE
{
    static void m(int x, [CallerArgumentExpression("x")] string? expression = null)
    {
        Console.WriteLine($"{expression} = {x}");
    }

    static void run()
    {
        m(2 * 3 * 5);
        // Console: 2 * 3 * 5 = 30
    }
}