using System;

abstract class veiculo
{
    protected int velMax;
    protected int velAtual;
    protected bool ligado;

    public veiculo()
    {
        ligado = false;
        velAtual= 0;
    }

    public void setLigado(bool ligado)
    {
        this.ligado = ligado;
    }

    public int getVelatual()
    {
        return velAtual;
    }

    abstract public void aceleracao(int mult);

}

class carros : veiculo
{
    public carros()
    {
        velMax = 120;
    }

     override public void aceleracao(int mult)
    {
        velAtual += 10*mult;
    }
}

class aula39
{
    static void Main()
    {
        carros carro1 = new carros();

        carro1.aceleracao(5);
        


        Console.WriteLine(carro1.getVelatual());
    } 
}