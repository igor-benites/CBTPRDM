// CBTPRDM - ADS 671 - Trabalho Pratico 03
// Implementacao de ICommand usada pelos botoes das paginas no padrao MVVM.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

using System.Windows.Input;

namespace RastreioApp.ViewModels
{
    public class ComandoSimples : ICommand
    {
        private Action acao;

        // O botao fica sempre habilitado, por isso o evento nao dispara.
        public event EventHandler? CanExecuteChanged
        {
            add { }
            remove { }
        }

        public ComandoSimples(Action acaoExecutada)
        {
            acao = acaoExecutada;
        }

        public bool CanExecute(object? parameter)
        {
            return true;
        }

        public void Execute(object? parameter)
        {
            acao();
        }
    }
}
