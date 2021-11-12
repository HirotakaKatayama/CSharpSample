using System;

record Person(string Name, DateTime Birthday);

/*
   以下が自動生成
  ・Equals や GetHashCode や == などの等値判定メソッド
  ・IEquatable<T> インターフェイスの実装も含む
  ・ToString メソッド
  ・後述する with 式で使うクローン メソッド
  ・後述する派生クラス判別のための EqualityContract プロパティ
 */


// 旧来のボイラープレートCode
class PersonOld : IEquatable<PersonOld>
{
    public string Name { get; init; }
    public DateTime Birthday { get; init; }

    public PersonOld(string name, DateTime birthday)
    {
        Name = name;
        Birthday = birthday;
    }

    public bool Equals(PersonOld? other)
        => other is { } person &&
            Name == person.Name &&
            Birthday == person.Birthday;

    public override bool Equals(object? obj)
        => obj is PersonOld person &&
            Name == person.Name &&
            Birthday == person.Birthday;

    public override int GetHashCode()
        => HashCode.Combine(Name, Birthday);

    public override string ToString()
        => $"PersonOld {{ Name = {Name}, Birthday = {Birthday} }}";
}