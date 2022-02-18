using System;

class aula08{

  static void Main(){

     int aux, x, y, res;
    
    Console.Write("\nQual Operação deseja realizar: \n [1] Soma\n [2] Subtração\n [3] Divisão\n [4] Multiplicação\n");
    aux=int.Parse(Console.ReadLine());

    Console.Write("\nDigite Um Numero:\t ");
    x=int.Parse( Console.ReadLine());

    Console.Write("\nDigite Um Numero:\t ");
    y=int.Parse(Console.ReadLine());


    switch(aux){

        case 1:
        res = x + y;
        Console.WriteLine("\nResultado:{0,5}", res);
        break;

        case 2:
        res = x - y;
        Console.WriteLine("\nResultado:{0,5}", res);
        break;

        case 3:
        res = x / y;
        Console.WriteLine("\nResultado:{0,5}", res);
        break;

        case 4:
        res = x * y;
        Console.WriteLine("\nResultado:{0,5}", res);
        break;

        default:
        Console.WriteLine("Operação Invalida Tente Novamente");
        break;
    }

  }

}