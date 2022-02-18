using System;

class aula12{

    static void Main(){

    int n1, n2, n3, n4;

    string status = "Reprovado", aux;

    Console.Write("Digite a nota 1: ");
    n1 = int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 2: ");
    n2 = int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 3: ");
    n3 = int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 4: ");
    n4 = int.Parse(Console.ReadLine());

    res = n1+n2+n3+n4;

    if(res >=60){
        status = "Aprovado";
        Console.WriteLine("\n Nota: {0}\n Resultado: {1}\n", res, status);
    }

    Console.WriteLine("\n Nota: {0}\n Resultado: {1}\n", res, status);



    }
}