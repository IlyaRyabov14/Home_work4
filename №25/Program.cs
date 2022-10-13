Console.WriteLine("Введите первое число");
double A;
double B;
double.TryParse(Console.ReadLine(), out A );
Console.WriteLine("Введите второе число");
double.TryParse(Console.ReadLine(), out B );

///double result = double.Pow(A, B);
///Console.WriteLine(result);

double result = A;
for (int i = 1; i < B; i++)
{
    result = result * A;
}
Console.WriteLine($"{A} в степени {B} равно {result}");






