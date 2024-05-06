class Program
{
    static void Main(string[] args)
    {
        //Ввод массива с клавиатуры.
        // Console.Write("Введите кол-во элементов массива:\t");
        // int elementsCount = int.Parse(Console.ReadLine());
        // int[] myArray = new int[elementsCount];
        
        // for (int i = 0; i < myArray.Length; i++)
        // {
        //     Console.Write($"\nВведите элемент массива под индексом {i}:\t");
        //     myArray[i] = int.Parse(Console.ReadLine());
        // }

        // Console.WriteLine("Вывод массива:");
        // for (int i = 0; i < myArray.Length; i++)
        // {
        //     Console.WriteLine($"\n{myArray[i]}");
        // }


        //Вывод массива с индексом.
        // int[] imArray = { 1, 24, 33, 4, 52, 61};
        // for (int i = 0; i < imArray.Length; i++)
        // {
        //     Console.WriteLine($" {i} => {imArray[i]}");
        // }


        //Вывод массива в обратном порядке.
        // int[] imArray = { 1, 24, 33, 4, 52, 61};
        // for (int i = imArray.Length - 1; i >= 0; i--)
        // {
        //     Console.WriteLine($" {i} => {imArray[i]}");
        // }


        //Сумма четных элементов массива.
        // int[] uArray = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        // int sum = 0;
        // for (int i = 0; i < uArray.Length; i++)
        // {
        //     if (uArray[i] % 2 == 0)
        //     {
        //         sum += uArray[i];
        //     }
        // }
        // System.Console.WriteLine(sum);

        //Минимальный элемент массива.
        // int[] tArray = { 12, 22, 34, 46, 5, 66};
        // int minSum = tArray[0];

        // for (int i = 1; i < tArray.Length; i++)
        // {
        //     if (tArray[i] < minSum)
        //     {
        //         minSum = tArray[i];
        //     }  
        // }
        // System.Console.WriteLine(minSum);

        //Найдите Сумму всех не четных элементов массива.
        //  int[] tArray = { 11, 21, 35, 46, 5, 66, 12 , 22, 34};
        // int su_m = 0;

        // for (int i = 0; i < tArray.Length; i++)
        // {
        //     if (tArray[i] % 2 != 0)
        //     {
        //         su_m += tArray[i];
        //     }
        // }
        // System.Console.WriteLine(su_m);
        
        //Создали массив и заполнили его рандомными числами и добавили функцию сложение не четных чисел.
        // Random rand = new Random();
        // int[] tArray = new int[10];
        // int su_m = 0;
        
        // for (int i = 0; i < tArray.Length; i++)
        // {
        //     tArray[i] = rand.Next(1, 100);
        //     Console.WriteLine($"\nРандомные элементы: {i} => {tArray[i]}");
        // }
        // for (int i = 0; i < tArray.Length; i++)
        // {
        //     if (tArray[i] % 2 != 0)
        //     {
        //         su_m += tArray[i];
        //         System.Console.WriteLine($"\nНе четные элементы массива: {i} => {tArray[i]}\n");
        //     }
        // }
        // System.Console.WriteLine($"Сумма всех не четных элементов: {su_m}");


    }

}
