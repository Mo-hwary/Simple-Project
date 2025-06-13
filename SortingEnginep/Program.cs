using System;

class SortingEngine
{

    /*static void Main(string[] args)
    {
        int[] numbers = Sort(10, 3, 5, -1, 0, 12, 8);
        PrintNumbers(numbers);

        Console.ReadLine();

    }
    static int[] Sort(params int[] numbers)
    {

        for (int i = 0; i < numbers.Length - 1; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                // Swapping the values 
                if (numbers[i] > numbers[j])
                {
                    int oldNum = numbers[i];
                    numbers[i] = numbers[j];
                    numbers[j] = oldNum;
                }
            }
        }
        return numbers;
    }
    static void PrintNumbers(params int[] numbers)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("{0}", numbers[i]);
            if (i < (numbers.Length - 1))
            {
                Console.Write(", ");
            }
        }
    }*/

    /*/// <summary>
    /// ///////// Reverses the elements of an array and prints them.
    /// </summary>
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        //int length = array.Length;
        int[] reversed = new int[array.Length];

        // Initialize the reversed array 
        for (int index = 0; index < array.Length; index++)
        {
            reversed[array.Length - index - 1] = array[index];
        }

       // Print the reversed array 
        for (int index = 0; index < array.Length; index++)
        {
            Console.Write(reversed[index] + " ");
            Console.WriteLine(array [index]);
        }
    }*/

   /* /// find the great number in array
    static void main(string[] args)
    {
        int[] numbers = new int[] { 10, 3, 5, -1, 0, 12, 8 };

        int maxnumber = numbers[0];

        for (int i = 1; i < numbers.Length; i++)
        {
            if (numbers[i] > maxnumber)
            {
                maxnumber = numbers[i];
            }
        }

        Console.WriteLine($"The great number: {maxnumber}");
    }
*/
}


