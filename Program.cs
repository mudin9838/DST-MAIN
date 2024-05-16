public class Program
{
    //Insertion
    public static void Main(string[] args)
    {

        int[] a = { 2, 5, 10, 15, 17, 21, 23, 25, 27, 29 };
        Array.Sort(a);
        Console.WriteLine(BinarySearch(a, 27));
    }//
    static int BinarySearch(int[] array, int target)
    {
        int min = 0;
        int max = array.Length - 1;
        int guess;
        while (true)
        {
            if (max >= min)
            {
                guess = (min + max) / 2;
                if (array[guess] != target)
                {
                    if (array[guess] < target)
                    {
                        min = guess + 1;
                    }
                    else
                    {
                        max = guess - 1;
                    }
                }
                else
                {
                    return guess;
                }
            }
            else
            {
                return -1;
            }
        }
    }
}







