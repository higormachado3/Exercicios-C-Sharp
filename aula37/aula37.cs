using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor de classe Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor de classe Derivada1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor de classe Derivada2");
    }
}

class ex037
{
    static void Main()
    {
        Derivada2 derivada2 = new Derivada2();
    }
}