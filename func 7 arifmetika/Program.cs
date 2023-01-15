//2. 3х значное число. Число едениц. Число десятков. Сумма цифр. Произведение цифр

/*
Console.WriteLine($"Введите число от 100 до 999 = ");
int a = int.Parse(Console.ReadLine());

if (a > 99 && a < 999)
{
    int b = a % 10;
    int c = a / 10;
    int d = a / 100; int e = b + c + d;
    int f = b * c * d;
}
else
{
    Console.WriteLine($"Введите число в диапазоне 100 - 999 ");
}
Console.WriteLine($"{ b},{ c},{ d},{ e}");
*/

int A(int a)
{
    Console.WriteLine($"Введите число от 100 до 999 = ");
    a = int.Parse(Console.ReadLine());
    if (a > 99 && a < 999) // как то надо bool запихнуть
else Console.WriteLine($"Введите число в диапазоне 100 - 999 ")
return a;
}

int B(int a)
{
    int b = a % 10;
    Console.WriteLine($"число едениц {b}");
    return b;
}

int C(int a)
{
    int c = a / 10;
    Console.WriteLine($"число десятков {c}");
    return c;
}

int D(int a, int b, int c)
{
    int d = a / 100;
    int e = b + c + d;
    Console.WriteLine($"Сумма цифр {e}");
    return e;
}

int F(int b, int c, int d)
{
    int f = b * c * d;
    Console.WriteLine($"Произведение цифр {f}");
    return f;
}