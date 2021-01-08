using System;

namespace VALIDACAOSENHA
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Validação de senha");
            Console.WriteLine("----------------------");

            Console.WriteLine("Digite seu nome :");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a senha :");
            string senha = Console.ReadLine();

            while(nome == senha){

            Console.WriteLine("Senha inválida - Digite uma senha diferete por favor");
            Console.WriteLine("Digite a senha:");
            senha = Console.ReadLine();

            }
            Console.WriteLine("Usuario cadastrado com sucesso");




        }
    }
}
