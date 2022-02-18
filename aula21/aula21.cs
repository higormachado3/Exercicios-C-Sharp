using System;
class aula21{

static void Main(){

string senha = "123";
string usersenha;
int tentativas=0; 

do{

    Console.Clear();
    Console.WriteLine("Digite a senha:\t");
    usersenha = Console.ReadLine();
    tentativas ++;

}while(senha != usersenha);

    Console.Clear();
    Console.WriteLine("Senha correta, Tentativas {0}", tentativas);

}
}
