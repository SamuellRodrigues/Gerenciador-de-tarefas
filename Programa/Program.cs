using System;
using GerenciarTarefa;
using Layout;

class Program
{
    static void ImprimirCabecalho()
    {
        Formatacao.Cor("============================", ConsoleColor.Cyan);
        Formatacao.Cor("   GERENCIADOR DE TAREFAS   ", ConsoleColor.Cyan);
        Formatacao.Cor("============================", ConsoleColor.Cyan);
    }

    static void Main()
    {
        ImprimirCabecalho();

        while (true)
        {
            Console.WriteLine("\n1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("\nEscolha uma opção: ");
            string opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    Console.Write("Digite a descrição da tarefa: ");
                    string descricao = Console.ReadLine();
                    Gerenciador.AdicionarTarefa(descricao);
                    break;
                case "2":
                    Gerenciador.ListarTarefas();
                    break;
                case "3":
                    Console.Write("Digite o ID da tarefa concluída: ");
                    int idConcluir = int.Parse(Console.ReadLine());
                    Gerenciador.ConcluirTarefa(idConcluir);
                    break;
                case "4":
                    Console.Write("Digite o ID da tarefa a ser removida: ");
                    int idRemover = int.Parse(Console.ReadLine());
                    Gerenciador.RemoverTarefa(idRemover);
                    break;
                case "0":
                    return;
                default:
                    Formatacao.Cor("Opção inválida!", ConsoleColor.Red);
                    break;
            }
        }
    }
}

