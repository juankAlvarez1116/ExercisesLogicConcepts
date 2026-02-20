using Shared;

var number1 = 0;
var number2 = 0;
var number3 = 0;
var answer = string.Empty;
var options = new List<string> { "s", "n" };

do
{
    do
    {
        number1 = ConsoleExtension.GetInt("Ingrese el primer número, diferente de 0: ");
    } while (number1 == 0);
    do
    {
        number2 = ConsoleExtension.GetInt("Ingrese el segundo número, diferente de 0: ");
    } while (number2 == 0 || number2 == number1);
    do
    {
        number3 = ConsoleExtension.GetInt("Ingrese el tercer número, diferente de 0: ");
    } while (number3 == 0 || number3 == number1 || number3 == number2);

    if (number1 > number2 && number2 > number3)
    {
        Console.WriteLine($"El número mayor es: {number1}");
        Console.WriteLine($"El número del medio es: {number2}");
        Console.WriteLine($"El número menor es: {number3}");
    }
    else if (number1 > number3 && number3 > number2)
    {
        Console.WriteLine($"El número mayor es: {number1}");
        Console.WriteLine($"El número del medio es: {number3}");
        Console.WriteLine($"El número menor es: {number2}");
    }
    else if (number2 > number1 && number1 > number3)
    {
        Console.WriteLine($"El número mayor es: {number2}");
        Console.WriteLine($"El número del medio es: {number1}");
        Console.WriteLine($"El número menor es: {number3}");
    }
    else if (number2 > number3 && number3 > number1)
    {
        Console.WriteLine($"El número mayor es: {number2}");
        Console.WriteLine($"El número del medio es: {number3}");
        Console.WriteLine($"El número menor es: {number1}");
    }
    else if (number3 > number1 && number1 > number2)
    {
        Console.WriteLine($"El número mayor es: {number3}");
        Console.WriteLine($"El número del medio es: {number1}");
        Console.WriteLine($"El número menor es: {number2}");
    }
    else
    {
        Console.WriteLine($"El número mayor es: {number3}");
        Console.WriteLine($"El número del medio es: {number2}");
        Console.WriteLine($"El número menor es: {number1}");
    }

    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? [S]i o [N]o:", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
Console.WriteLine("Game Over");


