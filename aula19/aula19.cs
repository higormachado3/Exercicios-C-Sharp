using System;

class aula19{

    static void Main(){
    
    int n;
    Console.Write("Deseja contar ate que numero:\t");
    n = int.Parse(Console.ReadLine());

    for(int i=0; i<=n; i++){

        Console.WriteLine("\nContagem:\t{0}", i);
    }


    }
}