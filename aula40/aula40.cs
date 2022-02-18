using System;

sealed class veiculos
{
    public string name = "Higor Machado";

}

class aula40
{
    static void Main()
    {
        string n;

        veiculos Veiculos = new veiculos();
      
        n = Veiculos.name;

        Console.WriteLine(n);
    }
}