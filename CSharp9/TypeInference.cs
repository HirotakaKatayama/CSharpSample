using System.Collections.Generic;

// ターゲットからの new 型推論
class Sample
{
    // フィールドに対しては var が使えない。
    // 代わりに new 型推論を使うと便利なことがある(特に、型名が長い時)。
    Dictionary<string, List<(int x, int y)>> _cache = new();
}

// 条件演算子のターゲット型推論
class Sample2
{
    void M(bool b)
    {
        // int? を明示するとコンパイルできる(var だとダメ)。
        int? i = b ? 1 : null;

        // Base を明示するとコンパイルできる(var だとダメ)
        Base c = b ? new A() : new B();
    }

    class Base { }
    class A : Base { }
    class B : Base { }
}
