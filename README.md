# Migrações de Banco de Dados usando DbUp

Este projeto realiza migrações de banco de dados utilizando a biblioteca DbUp para .NET. As migrações são uma maneira eficaz de evoluir o esquema do banco de dados ao longo do tempo, mantendo a consistência entre as diferentes versões do software.

## Configuração do Projeto

Certifique-se de ter os seguintes requisitos instalados:

- .NET Core SDK
- Banco de dados SQL Server instalado
- Install-Package DbUp

## Estrutura do Código

O código fornecido está contido em um script simples em C# que executa migrações de banco de dados usando a biblioteca DbUp. Aqui está uma breve explicação das principais partes do código:

```csharp
using DbUp;
using System;
using System.Linq;
using System.Reflection;

class Program
{
    static int Main(string[] args)
    {
        // Define a string de conexão do banco de dados
        var connectionString = args.FirstOrDefault() ?? "Server=localhost,1433;Database=Banco;User ID=app;Password=SENHA; TrustServerCertificate=True";

        // Configuração do DbUp
        var upgrader = DeployChanges.To
            .SqlDatabase(connectionString)
            .WithScriptsEmbeddedInAssembly(Assembly.GetExecutingAssembly())
            .LogToConsole()
            .Build();

        // Executa as migrações do banco de dados
        var result = upgrader.PerformUpgrade();

        // Verifica se as migrações foram bem-sucedidas
        if (!result.Successful)
        {
            // Exibe mensagem de erro em vermelho
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(result.Error);
            Console.ResetColor();

            // Em modo de depuração, aguarda entrada antes de fechar
#if DEBUG
            Console.ReadLine();
#endif

            return -1; // Código de saída indicando falha
        }

        // Exibe mensagem de sucesso em verde
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Sucesso!");
        Console.ResetColor();

        return 0; // Código de saída indicando sucesso
    }
}
```

## Utilização

1. Clone o repositório para sua máquina local.
2. Certifique-se de ter os requisitos de software instalados.
3. Configure a string de conexão do banco de dados conforme necessário.
4. Execute o script para aplicar as migrações de banco de dados.
