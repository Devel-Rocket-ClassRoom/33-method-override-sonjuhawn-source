using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("코드를 작성하세요.");

class Product
{
    public string Name;
    public int Price;

    public override string ToString()
    {
        return $"[{Name}] - ₩[{Price:N0}";
    }
    public virtual string GetDescription()
    {

    }
}