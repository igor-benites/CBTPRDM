# CBTPRDM - Trabalho Pratico 03

Aplicacao de rastreamento logistico em .NET MAUI com o padrao MVVM,
desenvolvida para a disciplina CBTPRDM (Programacao para Dispositivos Moveis)
- ADS 671 - IFSP Campus Cubatao. Professor: Wellington Tuler Moraes.

## Autores

- Igor Flores - cb3021734
- Isabela Salgueiro - Cb3030946

## Funcionalidades

- Pagina inicial para o cliente informar o codigo de rastreamento.
- Pagina de resultados com status atual, data de envio, previsao de entrega,
  localizacao atual e historico de eventos em lista.
- Validacao de codigo vazio e de codigo inexistente, com mensagem na tela.
- Busca simulada por um servico com dados ficticios.

## Arquitetura MVVM

- Model: `Models/Pacote.cs` e `Models/EventoRastreamento.cs`.
- View: `MainPage.xaml` e `ResultadoPage.xaml`; o code-behind apenas define o
  BindingContext e realiza a navegacao.
- ViewModel: `ViewModels/RastreamentoViewModel.cs`, com INotifyPropertyChanged,
  ObservableCollection e ICommand (`ViewModels/ComandoSimples.cs`).
- Servico de dados: `Services/PacoteService.cs`.

## Codigos para teste

- BR123456789SP - Em transito
- BR987654321RJ - Entregue
- BR555444333MG - Aguardando postagem

## Como executar

    dotnet build -f net10.0-windows10.0.19041.0

Ou abrir a solucao no Visual Studio, selecionar o perfil "Windows Machine"
e pressionar F5.
