using System;


class aula22{

    static void Main(){

        int max = 10;

        int[] n=new int[max];

        for(int i=0; i<max; i++ ){

            Console.Write("\nDigite o valor do vetor[{0}]:\t", i);
            n[i] = int.Parse(Console.ReadLine());
    
        }
        
        foreach(int i in n){
            
            Console.WriteLine(i);
        }
    }
}