using System;

public class Jogador{
     
    public string name = "h";
    public int energia;

   public bool part_jogo;

    public string  time = "a";

}

class aula28{

    static void Main(){
        
        Jogador j1=new Jogador();
        Jogador j2=new Jogador();
        Jogador j3=new Jogador();

    

        Console.WriteLine("O Jogador {0} está no time {1} ", j1.name, j1.time);
    }
}