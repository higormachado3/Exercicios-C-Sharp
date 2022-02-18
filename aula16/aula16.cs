using System;

class aula15{

    static void Main(){
    
    incio:

    Console.Clear();
     
    char reset;
    int x=0,y=0,aux; 

    Console.WriteLine("Digite O Trasporte escolhido de Ipatinga P/ BH:\n[1] Carro\n[2] Onibûs\n[3] Avião");
    aux = int.Parse(Console.ReadLine());

    switch(aux){

        case 1:
        x = 4;
        y = 30;
        break;

        case 2:
        x = 6;
        y = 10;
        break;

        case 3:
        x = 0;
        y = 50;
        break;

        default:
        x = -1;
        break;
    }

    if(x<0){
        Console.WriteLine("\nMeio de trasporte não disponivel");
    }else{
        Console.WriteLine("\nVocê Gastara {0}:{1} horas ate Belo Horizonte\n", x, y);
    }


    Console.Write("\nDeseja continuar 'S' / 's' ?: ");
    reset = char.Parse(Console.ReadLine());

    if(reset == 'S' || reset == 's'){

        goto incio;

    }else{

     Console.Clear();

     Console.WriteLine("Programa Finalizado");
     
    }


    }
}