string nome = "";
short idade = 0;
const double tempc = 36.5;

Console.WriteLine("Escreva seu nome");

nome = Console.ReadLine();

Console.WriteLine("Digite a sua idade");

try
{
    idade = Convert.ToInt16(Console.ReadLine());
    if (idade < 0 || idade > 160)
    {
        throw new ArgumentOutOfRangeException();
    }
    //if (idade is < 0 or > 150)
    //{
    //    Console.WriteLine("Digite uma idade válida");
    //}
    Console.WriteLine($"O seu nome é {nome} e a sua idade é {idade} e a sua temperatura corporal normal é {tempc} ");
}
catch (ArgumentOutOfRangeException)
{
    Console.WriteLine("Digite uma idade válida");
}
catch (FormatException)
{
    Console.WriteLine("Digite um número válido");
}