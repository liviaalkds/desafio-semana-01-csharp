double nota1 = 8;
double nota2 = 7;
double nota3 = 9;

double media = CalcularMedia(nota1, nota2, nota3);

Console.WriteLine($"Nota 1: {nota1}");
Console.WriteLine($"Nota 2: {nota2}");
Console.WriteLine($"Nota 3: {nota3}");
Console.WriteLine($"Média: {media}");

static double CalcularMedia(double n1, double n2, double n3)
{
    return (n1 + n2 + n3) / 3;
}