// CBTPRDM - ADS 671 - Trabalho Pratico 02
// Code-behind do modal de adicao: valida os campos e inclui a nova tarefa
// na lista do aplicativo.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

namespace TarefasApp
{
    public partial class AdicionarPage : ContentPage
    {
        public AdicionarPage()
        {
            InitializeComponent();
            dtpData.Date = DateTime.Today;
        }

        private async void OnSalvarClicked(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                await DisplayAlert("Atencao", "Informe o titulo da tarefa!", "OK");
                txtTitulo.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtDescricao.Text))
            {
                await DisplayAlert("Atencao", "Informe a descricao da tarefa!", "OK");
                txtDescricao.Focus();
                return;
            }

            if (pckPrioridade.SelectedIndex < 0)
            {
                await DisplayAlert("Atencao", "Selecione a prioridade da tarefa!", "OK");
                return;
            }

            Tarefa nova = new Tarefa();
            nova.Titulo = txtTitulo.Text;
            nova.Descricao = txtDescricao.Text;
            nova.DataCriacao = dtpData.Date ?? DateTime.Today;
            nova.Prioridade = pckPrioridade.Items[pckPrioridade.SelectedIndex];

            Dados.Tarefas.Add(nova);

            await DisplayAlert("Nova Tarefa", "Tarefa adicionada com sucesso!", "OK");
            await Navigation.PopModalAsync();
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
