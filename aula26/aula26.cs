using System;

class aula26{

    static void Main(){

       int x, y, q, r;
       x = 10;
       y = 7;
       q = divide(x, y, out r);

       Console.WriteLine("\n{0} / {1}: Quociente={2} e Resto{3}\n", x, y, q, r);
    }

    static int divide(int dividendo, int divisor, out int resto){
        int quocinte;
        quocinte = dividendo / divisor;
        resto = dividendo % divisor;
        return quocinte;
    }
}