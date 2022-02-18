using System;

class idade{

static void Main(){

    float[] idade=new float[5];
    float aux, res=0, media;

    for(int i=0; i<5; i++){

        Console.Write("\nDigite a idade do {0}º aluno:\t", i+1);
        idade[i] = float.Parse(Console.ReadLine());

        aux = idade[i];

        res = aux + res;
        
    }

    media = res / 5;

    Console.WriteLine("\nA idade média dos 5 alunos é igual a:\t{0}\n", media);


    
}
}