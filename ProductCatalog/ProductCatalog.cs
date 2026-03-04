using System;
using System.Collections.Generic;
using System.Text;


class Product
{
    public string Name;
    public int Price;

    public Product(string name, int price)
    {
        Name = name;
        Price = price;
    }

    public override string ToString()
    {
        return $"[{Name}] - [{Price:N0}원]";
    }
    public virtual string GetDescription()
    {
        return "상품 설명입니다";
    }
}
class Electronics : Product
{
    public int Waranty;

    public Electronics(string name, int price, int waranty) : base(name, price)
    {
        Waranty = waranty;
    }

    public override string ToString()
    {
        return base.ToString() + $" (보증 {Waranty}개월)";
    }
    public override string GetDescription()
    {
        return "→ 전자기기입니다. 취급에 주의하세요.";
    }
}
class Clothing : Product
{
    public char Size;

    public Clothing(string name, int price, char size) : base(name, price)
    {
        Size = size;
    }
    public override string ToString()
    {
        return base.ToString() + $" (사이즈: {Size})";
    }
    public override string GetDescription()
    {
        return "→ 의류입니다. 세탁 방법을 확인하세요.";
    }
}
class Food : Product
{
    public string ExpirationDate;

    public Food(string name, int price, string expirationdate) : base(name, price)
    {
        ExpirationDate = expirationdate;
    }

    public override string ToString()
    {
        return base.ToString() + $" (유통기한: {ExpirationDate})";
    }
    public override string GetDescription()
    {
        return "→ 식품입니다. 냉장 보관하세요.";
    }
}
