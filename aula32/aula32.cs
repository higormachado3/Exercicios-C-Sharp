using System;

class calculos{

    public int v1;

    public int v2;

    public  calculos(int v1, int v2){

        this.v1 = v1;

        this.v2 = v2;
    }

    public int somar(){

    return v1 + v2;

    }
}

class aula31{

    static void Main(){

     calculos x=new calculos(10,3);

     Console.WriteLine(x.somar());

    }
}