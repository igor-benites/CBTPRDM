// CBTPRDM - ADS 671 - Trabalho Pratico 03
// ViewModel do rastreamento: guarda o codigo digitado, executa a busca no
// servico e expoe o pacote encontrado e o historico para as paginas.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;
using RastreioApp.Models;
using RastreioApp.Services;

namespace RastreioApp.ViewModels
{
    public class RastreamentoViewModel : INotifyPropertyChanged
    {
        private PacoteService servico = new PacoteService();

        private string codigoRastreamento = "";
        private Pacote? pacote;
        private string mensagem = "";

        public event PropertyChangedEventHandler? PropertyChanged;

        // Avisa a MainPage que a busca deu certo, para ela navegar ate os resultados.
        public event EventHandler? PacoteLocalizado;

        public ObservableCollection<EventoRastreamento> Historico { get; set; }
            = new ObservableCollection<EventoRastreamento>();

        public ICommand BuscarCommand { get; set; }

        public RastreamentoViewModel()
        {
            BuscarCommand = new ComandoSimples(Buscar);
        }

        public string CodigoRastreamento
        {
            get { return codigoRastreamento; }
            set
            {
                codigoRastreamento = value;
                Notificar("CodigoRastreamento");
            }
        }

        public Pacote? Pacote
        {
            get { return pacote; }
            set
            {
                pacote = value;
                Notificar("Pacote");
            }
        }

        public string Mensagem
        {
            get { return mensagem; }
            set
            {
                mensagem = value;
                Notificar("Mensagem");
                Notificar("TemMensagem");
            }
        }

        public bool TemMensagem
        {
            get { return mensagem != ""; }
        }

        private void Buscar()
        {
            if (string.IsNullOrWhiteSpace(CodigoRastreamento))
            {
                Mensagem = "Digite o codigo de rastreamento do pacote.";
                return;
            }

            Pacote? encontrado = servico.Buscar(CodigoRastreamento);

            if (encontrado == null)
            {
                Mensagem = "Pacote nao encontrado. Confira o codigo digitado.";
                return;
            }

            Mensagem = "";
            Pacote = encontrado;

            Historico.Clear();
            foreach (EventoRastreamento evento in encontrado.Historico)
            {
                Historico.Add(evento);
            }

            if (PacoteLocalizado != null)
            {
                PacoteLocalizado(this, EventArgs.Empty);
            }
        }

        private void Notificar(string propriedade)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propriedade));
            }
        }
    }
}
