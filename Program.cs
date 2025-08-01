using Atividade_OO;

internal class Program
{
    private static void Main()
    {
        var livro = new Livro()
        {
            Titulo = "Dom Casmurro",
            Autor = "Machado de Assis",
            Editora = "Companhia das Letras",
            AnoPublicacao = 1899
        };

        Console.WriteLine(
            $"{livro.Titulo}\n " +
            $"{livro.Autor}\n " +
            $"{livro.Editora}\n " +
            $"{livro.AnoPublicacao}");

        var livro2 = new Livro()
        {
            Titulo = "Diário de um Banana",
            Autor = "Jeff Kinney",
            Editora = "VR Editora",
            AnoPublicacao = 2007
        };

        Console.WriteLine(
            $"{livro2.Titulo}\n " +
            $"{livro2.Autor}\n " +
            $"{livro2.Editora}\n " +
            $"{livro2.AnoPublicacao}");

        var livro3 = new Livro()
        {
            Titulo = "O Guarani",
            Autor = "José de Alencar",
            Editora = "Saraiva",
            AnoPublicacao = 1857
        };

        Console.WriteLine(
            $"{livro3.Titulo}\n" +
            $"{livro3.Autor}\n" +
            $"{livro3.Editora}\n" +
            $"{livro3.AnoPublicacao}");

        Console.WriteLine("--------------------------------------------------");

        var Aluno = new Aluno()
        {
            RM = 4401,
            Nome = "João da Silva",
            Nascimento = new DateTime(2008, 11, 06),
            Email = "joaodasilva@gmail.com"
        };

        Console.WriteLine($"RM: {Aluno.RM}\n" +
            $"Nome: {Aluno.Nome}\n" +
            $"Nascimento: {Aluno.Nascimento: dd/MM/yyyy}\n" +
            $"Email: {Aluno.Email}");

        Console.WriteLine("--------------------------------------------------");

        var Aluno2 = new Aluno()
        {
            RM = 4402,
            Nome = "Maria Oliveira",
            Nascimento = new DateTime(2000, 5, 15),
            Email = "mariaooliveira@gmail.com"
        };

        Console.WriteLine($"RM: {Aluno2.RM}\n" +
            $"Nome: {Aluno2.Nome}\n" +
            $"Nascimento: {Aluno2.Nascimento: dd/MM/yyyy}\n" +
            $"Email: {Aluno2.Email}");

        Console.WriteLine("--------------------------------------------------");

        var Aluno3 = new Aluno()
        {
            RM = 4403,
            Nome = "Carlos Pereira",
            Nascimento = new DateTime(2004, 8, 09),
            Email = "carlosPereiraa@hotmail.com"
        };

        Console.WriteLine($"RM: {Aluno3.RM}\n" +
            $"Nome: {Aluno3.Nome}\n" +
            $"Nascimento: {Aluno3.Nascimento: dd/MM/yyyy}\n" +
            $"Email: {Aluno3.Email}");

        Console.WriteLine("--------------------------------------------------");

        var produto = new Produto()
        {
            Codigo = 1,
            Nome = "Notebook",
            Preco = 2000.90m,
            Estoque = 10
        };

        Console.WriteLine($"Código: {produto.Codigo}\n " +
            $"Nome: {produto.Nome}\n" +
            $"Preço: {produto.Preco}\n" +
            $"Disponível no estoque: {produto.Estoque}" +
            $"Total em estoque: R${produto.valorEstoque():0.00}");

        Console.WriteLine("--------------------------------------------------");

        var produto2 = new Produto()
        {
            Codigo = 2,
            Nome = "Celular",
            Preco = 1500.50m,
            Estoque = 5
        };

        Console.WriteLine($"Código: {produto2.Codigo}\n " +
            $"Nome: {produto2.Nome}\n" +
            $"Preço: {produto2.Preco}\n" +
            $"Disponível no estoque: {produto2.Estoque}" +
            $"Total em estoque: R${produto2.valorEstoque():0.00}");

        Console.WriteLine("--------------------------------------------------");

        var produto3 = new Produto()
        {
            Codigo = 3,
            Nome = "Tablet",
            Preco = 800.00m,
            Estoque = 20
        };

        Console.WriteLine($"Código: {produto3.Codigo}\n " +
            $"Nome: {produto3.Nome}\n" +
            $"Preço: {produto3.Preco}\n" +
            $"Disponível no estoque: {produto3.Estoque}" +
            $"Total em estoque: R${produto3.valorEstoque():0.00}");

        Console.WriteLine("--------------------------------------------------");

        var carro = new Carro()
        {
            Marca = "Toyota",
            Modelo = "Corolla",
            Velocidade = 00
        };

        Console.WriteLine($"Marca: {carro.Marca}\n" +
            $"Modelo: {carro.Modelo}\n" +
            $"Velocidade: {carro.Velocidade} km/h\n" +
            $"Velocidade atual: {carro.Acelerar(10)} km/h\n" +
            $"Velocidade atual: {carro.Acelerar(20)} km/h\n" +
            $"Velocidade atual: {carro.Desacelerar(15)} km/h)");

        Console.WriteLine("--------------------------------------------------");

        var f1 = new Funcionario("João", 30, "Gerente");
        var f2 = new Funcionario("Maria", 25, "Analista");
        var f3 = new Funcionario("Carlos", 28, "Desenvolvedor");

        f1.Exibir();
        f2.Exibir();
        f3.Exibir();

        Console.WriteLine("--------------------------------------------------");

        f1.Envelhecer(5);
        f2.Envelhecer(3);
        f3.Envelhecer(2);

        Console.WriteLine("--------------------------------------------------");

        var gato = new Gato();
        var porco = new Porco();
        var capivara = new Capivara();

        gato.Exibir();
        gato.EmitirSom();

        porco.Exibir();
        porco.EmitirSom();

        capivara.Exibir();
        capivara.EmitirSom();
    }
}
