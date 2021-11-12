namespace CSharp10;


#region record struct
record struct Value(int X, int Y);

record class Ref(int X, int Y);
// 上と同じ
record Ref1(int X, int Y);

#endregion

#region 構造体の引数なしコンストラクタ
struct A
{
    public int X;
    public A() => X = 0;
}
#endregion
