﻿int n = Convert.ToInt32(Console.ReadLine());
int count = 0;
while(n > 0){
    n = n / 10;
    count++;
}
Console.WriteLine(count);
