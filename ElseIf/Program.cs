
do
{
    while (!Console.KeyAvailable)
    {

        string letra = "";

        Console.WriteLine();
        Console.WriteLine("Digite uma letra (A, B ou C)");
       
        letra = Console.ReadLine();

        if (letra.ToLower() == "a")
        {
            Console.WriteLine("Você escolheu a letra A");
        }
        else if (letra.ToLower() == "b")
        {
            Console.WriteLine("Você escolheu a letra B");
        }
        else
        {
            Console.WriteLine("Você escolheu a letra C");
        }

    }
} while (Console.ReadKey().Key == ConsoleKey.Escape);