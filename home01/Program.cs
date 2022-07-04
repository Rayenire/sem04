// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
double a, b, result;
a = new Random().Next(0, 6);;
Console.WriteLine(a);
b = new Random().Next(0, 6);;
Console.WriteLine(b);
result = Math.Pow(a, b);
Console.WriteLine(result);