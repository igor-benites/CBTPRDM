// CBTPRDM - ADS 671 - Trabalho Pratico 03
// Servico que simula a busca de pacotes usando dados ficticios.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

using RastreioApp.Models;

namespace RastreioApp.Services
{
    public class PacoteService
    {
        private List<Pacote> pacotes = new List<Pacote>()
        {
            new Pacote
            {
                Id = "BR123456789SP",
                Status = "Em transito",
                DataEnvio = new DateTime(2026, 10, 28),
                DataPrevista = new DateTime(2026, 11, 7),
                LocalizacaoAtual = "Centro de Distribuicao - Guarulhos/SP",
                Historico = new List<EventoRastreamento>()
                {
                    new EventoRastreamento
                    {
                        Data = new DateTime(2026, 10, 28, 9, 15, 0),
                        Local = "Santos/SP",
                        Descricao = "Objeto postado"
                    },
                    new EventoRastreamento
                    {
                        Data = new DateTime(2026, 10, 29, 14, 40, 0),
                        Local = "Sao Paulo/SP",
                        Descricao = "Objeto encaminhado para unidade de tratamento"
                    },
                    new EventoRastreamento
                    {
                        Data = new DateTime(2026, 11, 3, 8, 5, 0),
                        Local = "Guarulhos/SP",
                        Descricao = "Objeto em transferencia entre unidades"
                    }
                }
            },
            new Pacote
            {
                Id = "BR987654321RJ",
                Status = "Entregue",
                DataEnvio = new DateTime(2026, 10, 15),
                DataPrevista = new DateTime(2026, 10, 24),
                LocalizacaoAtual = "Rio de Janeiro/RJ",
                Historico = new List<EventoRastreamento>()
                {
                    new EventoRastreamento
                    {
                        Data = new DateTime(2026, 10, 15, 11, 0, 0),
                        Local = "Cubatao/SP",
                        Descricao = "Objeto postado"
                    },
                    new EventoRastreamento
                    {
                        Data = new DateTime(2026, 10, 20, 16, 30, 0),
                        Local = "Rio de Janeiro/RJ",
                        Descricao = "Objeto saiu para entrega ao destinatario"
                    },
                    new EventoRastreamento
                    {
                        Data = new DateTime(2026, 10, 22, 10, 12, 0),
                        Local = "Rio de Janeiro/RJ",
                        Descricao = "Objeto entregue ao destinatario"
                    }
                }
            },
            new Pacote
            {
                Id = "BR555444333MG",
                Status = "Aguardando postagem",
                DataEnvio = new DateTime(2026, 11, 4),
                DataPrevista = new DateTime(2026, 11, 14),
                LocalizacaoAtual = "Loja do remetente - Belo Horizonte/MG",
                Historico = new List<EventoRastreamento>()
                {
                    new EventoRastreamento
                    {
                        Data = new DateTime(2026, 11, 4, 18, 45, 0),
                        Local = "Belo Horizonte/MG",
                        Descricao = "Etiqueta de envio gerada pelo remetente"
                    }
                }
            }
        };

        public Pacote? Buscar(string codigo)
        {
            foreach (Pacote p in pacotes)
            {
                if (p.Id.ToUpper() == codigo.Trim().ToUpper())
                {
                    return p;
                }
            }

            return null;
        }
    }
}
