// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.WriteLine("Enter the five-digit number");
String number=Console.ReadLine();

void CheckingNumber (String number){
    if (number[0]==number[4]&&number[1]==number[3])
    Console.WriteLine("Yes");
    else Console.WriteLine("No");
    };

if (number.Length>5||number.Length<5)
    Console.WriteLine("This is not five-digit number");
else CheckingNumber(number);