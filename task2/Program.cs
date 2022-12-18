// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -

Console.Write("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
int max = -1;
if ( a > b ) {
 max = a;
Console.WriteLine($"Число {max} максимальное ");
}
if( b > a ) {
 max = b;
 Console.WriteLine($"Число {max} максимальное ");
}
if(a == b){Console.WriteLine($"Числа равны");}


