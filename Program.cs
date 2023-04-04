Console.WriteLine(@$"
...................................................................................
|                                   Menu Bebidas                                   |
|Escolha sua opção de bebida (Digite o número referente a bebida que você deseja): |
|1- Suco de limão                                                                  |
|2- Suco de uva                                                                    |                       
|3- Suco de laranja                                                                |
|4- Coca-cola                                                                      |   
|5- H20                                                                            |
|..................................................................................|
");

int opcao = int.Parse(Console.ReadLine());

if (opcao >= 6)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Não existe opção para o número escolhido!");
    Console.ResetColor();
}
else
{
    Console.WriteLine("Gostaria de adicionar gelo a bebida?: ");

    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Escreva S para sim");
    Console.ResetColor();

    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Escreva N para não");
    Console.ResetColor();
    string gelo = Console.ReadLine().ToLower();

    switch (opcao)
    {
        case 1:
            Console.WriteLine("Voce escolheu o suco de limão");
            break;

        case 2:
            Console.WriteLine("Voce escolheu o suco de uva");
            break;

        case 3:
            Console.WriteLine("Voce escolheu o suco de laranja");
            break;

        case 4:
            Console.WriteLine("Voce escolheu a coca-cola");
            break;

        case 5:
            Console.WriteLine("Voce escolheu o H20");
            break;
    }


    // 
    if (gelo == "s")
    {
        Console.WriteLine("Sua bebida virá com gelo!");
    }
    else
    {
        Console.WriteLine("Sua bebida virá sem gelo!");
    }



}


Console.WriteLine(@$"
.................................
|                               |
|                               |
|       Fim do programa         |
|                               |
|                               |
.................................
");








