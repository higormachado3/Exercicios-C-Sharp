using System;

class operando
{
    public int res;

    public int Somando(int num1, int num2)
    {
        res = num1 + num2;

        return res;
       
    }
}




class ex001
{
    static void Main()
    {
      
      operando operando1 = new operando();

      operando1.Somando(4,5);



      Console.WriteLine(operando1.res);

    }
}