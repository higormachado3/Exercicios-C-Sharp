using System;

class aula24{

    static void Main(){
        
        int a, b, r;

        Console.Write("\nDigite um valor:\t");

        a = Convert.ToInt32(Console.ReadLine());

        Console.Write("\nDigite um valor:\t");

        b = Convert.ToInt32(Console.ReadLine());

        r = soma(a , b);
        
        Console.WriteLine("O valor da soma de {0} com {1} e igual a {3}", a, b, r);
    
    }

    static int soma(int n1, int n2){

        int res = n1 + n2;

        return res;

    }
}