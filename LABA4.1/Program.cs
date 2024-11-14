class Program
{
    static void Main()
    {
        int[] array = { 2, 4, 6, 8, 10 };

        if (IsArithmeticProgression(array))
        {
            Console.WriteLine("Образуют арифметическую прогрессию.");
        }
        else
        {
            Console.WriteLine("Не образуют арифметическую прогрессию.");
        }
    }

    static bool IsArithmeticProgression(int[] array)
    {
        if (array.Length < 2) return false;

        int difference = array[1] - array[0];

        for (int i = 1; i < array.Length - 1; i++)
        {
            if (array[i + 1] - array[i] != difference)
            {
                return false;
            }
        }

        return true;
    }
}