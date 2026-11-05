// CBTPRDM - ADS 671 - Trabalho Pratico 03
// Code-behind da pagina inicial. Define o ViewModel como BindingContext e
// navega para a pagina de resultados quando o pacote e localizado.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

using RastreioApp.ViewModels;

namespace RastreioApp
{
    public partial class MainPage : ContentPage
    {
        private RastreamentoViewModel viewModel = new RastreamentoViewModel();

        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
            viewModel.PacoteLocalizado += OnPacoteLocalizado;
        }

        private async void OnPacoteLocalizado(object? sender, EventArgs e)
        {
            await Navigation.PushAsync(new ResultadoPage(viewModel));
        }
    }
}
