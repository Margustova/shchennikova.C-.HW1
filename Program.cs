/* Напишите программу, которая выводит случайное трёхзначное число
 и удаляет вторую цифру этого числа.*/
int CutDigit(int number)
{
    int ed = number % 10; //остаток от деления
    int sot = number / 100; //цельночисленное деление

    int result = sot * 10 + ed; 
    return result;
}
int randNum = new Random().Next(100, 1000); //  найти рандомное число от 100 до 1000
int newNum = CutDigit(randNum); // записать результат в переменную
Console.WriteLine($"New version of {randNum} is {newNum} ");
