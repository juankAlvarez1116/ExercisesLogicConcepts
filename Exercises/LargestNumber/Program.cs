Console.Write("Ingrese el primer número: ");
var number1String = Console.ReadLine();
Console.Write("Ingrese el segundo número: ");
var number2String = Console.ReadLine();
Console.Write("Ingrese el tercer número: ");
var number3String = Console.ReadLine();
var number1Int = int.Parse(number1String!);
var number2Int = int.Parse(number2String!);
var number3Int = int.Parse(number3String!);
if (number1Int > number2Int && number1Int > number3Int)
{
    Console.WriteLine($"El número mayor es: {number1Int}");
}
else if (number3Int > number1Int && number3Int > number2Int)
{
    Console.WriteLine($"El número mayor es: {number3Int}");
}
else
{
    Console.WriteLine($"El número mayor es: {number2Int}");
}