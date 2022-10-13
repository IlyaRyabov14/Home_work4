int GetUserNumber(string massage, string errorMassage)
{
    while(true)
    {
        Console.WriteLine(massage);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int UserNumber);
        if (isCorrect)
        {
            return UserNumber;
        }
        Console.WriteLine(errorMassage);
    } 
}   

int num = GetUserNumber("Введите целое число","Ошибка ввода!");
int result1 = num / 10000;
int num2_1  = num % 10000;
int result2 = num2_1 / 1000;
int num3_1 = num2_1 % 1000;
int result3 = num3_1 / 100;
int num4_1 = num3_1 % 100;
int result4 = num4_1 / 10;
int num5_1 = num4_1 % 10;
int finish = result1 + result2 + result3 + result4 + num5_1;
Console.WriteLine(finish);