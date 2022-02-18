using System;
public class Jogador{
     
    public string name;
    public int energia;
    public bool part_jogo;
    public string  time;

    public Jogador(string n, string t){
        name = n;
        energia = 100;
        part_jogo = true;
        time = t;
    }

    public Jogador(){

        name = "Higor";

        time = "Atletico"; 
    }

    public void info(){

        Console.WriteLine("\n//////////////////////////////////////");
        Console.WriteLine("Nome do Jogador:\t", name);
        Console.WriteLine("Nome do Time:\t", time);
         Console.WriteLine("\n//////////////////////////////////////");
    }


    ~Jogador(){

        Console.WriteLine("\nO jogador {0} foi deletado do sistema", name);
        
    }

    }


class aula30{

    static void Main(){

        string[] nome=new string[3];
        string[] time1=new string[3];
        

        for(int i=0; i<3; i++){
            Console.Write("\nDigite o nome do jogador[{0}]:\t", i+1);
            nome[i] = Console.ReadLine();
        }

        for(int i=0; i<3; i++){
            Console.Write("\nDigite o time do jogador {0} :\t", nome[i]);
            time1[i] = Console.ReadLine();
        }

       Jogador j1=new Jogador(nome[0], time1[0]);
       Jogador j2=new Jogador(nome[1], time1[1]);
       Jogador j3=new Jogador(nome[2], time1[2]);
       Jogador j4=new Jogador();

       j1.info();
       j2.info();
       j3.info();
       j4.info();
    

      // Console.WriteLine("\nO Jogador {0} está no time {1} ", j1.name, j1.time);
      // Console.WriteLine("\nO Jogador {0} está no time {1} ", j2.name, j2.time);
      // Console.WriteLine("\nO Jogador {0} está no time {1} ", j3.name, j3.time);

    }

}
