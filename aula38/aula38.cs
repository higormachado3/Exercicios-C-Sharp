using System;

class Base
{
    public Base()
    {
        Console.WriteLine("Construtor de classe Base");
    }

    virtual public void info()
    {
        Console.WriteLine("Base");
    }
}

class Derivada1 : Base
{
    public Derivada1()
    {
        Console.WriteLine("Construtor de classe Derivada1");
    }

    public override void info()
    {
        Console.WriteLine("Derivada 1");
    }
}

class Derivada2 : Derivada1
{
    public Derivada2()
    {
        Console.WriteLine("Construtor de classe Derivada2");
    }

    public override void info()
    {
        Console.WriteLine("Derivada 2");
    }
}

class ex037
{
    static void Main()
    {
        Base Ref;

        Derivada1 derivada1 = new Derivada1();
        Derivada2 derivada2 = new Derivada2();

        Ref = derivada1;

        Ref.info();

    }
}