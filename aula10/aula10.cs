using System;

class aula10{

enum DiasSemana{Domingo, Segunda, Terça, Quarta, Quinta, Sexta, Sabado}
   static void Main(){
 
     DiasSemana x = DiasSemana.Sabado;
      
     int y=(int)DiasSemana.Sabado;

     Console.WriteLine(x);

     Console.WriteLine(y);
    
   }

}