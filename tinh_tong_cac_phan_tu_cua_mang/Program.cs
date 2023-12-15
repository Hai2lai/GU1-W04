internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[5];
        int tong=0;
        Console.WriteLine("ban muon tinh tong cua 5 so nao");
        for(int i=0;i<5;i++)
        {
            array[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<5;i++)
        {   
            tong += array[i];
        }
        Console.WriteLine(tong);
}
}