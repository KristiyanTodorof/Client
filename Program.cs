Console.Write("Enter days: ");
byte days = byte.Parse(Console.ReadLine());
double[] firstClient = new double[days];
double[] secondClient = new double[days];
double[] thirdClient = new double[days];

InsertSum(firstClient);
InsertSum(secondClient);
InsertSum(thirdClient);

CountDays(firstClient);
CountDays(secondClient);
CountDays(thirdClient);

MaxAndMinValues(firstClient);

static void InsertSum(double[] array)
{
    Console.WriteLine("Insert values:");
    for (int i = 0; i < array.Length; i++)
    {
        double sum = double.Parse(Console.ReadLine());
        array[i] = sum;
    }
}

static void CountDays(double[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] != 0)
        {
            count++;
        }
    }
    Console.WriteLine($"The number of days the client made a purchase is {count}");
}

static void MaxAndMinValues(double[] array)
{
    double max = double.MinValue;
    double min = double.MaxValue;
    int maxDay = 0;
    int minDay = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
            maxDay = i + 1;
        }

        if (array[i] < min)
        {
            min = array[i];
            minDay = i + 1;
        }
    }
    Console.WriteLine($"The max value is at day {maxDay}");
    Console.WriteLine($"The min value is at day {minDay}");
}