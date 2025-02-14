namespace GerenciarTarefa
{
    using System.Collections.Generic;
    using Tarefas;
    using Layout;

    public static class Gerenciador
    {
        private static List<Tarefa> listaTarefas = new List<Tarefa>();
        private static int contadorId = 1;

        public static void AdicionarTarefa(string descricao)
        {
            listaTarefas.Add(new Tarefa(contadorId++, descricao));
            Formatacao.Cor("Tarefa adicionada com sucesso!", ConsoleColor.Green);
        }

        public static void ConcluirTarefa(int id)
        {
            Tarefa? tarefa = listaTarefas.Find(t => t.Id == id);
            if (tarefa != null)
            {
                tarefa.Concluida = true;
                Formatacao.Cor("Tarefa concluída!", ConsoleColor.Blue);
            }
            else
            {
                Formatacao.Cor("Tarefa não encontrada!", ConsoleColor.Red);
            }
        }

        public static void ListarTarefas()
        {
            Console.WriteLine("Tarefas:");
            foreach (var tarefa in listaTarefas)
            {
                tarefa.ExibirTarefa();
            }
        }

        public static void RemoverTarefa(int id)
        {
            listaTarefas.RemoveAll(t => t.Id == id);
            Formatacao.Cor("Tarefa removida com sucesso!", ConsoleColor.Yellow);
        }
    }
}