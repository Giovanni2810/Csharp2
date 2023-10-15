// Напишите программу, которая на вход принимает число и выдает его квадрат (число умноженное на само себя).

// Например:
// 4 -> 16 
// -3 -> 9 
// -7 -> 49

Console.Write("Введите значение: ");                  // Приглашаю пользователя ко вводу
int number = Convert.ToInt32(Console.ReadLine()); // Принимаем число от пользователя и помещаем в переменную number
  // int number1 = int.Parse(Console.ReadLine());
System.Console.WriteLine(number);                // Выводим переменную number
int sqr = number * number;                      // Вычислили квадрат числа и поместили значение в переменную в sqr
Console.WriteLine(sqr);                        // Выводим ответ