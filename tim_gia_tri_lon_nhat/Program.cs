class Program
{
    public static void Main(string[] args)
    {
        int n=123312;
        while(n>20)
        {
            Console.WriteLine("nhap so luong : ");
            n = int.Parse(Console.ReadLine());
            if(n>20)
            {
                Console.WriteLine("gia tri qua muc quy dinh! vui long nhap lai");
            }
        }
        int[] a = new int[n];
        int max =0;
        Console.WriteLine("nhap gia tri cua mang : ");
        for(int i=0;i<n;i++)
        {
            Console.Write($"gia tri [{i}] = ");
            a[i]=int.Parse(Console.ReadLine());
        }
        for(int i=0;i<n-1;i++)
        {
            if(a[i]>a[i+1])
            {
                max = a[i];
            }
        }
        Console.WriteLine("vay gia tri lon nhat la : "+max);
    }
}
