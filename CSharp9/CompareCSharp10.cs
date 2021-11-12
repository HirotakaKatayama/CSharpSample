using System;

namespace CSharp9
{
    // C#10比較用
    
    
    struct A
    {
        public int X;
        public A() => X = 0;
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

            if (x is { Name: { Length: 1 } }) // これはOK
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
}
