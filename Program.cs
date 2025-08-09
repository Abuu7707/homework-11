/*Task 1
int a = Convert.ToInt32(Console.ReadLine());
int Even = 0;
int Odd = 0;
int Digit = 0;
int Sum = 0;
for (int i = a; i > 0; i /= 10)
{
    int t = i % 10;
    if (t % 2 == 0) Even++;
    if (t % 2 != 0) Odd++;
    if (t > 0) Digit++;
    if (t > 0) Sum += t;
}
System.Console.WriteLine($"Even:{Even}");
System.Console.WriteLine($"Even:{Odd}");
System.Console.WriteLine($"Even:{Digit}");
System.Console.WriteLine($"Even:{Sum}");*/