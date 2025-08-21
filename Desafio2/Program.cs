using Desafio2.Model;
while (true)
{
    Console.WriteLine("\nescolha um animal para o som (ou digite 0 para sair)");
    Console.WriteLine("1 - Elefante");
    Console.WriteLine("2 - Leão");
    Console.WriteLine("3 - Macaco");

    string ?input = Console.ReadLine();

    if (input == "0")
        break;

    Animal ?animalEscolhido = null;

    switch (input.Trim())
    {
        case "1":
            animalEscolhido = new Elefante();
            break;
        case "2":
            animalEscolhido = new Leao();
            break;
        case "3":
            animalEscolhido = new Macaco();
            break;
        default:
            Console.WriteLine("ppção inválida");
            continue;
    }
    animalEscolhido.EmitirSom();
}
