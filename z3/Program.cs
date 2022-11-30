Console.Write("Введите число: ");
string num1 = Console.ReadLine()!;
int inputNum1 = int.Parse(num1);

int div = inputNum1 % 2;

if (div == 0)
{
    Console.WriteLine("YES");
}
else
{
    Console.WriteLine("NO");
}