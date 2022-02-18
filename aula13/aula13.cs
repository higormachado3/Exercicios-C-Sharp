using System;

class aula12{

    static void Main(){

    int n1, n2, n3, n4, resul;

    string status;

    Console.Write("Digite a nota 1: ");
    n1 = int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 2: ");
    n2 = int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 3: ");
    n3 = int.Parse(Console.ReadLine());

    Console.Write("Digite a nota 4: ");
    n4 = int.Parse(Console.ReadLine());

    resul = n1+n2+n3+n4;

    if(resul < 40){
        status = "Reprovado";
    }else if(resul < 60){
        status = "Recuperação";
    }else{
         status = "Aprovado";
    }

    
    Console.WriteLine("\n Nota: {0}\n Resultado: {1}\n", resul, status);
    }
}