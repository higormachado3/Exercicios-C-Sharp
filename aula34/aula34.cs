using System;

class Veiculo{
    
    public int rodas;
    public int VelMax;
    public bool ligado;

    public void ligar(){

        ligado = true;
    }

    public void desligar(){

        ligado = false;
    }

    public string getligado(){

        if(ligado){

            return "sim";
        }else{

            return "não";
        }
    }

}

class Carro:Veiculo{
      
    public string nome;
    public string cor;
    public Carro(string nome, string cor){

        desligar();
        rodas = 4;
        VelMax = 120;
        this.nome = nome;
        this.cor = cor;
    }
}
class aula34{

    static void Main(){
     
     Carro c1=new Carro("Lancer","Branco");

     Console.WriteLine("Nome:........{0}", c1.nome);
     Console.WriteLine("Cor:.........{0}", c1.cor);
     Console.WriteLine("Rodas:.......{0}", c1.rodas);
     Console.WriteLine("Velocidade:..{0}", c1.VelMax);
     Console.WriteLine("Ligado:......{0}", c1.getligado());
     
     
    }
}