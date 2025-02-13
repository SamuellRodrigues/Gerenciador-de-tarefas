
class Program
{
    static List<Tarefa> tarefas = new List<Tarefa>();
    
    static void Main()
    {
        int opcao;
        do
        {
            Console.Clear();
            Console.WriteLine("GERENCIADOR DE TAREFAS\n");
            Console.WriteLine("1 - Adicionar Tarefa");
            Console.WriteLine("2 - Listar Tarefas");
            Console.WriteLine("3 - Concluir Tarefa");
            Console.WriteLine("4 - Remover Tarefa");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            
            if (!int.TryParse(Console.ReadLine(), out opcao))
                continue;
            
            switch (opcao)
            {
                case 1:
                    AdicionarTarefa();
                    break;
                case 2:
                    ListarTarefas();
                    break;
                case 3:
                    ConcluirTarefa();
                    break;
                case 4:
                    RemoverTarefa();
                    break;
            }
        } while (opcao != 0);
    }
    
    static void AdicionarTarefa()
    {
        Console.Write("Digite a descrição da tarefa: ");
        string descricao = Console.ReadLine();
        tarefas.Add(new Tarefa { Id = tarefas.Count + 1, Descricao = descricao, Concluida = false });
        Console.WriteLine("Tarefa adicionada com sucesso!");
        Console.ReadKey();
    }
    
    static void ListarTarefas()
    {
        Console.WriteLine("\nTarefas:");
        foreach (var tarefa in tarefas)
        {
            Console.WriteLine($"[{(tarefa.Concluida ? "X" : " ")}] ID: {tarefa.Id} - {tarefa.Descricao}");
        }
        Console.ReadKey();
    }
    
    static void ConcluirTarefa()
    {
        Console.Write("Digite o ID da tarefa a concluir: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            var tarefa = tarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Console.WriteLine("Tarefa concluída com sucesso!");
            }
            else
                Console.WriteLine("Tarefa não encontrada.");
        }
        Console.ReadKey();
    }
    
    static void RemoverTarefa()
    {
        Console.Write("Digite o ID da tarefa a remover: ");
        if (int.TryParse(Console.ReadLine(), out int id))
        {
            tarefas.RemoveAll(t => t.Id == id);
            Console.WriteLine("Tarefa removida com sucesso!");
        }
        Console.ReadKey();
    }
}

class Tarefa
{
    public int Id { get; set; }
    public string Descricao { get; set; }
    public bool Concluida { get; set; }
}
