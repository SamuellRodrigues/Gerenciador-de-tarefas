namespace Tarefas
{
    class Tarefa
    {
        public static void Tarefa1S()
        {
            Console.WriteLine("1 - Adiconar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover tarefa ");
            Console.WriteLine("0 - sair");
            Console.Write("Escolha uma pção:");
            string opcao = Console.ReadLine();
            switch(opcao)
            {
                 case "1":
                    AdicionarTarefa(tarefas);
                    break;
                case "2":
                    ListarTarefas(tarefas);
                    break;
                case "3":
                    ConcluirTarefa(tarefas);
                    break;
                case "4":
                    RemoverTarefa(tarefas);
                    break;
                case "5":
                    rodando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;


            }
        }
    }
}