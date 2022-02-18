using System;

class carro
{
    private int velMax;

    public int vm
    {
        get
        {
            return velMax;
        }
        set
        {
            if(value < 0)
            {
                velMax = 0;
            }
            else if(value > 300)
            {
                velMax = 300;
            }
            else
            {
                velMax = value;
            }
        }

    }
     public carro()
        {
            this.velMax = 250;
        }
}

class aula41
{
    static void Main()
    {
        carro c1 = new carro();

        c1.vm = 2000;

        Console.WriteLine("Velocidade:{0}", c1.vm);
    }
}