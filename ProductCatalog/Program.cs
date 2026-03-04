using System;
using System.Drawing;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 상품 카탈로그 ===");
Product[] product = new Product[3];
product[0] = new Electronics("노트북", 1500000, 24);
product[1] = new Clothing("청바지", 89000, 'M');
product[2] = new Food("우유", 3500, "2026-06-15");

Console.WriteLine(product[0].ToString());
Console.WriteLine(product[0].GetDescription());
Console.WriteLine(product[1].ToString());
Console.WriteLine(product[1].GetDescription());
Console.WriteLine(product[2].ToString());
Console.WriteLine(product[2].GetDescription());

