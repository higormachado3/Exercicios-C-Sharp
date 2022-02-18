using System;

class aula27{

static void Main(){

soma(10,5,7,4,3,7,8,9754,5);

}

static void soma(params int[]n){

    int res = 0;

    if(n.Length < 1){
        
        Console.WriteLine("Não existem valores a serem somados");

    } else if(n.Length < 2){

        Console.WriteLine("Valores isuficientes para soma: {0}", n[0]);

    } else{

        for(int i=0; i<n.Length; i++){
            res+=n[i];
        }

        Console.WriteLine("A soma dos valores e igual a: {0}", res);
    }
}
}