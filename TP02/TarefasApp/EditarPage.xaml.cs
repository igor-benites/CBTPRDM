// CBTPRDM - ADS 671 - Trabalho Pratico 02
// Code-behind do modal de edicao: recebe a tarefa pelo construtor, preenche
// os campos com os dados atuais e grava as alteracoes.
// Nome: Igor Flores - cb3021734
// Nome: Isabela Salgueiro - Cb3030946

namespace TarefasApp
{
    public partial class EditarPage : ContentPage
    {
        private Tarefa tarefa;

        public EditarPage(Tarefa tarefaSelecionada)
        {
            InitializeComponent();
            tarefa = tarefaSelecionada;

            txtTitulo.Text = tarefa.Titulo;
            txtDescricao.Text = tarefa.Descricao;
            dtpData.Date = tarefa.DataCriacao;

            for (int i = 0; i < pckPrioridade.Items.Count; i++)
            {
                if (pckPrioridade.Items[i] == tarefa.Prioridade)
                {
                    pckPrioridade.SelectedIndex = i;
                }
            }
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

            tarefa.Titulo = txtTitulo.Text;
            tarefa.Descricao = txtDescricao.Text;
            tarefa.DataCriacao = dtpData.Date ?? DateTime.Today;
            tarefa.Prioridade = pckPrioridade.Items[pckPrioridade.SelectedIndex];

            await DisplayAlert("Editar Tarefa", "Tarefa alterada com sucesso!", "OK");
            await Navigation.PopModalAsync();
        }

        private async void OnCancelarClicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}
