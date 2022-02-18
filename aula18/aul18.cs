using System;

class aula18{

    static void Main(){

        int[,] n=new int[3,4];

        for(int i=0; i<3; i++){
            for(int j=0; j<4; j++){
               
               Console.Write("\nDigite um numero Correspondete a matriz[{0}][{1}]:\t", i,j);
               n[i,j] = int.Parse(Console.ReadLine());
            }
        }

        for(int i=0; i<3; i++){
            for(int j=0; j<4; j++){
                Console.Write("- {0} -", n[i,j]);
            }
        }

    }
}
