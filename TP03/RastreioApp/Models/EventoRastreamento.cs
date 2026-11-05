// CBTPRDM - ADS 671 - Trabalho Pratico 03
// Modelo de um evento do historico de rastreamento do pacote.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

namespace RastreioApp.Models
{
    public class EventoRastreamento
    {
        public DateTime Data { get; set; }
        public string Local { get; set; } = "";
        public string Descricao { get; set; } = "";
    }
}
