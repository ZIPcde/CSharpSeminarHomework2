/*Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.*/
// Задача № 1
int inputedNumber = 23 * 7;

if (inputedNumber % 7 == 0 && inputedNumber % 23 == 0)
{
    System.Console.WriteLine("Введенное число кратно 7 и 23 одновременно");
}
else
{
    System.Console.WriteLine("Введенное число не кратно 7 или 23");
}
// Задача № 2
int enteredX = 12;
int enteredY = -23;
if (enteredX == 0 || enteredY == 0)
{
    System.Console.WriteLine("Часть координат равна 0!!!");
}
else if (enteredX > 0 && enteredY > 0)
{
    System.Console.WriteLine(1);
}
else if (enteredX > 0 && enteredY < 0)
{
    System.Console.WriteLine(4);
}
else if (enteredX < 0 && enteredY < 0)
{
    System.Console.WriteLine(3);
}
else if (enteredX < 0 && enteredY > 0)
{
    System.Console.WriteLine(2);
}
// Задача № 3
int externalNumber = 33;   // from 10 to 99

int decimalSymbol = externalNumber / 10;
int unitSymbol = externalNumber - (decimalSymbol * 10);
if (decimalSymbol > unitSymbol)
{
    System.Console.WriteLine(decimalSymbol);
}
else
{
    System.Console.WriteLine(unitSymbol);
}
// Задача № 4
int inputedNaturalNumber = 4359874;

string converted = inputedNaturalNumber.ToString();
string delimiter = ",";
for (int i = 0; i < converted.Length; i++)
{
    if (i == (converted.Length - 1))
    {
        delimiter = ""; // убираем разделитель перед последней итерацией вливания в консоль.
    }
    System.Console.Write(converted[i] + delimiter);
}