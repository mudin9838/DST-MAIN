using DST_MAIN;

public class Program
{
    //Insertion
    public static void Main(string[] args)
    {

        int[] a = { 2, 5, 10, 15, 17, 21, 23, 25, 27, 29 };
        Array.Sort(a);

        Console.WriteLine(BinarySearch.BinarySearchs(a, 27)); //output 8
    }//
}







