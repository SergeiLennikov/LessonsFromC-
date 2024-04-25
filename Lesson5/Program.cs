// bool accessallowed;

// string storedPassword = "12345";
// string enteredPassword = Console.ReadLine();

// if (enteredPassword == storedPassword)
// {
//     accessallowed = true;
//     Console.WriteLine("От куда ты узнал пароль ?");
// }
// else
// {
//     accessallowed = false;
//     Console.WriteLine("Долбан иди в писку !!!");
// }
// Console.WriteLine(accessallowed);

// accessallowed = enteredPassword == storedPassword ? true : false;
// Console.WriteLine(accessallowed);

int inputData = int.Parse(Console.ReadLine());

int outputData = inputData < 0 ? 0 : inputData;
System.Console.WriteLine(outputData);