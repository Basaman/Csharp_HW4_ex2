//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Clear();
int num = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int SumNumbers = GetSumNumbers(num);
Console.WriteLine($"{num} -> {SumNumbers}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int GetSumNumbers(int number)

{
    int sum = 0;
    for(number = num; number > 0; number = number / 10)
    {
    int LastNumber = number%10; //отделет последнюю цифру
    sum += LastNumber; //прибавляет к сумме последнюю цифру
    
    }
    return sum;
}