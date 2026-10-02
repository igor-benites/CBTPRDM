// CBTPRDM - ADS 671 - Trabalho Pratico 02
// Classe que representa uma tarefa da lista.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

namespace TarefasApp
{
    public class Tarefa
    {
        public string Titulo { get; set; } = "";
        public string Descricao { get; set; } = "";
        public DateTime DataCriacao { get; set; }
        public string Prioridade { get; set; } = "";
    }
}
