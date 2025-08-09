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

/*Task 2
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

int Add = a + b;
int Sub = a - b;
int Mult = a * b;
int Div = a / b;

System.Console.WriteLine($"Add:{Add}");
System.Console.WriteLine($"Subtract:{Sub}");
System.Console.WriteLine($"Multiply:{Mult}");
System.Console.WriteLine($"Division:{Div}");*/

/*Task 3
int a = Convert.ToInt32(Console.ReadLine());
    int mx = -10;
    int mn = 10;
for (int i = a; i > 0; i /= 10)
{
    int t = i % 10;
    if (t > mx) mx = t;
    if (t < mn) mn = t;
}
System.Console.WriteLine($"{mn} + {mx} = {mn+mx}");*/