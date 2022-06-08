// **Задача 2:** Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 ->  max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.WriteLine("Введите первое число: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = Convert.ToInt32(Console.ReadLine());
int max, min = 0;
if(A > B)
{
  max = A;
  min = B;
}
else
{
    max = B;
    min = A;
}
Console.WriteLine($"Максимальное число {max}");
Console.WriteLine($"Минимальное число {min}");
