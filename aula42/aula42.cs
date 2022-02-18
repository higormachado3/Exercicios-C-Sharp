using System;

class carro
{
    private int[] velMax = new int[7]{12, 300, 123, 42, 56, 233, 100};
    

    public int this [int i]
    {
        get
        {
            return velMax[i];
        }
        set
        {
            if(value < 0)
            {
                velMax[i] = 0;
            }
            else if(value > 300)
            {
                velMax[i] = 300;
            }
            else
            {
                velMax[i] = value;
            }
        }

    }
     public carro()
        {
        
        }
}

class aula41
{
    static void Main()
    {
        carro c1 = new carro();
        
        //c1[3] = 10;

        Console.WriteLine("Velocidade:{0}", c1[6]);
    }
}