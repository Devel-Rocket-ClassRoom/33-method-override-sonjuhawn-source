using System;

// README.md를 읽고 코드를 작성하세요.
Console.WriteLine("=== 경주 시작! ===");

Vehicle[] vehicle = new Vehicle[3];
vehicle[0] = new Car("스포츠카", 120);
vehicle[1] = new AirPlane("보잉747", 900);
vehicle[2] = new Boat("요트", 60);

foreach (Vehicle v in vehicle)
{
    v.Move();
}

class Vehicle
{
    public string Name;
    public int Speed;

    public virtual void Move()
    {
        Console.WriteLine($"{Name}이(가) 이동합니다. 속도: {Speed}km/h");
    }
}
class Car : Vehicle
{
     public Car(string name,int speed)
    {
        Name = name;
        Speed = speed;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 도로를 달립니다! 속도: {Speed}km/h");
    }
}
class AirPlane : Vehicle
{
    public AirPlane(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 하늘을 납니다! 속도: {Speed}km/h");
    }
}
class Boat : Vehicle
{
    public Boat(string name, int speed)
    {
        Name = name;
        Speed = speed;
    }
    public override void Move()
    {
        Console.WriteLine($"{Name}이(가) 바다를 항해합니다! 속도: {Speed}km/h");
    }
}