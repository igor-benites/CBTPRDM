// CBTPRDM - ADS 671 - Trabalho Pratico 02
// Code-behind da pagina inicial: carrega a lista, abre os detalhes da tarefa
// selecionada e abre o modal de adicao de tarefas.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

namespace TarefasApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        // Recarrega a lista toda vez que a pagina volta a aparecer,
        // assim as alteracoes feitas nos modais ficam visiveis.
        protected override void OnAppearing()
        {
            base.OnAppearing();
            CarregarLista();
        }

        private void CarregarLista()
        {
            listViewTarefas.ItemsSource = null;
            listViewTarefas.ItemsSource = Dados.Tarefas;
        }

        private async void OnTarefaSelecionada(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
            {
                return;
            }

            Tarefa tarefa = (Tarefa)e.SelectedItem;
            listViewTarefas.SelectedItem = null;

            await Navigation.PushAsync(new DetalhePage(tarefa));
        }

        private async void OnAdicionarClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new AdicionarPage()));
        }
    }
}
