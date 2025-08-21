Console.WriteLine("Digite um texto.");
var texto = Console.ReadLine();

static string replaceVogal(string texto)
{
    return texto.Replace('A', '@').Replace('a', '@')
                .Replace('E', '#').Replace('e', '#')
                .Replace('I', '!').Replace('i', '!')
                .Replace('O', '$').Replace('o', '$')
                .Replace('U', '%').Replace('u', '%');
}

Console.WriteLine("Resultado final: " + replaceVogal(texto));