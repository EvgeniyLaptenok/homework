Console.Write("Введите первое число: ");
string num1 = Console.ReadLine()!;
int inputNum1 = int.Parse(num1);

Console.Write("Введите второе число: ");
string num2 = Console.ReadLine()!;
int inputNum2 = int.Parse(num2);

Console.Write("Введите третье число: ");
string num3 = Console.ReadLine()!;
int inputNum3 = int.Parse(num3);

int max = inputNum1;

if (inputNum2 > max)
{
   max = inputNum2;
}
if (inputNum3 > max)
{
    max = inputNum3;
}
Console.WriteLine(max);