using System;

class jogador{

    private string name;

    private int energia;

    private jogador(string name){

        this.name = name;

        this.energia = 100;

    }

    public int getEnergia(){
        return energia;
    }

    public string getName(){

        return name;
    }

}

class aula33{

    static void Main(){

        jogador j1=new jogador("Bruno");

        Console.WriteLine("Nome....{0}", j1.name);
        Console.WriteLine("Energia....{0}", j1.energia);

    }
}