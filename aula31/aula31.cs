using System;

static class funcionario{
  
  static public string name;

  static public int idade;

  static public string empresa;

    static public void dados(string n, int i){

        name = n;

        idade  = i;
        
    }

    static public void chefe(){

        name = "Higor";

        idade  = 19;
    }


    static public void inf(){

        Console.WriteLine("\n\tNome:\t", name);

        Console.WriteLine("\n\tIdade:\t", idade);
    }


    static void Main(){

       funcionario.dados("Higor", 19);
       funcionario.inf();
       funcionario.chefe();

       

       
    }


}