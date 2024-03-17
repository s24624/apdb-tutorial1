public class program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("start");
        int a = 12;
        Console.WriteLine(a*2);
        int[] tab = { 1, 2, 10, 13, 2, 6 };
        Console.WriteLine(average(tab));
        Console.WriteLine(featureMax(tab));
        
    }

    public static double average(int[] tab)
    {
        int sum = 0;
        for (int i = 0; i < tab.Length; i++)
            sum += tab[i];
        return sum / tab.Length;
    }

    public static int featureMax(int[] tab)
    {
        int max = tab[0];
        for (int i = 0; i < tab.Length; i++)
        {
            if (tab[i] > max)
                max = tab[i];
        }

        return max;
    }
}