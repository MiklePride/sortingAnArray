class program
{
    static void Main(string[] args)
    {
        int[] arrayOfIntegers = new int[25];
        int indexArrayOfIntegers;
        int nextIndexArrayOfIntegers;
        Random random = new Random();
        int minimumRandomNumber = 0;
        int maximumRandomNumber = 46;
        int temporaryVariable;

        for (indexArrayOfIntegers = 0; indexArrayOfIntegers < arrayOfIntegers.Length; indexArrayOfIntegers++)
        {
            arrayOfIntegers[indexArrayOfIntegers] = random.Next(minimumRandomNumber, maximumRandomNumber);
            Console.Write(arrayOfIntegers[indexArrayOfIntegers] + " ");
        }

        for (indexArrayOfIntegers = 0; indexArrayOfIntegers < arrayOfIntegers.Length; indexArrayOfIntegers++)
        {
            for (nextIndexArrayOfIntegers = indexArrayOfIntegers + 1; nextIndexArrayOfIntegers < arrayOfIntegers.Length; nextIndexArrayOfIntegers++)
            {
                if (arrayOfIntegers[indexArrayOfIntegers] > arrayOfIntegers[nextIndexArrayOfIntegers])
                {
                    temporaryVariable = arrayOfIntegers[indexArrayOfIntegers];
                    arrayOfIntegers[indexArrayOfIntegers] = arrayOfIntegers[nextIndexArrayOfIntegers];
                    arrayOfIntegers[nextIndexArrayOfIntegers] = temporaryVariable;
                }
            }
        }
        Console.WriteLine("\n");

        for (indexArrayOfIntegers = 0; indexArrayOfIntegers < arrayOfIntegers.Length; indexArrayOfIntegers++)
        {
            Console.Write(arrayOfIntegers[indexArrayOfIntegers] + " ");
        }
    }
}