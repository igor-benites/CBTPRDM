// CBTPRDM - ADS 671 - Trabalho Pratico 03
// Modelo que representa um pacote e o seu historico de eventos.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

namespace RastreioApp.Models
{
    public class Pacote
    {
        public string Id { get; set; } = "";
        public string Status { get; set; } = "";
        public DateTime DataEnvio { get; set; }
        public DateTime DataPrevista { get; set; }
        public string LocalizacaoAtual { get; set; } = "";
        public List<EventoRastreamento> Historico { get; set; } = new List<EventoRastreamento>();
    }
}
