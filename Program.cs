/* Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.*/
/* int CutDigit(int number)
{
    int ed = number % 10; //остаток от деления
    int sot = number / 100; //цельночисленное деление

    int result = sot * 10 + ed; 
    return result;
}
int randNum = new Random().Next(100, 1000); //  найти рандомное число от 100 до 1000
int newNum = CutDigit(randNum); // записать результат в переменную
Console.WriteLine($"New version of {randNum} is {newNum} "); */

//Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.

/*int RandomNumb(int TwoDigitNumb)
{
    int FirstDigit = TwoDigitNumb / 10;
    int SecondDigit = TwoDigitNumb % 10;
    int max = FirstDigit;
    if(FirstDigit < SecondDigit)
        SecondDigit = max;
        return max;

}
int randNum = new Random().Next(10, 100);
int max = RandomNumb(randNum); // записать результат в переменную
Console.WriteLine($"the big digit of {randNum} is {max} "); */

//Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

/*bool Proverka(int number1, int number2)
{
    if(number1 == number2 * number2 ||  number2 == number1 * number1)
        return true;
    else 
        return false;
}
Console.Write("Input a number1: "); 
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: "); 
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Proverka(number1, number2));*/


//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому.
/*bool Multiple(int number1, int number2)
{
    if(number1 % number2 == 0)
        return true;
    else
        return false;
}
Console.Write("input a number1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number2: "); 
int number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Multiple(number1, number2)); */

/* Напишите программу, которая принимает три целых числа(a, m, n) и проверяет, кратно ли число a одновременно m и n.*/

/* bool Exam(int a, int m, int n)
{
     if (a % m == 0 && a % n == 0)
        return true;
     else
        return false;
}
Console.Write("input a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Input m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("input n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Exam(a, m, n)); */

/*Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1 */

int Digit(int ThreeDigitNumber)
{
    int result = (ThreeDigitNumber / 10) % 10;
        return result;
}
Console.Write("input ThreeDigitNumber: ");
int ThreeDigitNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Digit(ThreeDigitNumber));


/* Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

645 -> 5

78 -> третьей цифры нет

32679 -> 6

Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет */