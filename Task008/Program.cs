// Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите любое число больше 1: ");
int n = Convert.ToInt32(Console.ReadLine());
int count = 1;
if (n <= 1)
{
    Console.WriteLine("! Введённое число не может быть меньше или равно 1 !"); 
}
else
{
    Console.WriteLine($"Чётные числа в пределах от 1 до {n} ");
    while (count < n )
    {
        if (count % 2 == 0)
        { 
        Console.Write(" " + count + " ");
        }
    count++;
    }
}
