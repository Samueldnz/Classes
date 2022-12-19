using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exemplo{

    class Program{

        static void Main(string[] args){

            // Cria um objeto da classe Pessoa chamado p1.
            // Inicialmente o objeto é criado sem nenhuma informação.
            // As informações são adicionadas pelos métodos set.
            Pessoa p1 = new Pessoa();
            p1.setNome("Samuel");
            p1.setIdade(20);
            p1.setRg("3243423423");

            // Exibindo valores no Terminal
            Console.WriteLine("Nome.: " + p1.getNome());
            Console.WriteLine("Rg...: " + p1.getRg());
            Console.WriteLine("Idade: " + p1.getIdade());

            Console.WriteLine();
            Console.WriteLine();

            //Criando uma nova pessoa
            Pessoa p2 = new Pessoa("Miguel", "5644456456", 16);

            //exibindo valores no terminal
            Console.WriteLine("Nome.: " + p2.getNome());
            Console.WriteLine("Rg...: " + p2.getRg());
            Console.WriteLine("Idade: " + p2.getIdade());
        }
    }
}



// Usando procedimentos para não repetir código
// ExibirHoraAtual();
// Console.WriteLine("Pressione uma tecla...");
// Console.ReadKey();
// ExibirHoraAtual();

// void ExibirHoraAtual()
// {
//     Console.ForegroundColor = ConsoleColor.Red;
//     Console.WriteLine(DateTime.Now.ToLongTimeString());
//     Console.ResetColor();
// }



