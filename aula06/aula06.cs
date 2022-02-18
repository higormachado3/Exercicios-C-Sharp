using System;

class aula06{

    static void Main(){

    double valorcompra = 5.90;
    double valorvenda;
    double lucro = 0.1;
    string produto = "Pastel";

    valorvenda = valorcompra+(valorcompra * lucro);

    Console.WriteLine("\nproduto......:{0,10}", produto);
    Console.WriteLine("\nVal.compra......:{0,10:c}", valorcompra);
    Console.WriteLine("\nlucro......:{0,10:p}", lucro);
    Console.WriteLine("\nVal.venda......:{0,10:c}", valorvenda);
    
        
        
    }
}