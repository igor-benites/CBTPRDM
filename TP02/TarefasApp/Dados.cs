// CBTPRDM - ADS 671 - Trabalho Pratico 02
// Lista de tarefas compartilhada entre as paginas do aplicativo.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

namespace TarefasApp
{
    public static class Dados
    {
        public static List<Tarefa> Tarefas = new List<Tarefa>()
        {
            new Tarefa
            {
                Titulo = "Entregar o TP01",
                Descricao = "Aplicativo de login em MAUI",
                DataCriacao = new DateTime(2026, 9, 10),
                Prioridade = "Alta"
            },
            new Tarefa
            {
                Titulo = "Estudar ListView",
                Descricao = "Ler a documentacao da Microsoft",
                DataCriacao = new DateTime(2026, 9, 25),
                Prioridade = "Media"
            },
            new Tarefa
            {
                Titulo = "Organizar o repositorio",
                Descricao = "Subir os trabalhos no GitHub",
                DataCriacao = new DateTime(2026, 10, 1),
                Prioridade = "Baixa"
            }
        };
    }
}
