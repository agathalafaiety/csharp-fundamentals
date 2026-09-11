# C# Fundamentals

Repositório de estudos e exercícios desenvolvidos durante o aprendizado dos fundamentos da linguagem **C#** e da programação orientada a objetos.

## Conteúdos

- Classes e objetos
- Construtores e encapsulamento
- Herança e abstração
- Listas e relacionamentos entre classes
- Estruturação de aplicações em camadas
- Acesso a dados com SQL Server
- Exercícios de lógica de programação

## Estrutura

Os exercícios estão organizados por tema:

- `Fundamentos`: primeiros programas e conceitos básicos
- `Exercicios`: sequência de exercícios de lógica
- `ClassesEObjetos`: criação e relacionamento entre classes
- `Construtores`: construtores e encapsulamento
- `Heranca` e `HerancaEPolimorfismo`: herança, abstração e polimorfismo
- `Abstracao`: classes abstratas e especializações
- `ListasEmClasses`: coleções e relacionamentos entre objetos
- `RevisaoProgramacao`: exercícios de revisão
- `Camadas`: acesso ao SQL Server e separação de responsabilidades

## Tecnologias

- C#
- .NET Framework 4.7.2
- Visual Studio
- SQL Server

## Como executar

Clone o repositório:

```bash
git clone https://github.com/agathalafaiety/csharp-fundamentals.git
cd csharp-fundamentals
```

Abra o arquivo `CSharpFundamentals.sln` no Visual Studio. Em seguida, selecione o projeto desejado como projeto de inicialização e execute com `F5`.

As soluções menores dentro de cada pasta também foram mantidas para permitir o estudo isolado de cada tema.

### Banco de dados

O exemplo da pasta `Camadas` usa uma instância local do SQL Server Express (`.\SQLEXPRESS`). Execute o arquivo `ScriptCompleto221.sql` para criar o banco `dbDS2` antes de iniciar esse projeto. Caso utilize outra instância, ajuste a conexão no arquivo `Camadas/AcessoBancoDados/app.config`.

## Autora

Desenvolvido por [Agatha Lafaiety](https://github.com/agathalafaiety).
