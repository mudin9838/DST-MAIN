namespace DST_MAIN;
public static class BinarySearch
{
    public static int BinarySearchs(int[] array, int target)
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
