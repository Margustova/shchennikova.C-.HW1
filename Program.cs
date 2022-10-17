
// Задача 1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго

/* Console.Write("Input a first number: ");
int n1= Convert.ToInt32(Console.ReadLine()); 
Console.Write("Input a second number: ");
int n2= Convert.ToInt32(Console.ReadLine());

int quad2 = n2 * n2;

if(quad2 == n1)
{
    Console.WriteLine($"Number {n1} is square of {n2}");
}
else
{
    Console.WriteLine($"Number {n1} is not square of {n2}");
}
*/

//Задача 2. Напишите программу, которая на вход принимает одно число (N), а на выходе показывает все целые числа в промежутке от -N до N.

/* Console.Write("Input a positive integer number: ");
int number = Convert.ToInt32(Console.ReadLine());
int current = -number;
while(current <= number)
{
    Console.Write(current + " ");
    current++; // увеличение переменной на единицу (аналогично --)
}
*/
// Задача 3. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.

/* Console.Write("Input three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number % 10;
Console.WriteLine($"Last digit of {number} is {result}");
*/

//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*Console.Write("Input a first number: "); 
int num1= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: "); 
int num2= Convert.ToInt32(Console.ReadLine());
int max = num1;
if(num1 > num2)
{ 
    max = num1;
}
else
{
    max = num2;
}
Console.WriteLine($"num1={num1}, num2 = {num2}, -> max ={max}"); */

/*a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/

/* Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 
*/
/* Console.Write("Input a first number: "); 
int num1= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: "); 
int num2= Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int num3= Convert.ToInt32(Console.ReadLine()); 
int max = num1;
if(num1 < num2)
{ 
    max = num2;
}
if(num2 < num3)
{
    max = num3;
}
if(num1 > num3)
{
    max = num1;
}
Console.WriteLine($"num1={num1}, num2 = {num2}, num3={num3} -> max ={max}"); */


/* Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет */

/*Console.Write("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());
if(number % 2 == 0)
{
    Console.WriteLine($"{number} is even");
}
else 
    Console.WriteLine(($"{number} is not even")); */
