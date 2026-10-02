# CBTPRDM - Trabalho Pratico 02

Aplicativo .NET MAUI de lista de tarefas, desenvolvido para a disciplina
CBTPRDM (Programacao para Dispositivos Moveis) - ADS 671 - IFSP Campus Cubatao.
Professor: Wellington Tuler Moraes.

## Autores

- Igor Flores - cb3021734
- Isabela Salgueiro - Cb3030946

## Funcionalidades

- Pagina inicial com ListView exibindo titulo e descricao de cada tarefa.
- Navegacao hierarquica: ao tocar em um item, abre a pagina de detalhes com
  data de criacao e prioridade.
- Botao Editar na pagina de detalhes, abrindo um modal com os campos ja
  preenchidos (passagem de dados entre paginas pelo construtor).
- Botao Excluir na pagina de detalhes, com dialogo de confirmacao.
- Botao Adicionar na pagina inicial, abrindo um modal para cadastrar uma
  nova tarefa (titulo, descricao, data de criacao e prioridade).

## Estrutura

- `Tarefa.cs` - classe de modelo da tarefa.
- `Dados.cs` - lista estatica compartilhada entre as paginas.
- `MainPage.xaml` / `.cs` - pagina inicial com a lista.
- `DetalhePage.xaml` / `.cs` - pagina de detalhes.
- `AdicionarPage.xaml` / `.cs` - modal de nova tarefa.
- `EditarPage.xaml` / `.cs` - modal de edicao.

## Como executar

    dotnet build -t:Run -f net8.0-windows10.0.19041.0

Ou abrir a solucao no Visual Studio, selecionar o perfil "Windows Machine"
e pressionar F5.
