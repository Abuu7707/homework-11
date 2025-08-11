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

/*Task 4
int x = Convert.ToInt32(Console.ReadLine());
int y = Convert.ToInt32(Console.ReadLine());

var pw = Math.Pow(x, y);

System.Console.WriteLine(pw);*/

/*Task 5
void Swap(ref int x, ref int y)
{
    int t = x;
    x = y;
    y = t;
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Swap(ref a, ref b);

System.Console.WriteLine($"x = {a}");
System.Console.WriteLine($"y = {b}");*/

/*Task 6
void Sum(int a)
{
    for (int i = 1; i <= a; i++)
    {
        if (a % i == 0)
        {
            System.Console.Write(i + " ");
        }
    }
}
int a = Convert.ToInt32(System.Console.ReadLine());
Sum(a);*/

/*Task 8
void Sum(int a, int b, int c, int d)
{
    int min = a;
    if (b < min) min = b;
    if (c < min) min = c;
    if (d < min) min = d;
    System.Console.WriteLine(min);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
int d = Convert.ToInt32(Console.ReadLine());

Sum(a, b, c, d);*/

/*Task 9
void Sum(int a, int b)
{
    int min = 10;
    if (a < min) min = a;
    if (b < min) min = b;
    System.Console.WriteLine(min);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Sum(a, b);*/

/*Task 10
void Sum(int a, int b)
{
    int max = -10;
    if (a > max) max = a;
    if (b > max) max = b;
    System.Console.WriteLine(max);
}
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

Sum(a, b);*/