//Масив
//  №1 
int[] numbers = [3, 1, 1, 3];
int number = 0;
double arithmetic_mean = 0;

for (int i = 0; i < numbers.Length; i++)
{
    number += numbers[i];
    arithmetic_mean = number / numbers.Length;
}
Console.WriteLine($"Середнє арифметичне значення становить {arithmetic_mean}");

// Завдання №2 Чи є масив Паліндромом
int[] numbers_2 = [1, 2, 3, 2, 1];
bool palindrome = true;
int begin = 0, end = numbers.Length - 1;
while (begin < end)
{
    if (numbers[begin] != numbers[end])
    {
        palindrome = false;
        break;
    }
    begin++;
    end--;
}
if (palindrome == true)
{
    Console.WriteLine("Палiндром");
}
else
{
    Console.WriteLine("Не палiндром");
}

//№3 
int[] numbers_3 = [8, 2, 3, 2, 6], a = [];
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] % 2 == 0)
    {
        Console.WriteLine(numbers[i]);
    }
}

//№4
int[] numbers_4 = [6, -1, 9, -2];
int result = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > 0)
    {
        result += numbers[i];
    }    

}
Console.WriteLine($"Сума додатних чисел становить {result}");

//№5 
int[] numbers_5 = [3, 1, 2];
int min = numbers[0];
for (int i = 0; i < numbers.Length; i++)
{
    if (min > numbers[i])
    {
        min = numbers[i];
    }
}
Console.WriteLine($"Мiнiмальне число: {min}");

// №6 
int[] numbers_6 = [1, -15, 5, -8, -2];
int result_3 = 1;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] < 0)
    {
        result *= numbers[i];
    }
}
Console.WriteLine($"Добуток вiд'ємних чисел становить {result}");

//№7 
int[,] matrix =
{
    { 1, 2, 3, 4},
    { 4, 1, 2, 3},
    { 2, 3, 1, 4},
    { 4, 2, 3, 1},
};
int result_4 = 0, numeric = 0;

for (int i = 0; i < matrix.GetLength(0); i++)
{
    result += matrix[i, numeric];
    numeric++;
}
Console.WriteLine($"Сума елементiв по головнiй дiагоналi становить {result}");

// №8 
int[,] matrix_2 =
{
    {1, 2, 1, 2},
    {2, 1, 2, 1},
    {3, 2, 1, 1},
};
int result_2 = 1, numeric_1 = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
        result *= matrix[i, j];
}
Console.WriteLine($"Загальний добуток всix елементiв становить: {result}");

// №9 
int[,] matrix_ =
{
    {1, 2, 3},
    {4, 5, 6},
    {7, 8, 9},
};
int number_ = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = i + 1; j < matrix.GetLength(1); j++)
    {
        number = matrix[i, j];
        matrix[i, j] = matrix[j, i];
        matrix[j, i] = number;

    }
    Console.WriteLine();
}

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        Console.WriteLine(matrix[i, j] + " ");
    }
    Console.WriteLine();
}