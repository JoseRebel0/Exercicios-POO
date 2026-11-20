# Exercícios POO (C#)

Exercícios de **Programação Orientada a Objetos em C#** realizados fora das aulas. O repositório contém, para já, a **Ficha 05**, que cobre os conceitos base de POO: encapsulamento, construtores, herança, polimorfismo, classes abstratas, sobrecarga de métodos e composição.

## Tecnologias

- C# com **.NET 10** (`net10.0`)
- Aplicação de consola
- `Nullable` e `ImplicitUsings` ativos

## Estrutura do projeto

```
Exercicios-POO/
├── Exercícios_Ficha05.slnx          # Solução
└── Exercícios_Ficha05/
    ├── Exercícios_Ficha05.csproj
    ├── Program.cs                    # Ponto de entrada com os testes de cada exercício
    └── *.cs                          # Uma classe por ficheiro
```

## Como executar

Pré-requisito: [.NET SDK 10](https://dotnet.microsoft.com/download).

```bash
git clone <url-do-repositório>
cd Exercicios-POO
dotnet run --project Exercícios_Ficha05
```

Também pode abrir a solução (`.slnx`) no Visual Studio e carregar em **F5**.

> **Nota:** no `Program.cs`, o código de teste de cada exercício está **comentado**. Para ver o resultado de um exercício, descomente o bloco correspondente (cada um está identificado como `// Exercício N - Ficha 05`) e volte a executar.

## Exercícios

| Ex. | Tema | Classes | Conceito principal |
|----:|------|---------|--------------------|
| 1 | Televisão que liga e desliga | `Televisao` | Estado privado com propriedade só de leitura |
| 2 | Termostato com limites (16–30) | `Termostato` | Validação de valores |
| 3 | Conta bancária | `Conta` | Depósitos e levantamentos validados |
| 4 | Gestão de stock | `Stock` | Repor/retirar com validação |
| 5 | Aluno | `Pessoa`, `Aluno` | Construtor e `base(...)` |
| 6 | Carro | `Veiculo`, `Carro` | Herança |
| 7 | Cão e gato | `Animal`, `Cao`, `Gato` | `virtual` / `override` |
| 8 | Docente | `Pessoa`, `Docente` | Redefinição de `Descrever()` |
| 10 | Veterinário | `Veterinario` | Polimorfismo (parâmetro do tipo `Animal`) |
| 11 | Calculadora | `Calculadora` | Sobrecarga de métodos (`Somar` com 2 e 3 parâmetros) |
| 12 | Figura geométrica | `Figura`, `Retangulo` | Classe e método abstratos |
| 15 | Conta poupança | `ContaPoupanca` | Herança de `Conta` e reutilização de `Depositar` |
| 17 | Livros e autor | `Autor`, `Livro` | Associação entre classes |
| 19 | Encomenda | `Linha`, `Encomenda` | Composição |

O final do `Program.cs` inclui ainda a resolução de um exercício de um **teste exemplo** (também comentada), com as classes `Cancela`, `Parque` e `Programa`, que modela parques de estacionamento com cancelas de entrada e saída.
