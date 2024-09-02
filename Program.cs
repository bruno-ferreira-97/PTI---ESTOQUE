using System;
using System.Threading.Tasks;
using ControleEstoque;

var gerenciador = new GerenciadorEstoque();


while (true)
{
    Console.Clear();
    Console.WriteLine("Seja Bem vindo ao Hortifruti B&B");
    Console.WriteLine("MENU PRINCIPAL:");
    Console.WriteLine(@"Escolha uma Operacao: 
    [1] - Cadastrar Produto,
    [2] - Listar Produtos,
    [3] - Remover Produtos,
    [4] - Entrada Estoque,
    [5] - Saída Estoque,
    [0] - Sair");

    var escolha = Console.ReadLine();

    switch (escolha)
    {
        case "1":
            gerenciador.AdicionarItem();
            break;
        case "2":
            gerenciador.ListarItens();
            break;
        case "3":
            gerenciador.RemoverItem();
            break;
        case "4":
            gerenciador.EntradaEstoque();
            break; 
        case "5":
            gerenciador.SaidaEstoque();
            break; 
        case "0":
            return; 
        default:
            Console.WriteLine("Opção: " + escolha);
            Console.WriteLine("Opção inválida. Tente novamente.");
            Console.ReadKey();
            break;
    }

}








