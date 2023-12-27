//Лабораторная 4.1 Высокий 25

Console.WriteLine("Введите три двоичных числа:");
int[] binaryNumbers = new int[3];
for (int i = 0; i < 3; i++)
{
    Console.Write($"Введите число {i + 1}: ");
    string input = Console.ReadLine();
    binaryNumbers[i] = Convert.ToInt32(input, 2);
}

int sumBeforeShift = 0;
foreach (int number in binaryNumbers)
{
    sumBeforeShift += Convert.ToInt32(number);
}

for (int i = 0; i < binaryNumbers.Length; i++)
{
    binaryNumbers[i] = binaryNumbers[i] << 1;
}

int sumAfterShift = 0;
foreach (int number in binaryNumbers)
{
    sumAfterShift += Convert.ToInt32(number);
}

foreach (int number in binaryNumbers)
{
    Console.WriteLine(Convert.ToString(number, 2));
}
Console.WriteLine("Сумма чисел до сдвига: " + sumBeforeShift);
Console.WriteLine("Сумма чисел после сдвига: " + sumAfterShift);