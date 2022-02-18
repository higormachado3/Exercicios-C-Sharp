using System;

class veiculo
{
    public int velAtual;

    private int velMax;

    protected bool ligado;

    public veiculo(int velMax)
    {
        velAtual = 0;
        this.velMax = velMax;
        ligado = false;

    }

    public bool getLigado()
    {
        return ligado;
    }

    public int getVelMax()
    {
        return velMax;
    }
}

class carro:veiculo // Deivada de Veiculo
{
    public string nome;

    public carro(string nome, int vm) : base(vm)
    {
        this.nome = nome;
        ligado = true;
    }

}



class aula36
{
    static void Main()
    {
        carro carro = new carro("Lancer", 280);

        Console.WriteLine("Nome:..........{0}", carro.nome);
        Console.WriteLine("Velocida Max:..{0}", carro.getVelMax());
        Console.WriteLine("Ligado:........{0}", carro.getLigado());
    }
}