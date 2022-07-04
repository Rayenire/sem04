// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
int a, b;
a = new Random().Next(0, 11);;
Console.WriteLine(a);
b = new Random().Next(0, 11);;
Console.WriteLine(b);
int res = 1;
for (int i = 0; i < b; i++){
    res*=a;
}
Console.WriteLine(res);



 
// res = Math.Pow(a, b);
// Console.WriteLine(res);