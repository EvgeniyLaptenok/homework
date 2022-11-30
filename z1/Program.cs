Console.Write("Введите первое число: ");
string num1 = Console.ReadLine()!;
int inputNum1 = int.Parse(num1);

Console.Write("Введите второе число: ");
string num2 = Console.ReadLine()!;
int inputNum2 = int.Parse(num2);

int max = inputNum1;

if (max < inputNum2)
{
    Console.WriteLine(max = inputNum2);
}
else 
{
    Console.WriteLine(max);
}
