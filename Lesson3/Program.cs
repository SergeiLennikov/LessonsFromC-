//Счетчик четных & нечетных чисел в диапозоне заданным пользователем
uint oddNumbersCount = 0; //нечетные числа
uint evenNumbersCount = 0; //четные числа

System.Console.WriteLine("Введите первое число диапозона ");
int currentValue = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите последние число диапозона ");
int limit = int.Parse(Console.ReadLine());

while (currentValue <= limit)
{
    if (currentValue % 2 == 0)
    {
        evenNumbersCount++;
    }
    else
    {
        oddNumbersCount++;
    }
    currentValue++;
}
System.Console.WriteLine("Кол-во нечетных чисел: " + oddNumbersCount);
System.Console.WriteLine("Кол-во четных чисел: " + evenNumbersCount);