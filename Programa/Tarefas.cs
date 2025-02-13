using Layout;

namespace GerenciarTarefa
{
   public class Tarefa 
   {

    public int Id {get; private set; }
    public string Descricao {get; set;}
    public bool Concluida {get; set;}
    public Tarefa(int id, string descricao)
    {
        Id = id;
        Descricao = descricao;
        Concluida = false;
    }
    public void ExibirTarefa()
    {
        Formatacao.Cor($"\t[{(Concluida ? "x" : " ")}] ID: {Id} - {Descricao}", ConsoleColor.Yellow);
    }
    
   } 
}