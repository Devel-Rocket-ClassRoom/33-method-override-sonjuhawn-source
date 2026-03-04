using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("'''");
Parent parent = new Parent();
parent.Work();
Child chlid = new Child();
chlid.Work();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Animal animal = new Animal();
animal.Eat();
Cat cat = new Cat();    
cat.Eat();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Child1 child1 = new Child1();
child1.Say();
child1.Run();
child1.Walk();
Parent1 parent1 = new Parent1();
parent1.Say();
parent1.Run();
parent1.Walk();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Calculator calculator = new Calculator();
calculator.Add(1, 2);
calculator.Add(1.5, 2.5);
calculator.Add(1, 2, 3);

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Animal1 animal1 = new Animal1();
animal1.Speak();
Dog1 dog1= new Dog1();
dog1.Speak();
Cat1 cat1= new Cat1();  
cat1.Speak();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Child2 child2 = new Child2();
child2.Greet();

Console.WriteLine("'''\n");
Parent3 parent3 = new Parent3();    
parent3.Work();
Child3 child3 = new Child3();   
child3.Work();
GrandChild3 grandChild3 = new GrandChild3();
grandChild3.Work();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Parent4 parent4 = new Parent4();
parent4.Work();
Child4 child4 = new Child4();
child4.Work();
GrandChild4 grandChild4 = new GrandChild4();
grandChild4.Work();
grandChild4.Play();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Person p = new Person();
Console.WriteLine(p);
Console.WriteLine(p.ToString());

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Person1 person1 = new Person1("박용준");
person1.ToString();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Character hero = new Character("용사", 10, 100);
hero.ToString();
Character mage = new Character("마법사", 8, 70);
mage.ToString();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Warrior warrior = new Warrior("전사", 50);
warrior.ToString();
Mage mage1 = new Mage("마법사", 60);
mage1.ToString();
Archer archer = new Archer("궁수", 40);
archer.ToString();

warrior.Attack();
mage1.Attack();
archer.Attack();

Console.WriteLine("'''\n");

Console.WriteLine("'''");
Character1[] characters = new Character1[3];
characters[0] = new Warrior("전사", 50);
characters[1] = new Mage("마법사", 60);
characters[2] = new Archer("궁수", 40);

foreach(Character1 character in characters)
{
    character.Attack();
}

Console.WriteLine("'''\n");

class Parent
{
    public virtual void Work()
    {
        Console.WriteLine("프로그래머");
    }
}
class Child : Parent
{
    public override void Work()
    {
        Console.WriteLine("프로게이머");
    }
}

class Animal
{
    public virtual void Eat()
    {
        Console.WriteLine("Animal Eat");
    }
}
class Cat : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Cat Eat");
    }
}

class Parent1
{
    public void Say()
    {
        Console.WriteLine("부모_안녕하세요.");
    }
    public void Run()
    {
        Console.WriteLine("부모_달리다.");
    }
    public virtual void Walk()
    {
        Console.WriteLine("부모_걷다.");
    }
}
class Child1 : Parent1
{
    public new void Say()
    {
        Console.WriteLine("자식_안녕하세요.");
    }
    public new void Run()
    {
        Console.WriteLine("자식_달리다.");
    }
    public override void Walk()
    {
        Console.WriteLine("자식_걷다.");
    }
}

class Calculator
{
    public int Add(int a, int b) => a + b;
    public double Add(double a, double b) => a + b;
    public int Add(int a, int b, int c) => a + b + c;
}

class Animal1
{
    public virtual void Speak()
    {
        Console.WriteLine("동물이 소리를 낸다");
    }
}
class Dog1 : Animal1
{
    public override void Speak()
    {
        Console.WriteLine("멍멍!");
    }
}
class Cat1 : Animal1
{
    public override void Speak()
    {
        Console.WriteLine("야옹!");
    }
}

class Parent2
{
    public virtual void Greet()
    {
        Console.WriteLine("안녕하세요.");
    }
}
class Child2: Parent2
{
    public override void Greet()
    {
        base.Greet();
        Console.WriteLine("반갑습니다.");
    }
}

class Parent3
{
    public virtual void Work()
    {
        Console.WriteLine("프로그래머");
    }
}
class Child3 : Parent3
{
    public override void Work()
    {
        base.Work();
    }
}
class GrandChild3 : Child3
{
    public override void Work()
    {
        Console.WriteLine("프로게이머");
    }
}

class Parent4
{
    public virtual void Work()
    {
        Console.WriteLine("프로그래머");
    }
}
class Child4 : Parent4
{
    public sealed override void Work()
    {
        base.Work();
    }
}
class GrandChild4 : Child4
{
    public void Play()
    {
        Console.WriteLine("프로게이머");
    }
}

class Person
{
    string name;

}

class Person1
{
    string name;
    public Person1(string name)
    {
        this.name = name;
    }
    public override string ToString()
    {
        return $"[Person 클래스: {name}]";
    }
}

class Character
{
    public string Name;
    public int Level;
    public int Health;
    public Character(string name, int level, int health)
    {
        Name = name;
        Level = level;
        Health = health;
    }
    public override string ToString()
    {
        return $"[{Name}] Lv.{Level} HP:{Health}";
    }
}

class Character1
{
    public string Name;
    public int AttackPower;

    public Character1(string name, int attackPower)
    {
        Name = name;
        AttackPower = attackPower;
    }

    public virtual void Attack()
    {
        Console.WriteLine($"{Name}이(가) 공격합니다. 데미지: {AttackPower}");
    }
    public override string ToString()
    {
        return $"[{Name}] 공격력: {AttackPower}";
    }
}
class Warrior: Character1
{
    public Warrior(string name, int attackPower) : base(name, attackPower)
    {
    }
    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) 칼로 베어냅니다! 데미지: {AttackPower}");
    }
}
class Mage : Character1
{
    public Mage(string name, int attackPower) : base(name, attackPower)
    {
    }
    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) 파이어볼을 시전합니다! 데미지: {AttackPower}");
    }
}
class Archer : Character1
{
    public Archer(string name, int attackPower) : base(name, attackPower)
    {
    }
    public void Attack()
    {
        Console.WriteLine($"{Name}이(가) 화살을 쏩니다! 데미지: {AttackPower}");
    }
}