using System;

class impar{

    static void Main(){

        int x,y;

        Console.Write("\n\tDigite um numero:\t");
        x = int.Parse(Console.ReadLine());

        y = x % 2;

        if(y == 1){
            Console.WriteLine("\n\tO numero informado e impar");

        } else {

           Console.WriteLine("\n\tO numero informado e par");  
        }

    }
}