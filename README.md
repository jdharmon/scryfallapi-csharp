# C# Scryfall API Client

This package is auto-geneated from the [Scryfall API definition](https://github.com/jdharmon/scryfallapi).

## Getting Started (.NET Core)

1. Create a folder for your project

```sh
mkdir MyProject
cd MyProject
git init
```

2. Create the project, and add dependencies

```sh
dotnet new console
dotnet add package Microsoft.Rest.ClientRuntime --version 2.3.11
```

3. Add this repository as a submodule.

```sh
git submodule add https://github.com/jdharmon/scryfallapi-csharp.git Scryfall
```

4. Open Program.cs, and add

```csharp
using Scryfall.API;
```

5. Instantiate and use ScryfallClient:

```csharp
static void Main(string[] args)
{
	// Instiantiate new Scryfall client
	var scryfall = new ScryfallClient();

	// Get a random card
	var card = scryfall.Cards.GetRandom();
	Console.WriteLine($"{card.Name}\t\t{card.ManaCost}\n");
	Console.WriteLine($"{card.TypeLine}\n");
	Console.WriteLine($"{card.OracleText}");
}
```

6. Build & run

```sh
dotnet build
dotnet run
```
