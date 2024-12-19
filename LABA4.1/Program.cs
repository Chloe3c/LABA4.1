int[] array = { 2, 4, 6, 8, 10 };

if (array.Length < 2)
{
    Console.WriteLine("Не образуют арифметическую прогрессию.");
}
else
{
    int difference = array[1] - array[0];
    bool ist = true;

    for (int i = 1; i < array.Length - 1; i++)
    {
        if (array[i + 1] - array[i] != difference)
        {
            ist = false;
            break;
        }
    }

    if (ist)
    {
        Console.WriteLine("Образуют арифметическую прогрессию.");
    }
    else
    {
        Console.WriteLine("Не образуют арифметическую прогрессию.");
    }
}
