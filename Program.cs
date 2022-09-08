internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(NumJewelsInStones("aA", "aAAbbbb"));
        Console.WriteLine(NumJewelsInStones("z", "ZZ"));
    }

    public static int NumJewelsInStones(string jewels, string stones) {
        jewels.ToHashSet();
        int result = 0;
        for (int i = 0; i < stones.Length; i++)
        {
            if(jewels.Contains(stones[i])) result = result + 1;
        }        
        return result;
    }
}