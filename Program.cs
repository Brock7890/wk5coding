Console.WriteLine("Enter the size of your array");
int arraySize = Convert.ToInt32(Console.ReadLine());
int[] array = new int[arraySize];
int big = 0;
int small = 2147483647;
Console.WriteLine($"Please enter {arraySize} numbers");
for (int i = 0; i < arraySize; i++)
{
    Console.Write($"{i + 1}: ");
    array[i] = Convert.ToInt32(Console.ReadLine());
    if (array[i] > big)
    {
        big = array[i];
    }
    else if (array[i] < small)
    {
        small = array[i];
    }
}

Console.WriteLine($"{big} is the biggest number in your array, and {small} is the smallest number in the array");
Console.ReadKey();