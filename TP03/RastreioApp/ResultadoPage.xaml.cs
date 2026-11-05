// CBTPRDM - ADS 671 - Trabalho Pratico 03
// Code-behind da pagina de resultados. Recebe o ViewModel ja preenchido pela
// pagina inicial e o utiliza como BindingContext.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

using RastreioApp.ViewModels;

namespace RastreioApp
{
    public partial class ResultadoPage : ContentPage
    {
        public ResultadoPage(RastreamentoViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
