// CBTPRDM - ADS 671 - Trabalho Pratico 02
// Code-behind da pagina de detalhes. Recebe a tarefa pelo construtor
// (passagem de dados entre paginas), abre o modal de edicao e exclui a
// tarefa apos a confirmacao do usuario.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

namespace TarefasApp
{
    public partial class DetalhePage : ContentPage
    {
        private Tarefa tarefa;

        public DetalhePage(Tarefa tarefaSelecionada)
        {
            InitializeComponent();
            tarefa = tarefaSelecionada;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            MostrarDados();
        }

        private void MostrarDados()
        {
            lblTitulo.Text = tarefa.Titulo;
            lblDescricao.Text = tarefa.Descricao;
            lblData.Text = tarefa.DataCriacao.ToString("dd/MM/yyyy");
            lblPrioridade.Text = tarefa.Prioridade;
        }

        private async void OnEditarClicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new NavigationPage(new EditarPage(tarefa)));
        }

        private async void OnExcluirClicked(object sender, EventArgs e)
        {
            bool confirmar = await DisplayAlert("Excluir",
                "Deseja realmente excluir a tarefa \"" + tarefa.Titulo + "\"?",
                "Sim", "Nao");

            if (confirmar)
            {
                Dados.Tarefas.Remove(tarefa);
                await DisplayAlert("Excluir", "Tarefa excluida com sucesso!", "OK");
                await Navigation.PopAsync();
            }
        }
    }
}
