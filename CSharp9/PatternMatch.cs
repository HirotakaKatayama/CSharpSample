namespace CSharp9
{
    internal class PatternMatch
    {
        // not, and, or や、 <, <=, >, >= などのパターンが増えた。
        int M(uint x) => x switch
        {
            0 or 2 or 4 or 6 or 8 => 0,
            1 or 3 or 5 or 7 or 9 => 1,
            >= 10                 => -1,
        };
    }
}
