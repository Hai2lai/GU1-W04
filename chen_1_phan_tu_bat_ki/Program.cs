internal class Program
{
    private static void Main(string[] args)
    {   
        Console.Write("trong mang co bao nhieu phan tu : ");
        int n = int.Parse(Console.ReadLine());
        int[] a = new int[n];
        for(int i=0;i<n;i++)
        {
            Console.Write($"a[{i}]");
            a[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<n;i++)
        {
            Console.Write($"{a[i]} ");
        }
        Console.WriteLine("ban muon chen so bao nhieu");
        int c=int.Parse(Console.ReadLine());
        Console.WriteLine($"ban muon chen so {c} vao vi tri nao ?");
        int vtr = int.Parse(Console.ReadLine());
        n++;
        Array.Resize(ref a,n);
        for(int i=n-1;i>vtr;i--)
        {
            a[i]=a[i-1];
        }
        a[vtr]=c;
        for(int i=0;i<n;i++)
        {
            Console.Write($"{a[i]} ");
        }
    }
}