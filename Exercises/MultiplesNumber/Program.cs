
using Shared;

var answer = string.Empty;
var options = new List<string> { "s", "n" };
int validate = 0;

do
{
    var number1 = ConsoleExtension.GetInt("Ingrese el primer numero: ");
    validate = 0;
    if (number1 == 0 )
    {
        Console.WriteLine("Lo ingresado no es valido, vuelva a intentar...");
        validate = 1;
        continue;
    }
    var number2 = ConsoleExtension.GetInt("Ingrese el segundo numero: ");
    if (number2 == 0)
    {
        Console.WriteLine("Lo ingresado no es valido, vuelva a intentar...");
        validate = 1;
        continue; 
    }
    if (number1 > number2)
    {
        if (number1 % number2 == 0)
        {
            Console.WriteLine($"El número {number2}, ES multiplo de: {number1}");
        }
        else
        {
            Console.WriteLine($"El número {number2}, NO ES multiplo de: {number1}");
        }
    }
    else
    {
        Console.WriteLine("El número mayor debe ir primero");
    }
    do
    {
        answer = ConsoleExtension.GetValidOptions("¿Desea continuar? [S]i o [N]o:", options);
    } while (!options.Any(x => x.Equals(answer, StringComparison.CurrentCultureIgnoreCase)));

} while (validate == 1 || answer!.Equals("s", StringComparison.CurrentCultureIgnoreCase));
