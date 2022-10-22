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
bool Multiple(int number1, int number2)
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
Console.WriteLine(Multiple(number1, number2));