namespace DST_MAIN;
public static class BinarySearch
{
    public static int BinarySearchs(int[] array, int targetValue)
    {
        int min = 0;
        int max = array.Length - 1;
        int guess;
        while (true)
        {
            if (max < min)
            {
                return -1;
            }
            guess = (min + max) / 2;
            if (array[guess] == targetValue)
            {
                return guess;
            }
            else if (array[guess] < targetValue)
            {
                min = guess + 1;
            }
            else
            {
                max = guess - 1;
            }
        }
    }
}
