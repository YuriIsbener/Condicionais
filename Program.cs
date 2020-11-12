using System;

namespace Condicionais
{
    class Program
    {
        static void Main(string[] args)
        {
            //aqui vai o código do nosso programa
            //C# é uma linguangem case sensitive
            //Pode mudar o conteudo de uma variavel no meio do código
            //Variavel = tipo + nome 
            //operadores lógicos 
            // == igualdade
            // > Maior
            // < Menor
            // >= Maior ou igual
            // <= Menor ou igual
            // && E
            // || Ou

            //Entrada de dados

            float primeiraNota, segundaNota, terceiraNota;
            double media;
            string nomeCompleto;

            Console.Write("Digite o nome do aluno:");
            nomeCompleto = Console.ReadLine();

            Console.Write("Digite a primeira nota:");
            primeiraNota = float.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota:");
            segundaNota = float.Parse(Console.ReadLine());
            
            Console.Write("Digite a terceira nota:");
            terceiraNota = float.Parse(Console.ReadLine());
            
            //Processamento
            media = (primeiraNota+segundaNota+terceiraNota)/3;

            //Saida de dados
            if(media>5){
                //Valor verdadeiro
                Console.WriteLine(nomeCompleto+" está aprovado com uma média de: "+media);
            }else{
                //Valor falso
                Console.WriteLine(nomeCompleto+" está reprovado com uma média de: "+media);
            }
    
        }
    }
}
