Console.Write("Введите число: ");
string N = Console.ReadLine()!;
int inputN = int.Parse(N);

int count = 1;

while (count <= inputN)
{
    if (count % 2 == 0)
    {
        Console.WriteLine(count);
    }
    count++;
}