using System;

class aula14{
     static void Main(){
    
     int n1, n2, n3, n4, resul;
 
     string status = "NULL";

     Console.Write("Digite a nota 1: ");
     n1 = int.Parse(Console.ReadLine());

     Console.Write("Digite a nota 2: ");
     n2 = int.Parse(Console.ReadLine());

     Console.Write("Digite a nota 3: ");
     n3 = int.Parse(Console.ReadLine());

     Console.Write("Digite a nota 4: ");
     n4 = int.Parse(Console.ReadLine());

     resul = n1+n2+n3+n4;

     if(resul < 60){

       if(resul < 80){

           if(resul < 99){

           status = "Master Ultra Power Aprovado";

           }

           status = "Aprovado Com Mestria";
         }
           status = "Aprovado";
    
    } else if(resul < 50){

         status = "Recuperação";
         
         if(resul < 40){

          status = "Reprovado";

         }
    }
     Console.WriteLine("\n Nota: {0}\n Resultado: {1}\n", resul, status);

   
     
    }
}