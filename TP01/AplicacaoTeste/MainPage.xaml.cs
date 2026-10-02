// CBTPRDM - ADS 671 - Trabalho Pratico 01
// Code-behind da tela de login: valida o usuario admin / senha@dmin,
// limpa os campos devolvendo o foco para o ID e exibe os creditos do app.
// Nome: Igor Flores - cb3021734

namespace AplicacaoTeste
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void OnOkClicked(object sender, EventArgs e)
        {
            string id = txtId.Text;
            string senha = txtSenha.Text;

            if (id == "admin" && senha == "senha@dmin")
            {
                await DisplayAlert("Aplicação Teste", "Login efetuado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Aplicação Teste", "Login não autorizado!", "OK");
            }
        }

        private void OnLimparClicked(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtSenha.Text = "";
            txtId.Focus();
        }

        private async void OnCreditosClicked(object sender, EventArgs e)
        {
            string autores = "Igor Flores - cb3021734";

            await DisplayAlert("Créditos", autores, "OK");
        }
    }
}
