// Проверка на четное число
// int a;

// a = Convert.ToInt32(Console.ReadLine());

// if (a % 2 == 0)
// {
//     System.Console.WriteLine($"Число четное: {a}");
// }
// else
// {
//     System.Console.WriteLine($"Число не четное: {a}");
// }
// int num1, num2, result;
// string a = Console.ReadLine();

// switch (a)
// {
//     case "+":
//         System.Console.Write("Введите число: ");
//         num1 = Convert.ToInt32(Console.ReadLine());
//         System.Console.Write("Введите число: ");
//         num2 = Convert.ToInt32(Console.ReadLine());
//         result = num1 + num2;
//         System.Console.WriteLine("Ответ: " + result);
//         break;
//     case "-":
//         System.Console.Write("Введите число: ");
//         num1 = Convert.ToInt32(Console.ReadLine());
//         System.Console.Write("Введите число: ");
//         num2 = Convert.ToInt32(Console.ReadLine());
//         result = num1 - num2;
//         System.Console.WriteLine("Ответ: " + result);
//         break;
//     case "*":
//         System.Console.Write("Введите число: ");
//         num1 = Convert.ToInt32(Console.ReadLine());
//         System.Console.Write("Введите число: ");
//         num2 = Convert.ToInt32(Console.ReadLine());
//         result = num1 * num2;
//         System.Console.WriteLine("Ответ: " + result);
//         break;
//     case "/":
//         System.Console.Write("Введите число: ");
//         num1 = Convert.ToInt32(Console.ReadLine());
//         System.Console.Write("Введите число: ");
//         num2 = Convert.ToInt32(Console.ReadLine());
//         result = num1 / num2;
//         System.Console.WriteLine("Ответ: " + result);
//         break;
// }


// while(true)
// {
//     Console.Clear();
//     double numbir1, numbir2, result1;
//     char sumv;

//     try
//     {
//     System.Console.Write("Введите число: ");
//     numbir1 = double.Parse(Console.ReadLine());

//     System.Console.Write("Выберите операцию +, -, *, /: \t");
//     sumv = char.Parse(Console.ReadLine());

//     System.Console.Write("Введите число: ");
//     numbir2 = double.Parse(Console.ReadLine());
//     }
//     catch (Exception)
//     {
//         System.Console.WriteLine("Следуй инструкции Еблан");
//         Console.ReadLine();
//         continue;
//     }
    
//     if (sumv == '+')
//     {
//     result1 = numbir1 + numbir2;
//     System.Console.WriteLine("Ответ: " + result1);
//     }
//     else if (sumv == '-')
//     {
//     result1 = numbir1 - numbir2;
//     System.Console.WriteLine("Ответ: " + result1);
//     }
//     else if (sumv == '*')
//     {
//     result1 = numbir1 * numbir2;
//     System.Console.WriteLine("Ответ: " + result1);
//     }
//     else if (sumv == '/')
//     {
//     result1 = numbir1 / numbir2;
//     System.Console.WriteLine("Ответ: " + result1);
//     }
//     Console.ReadLine();
// }