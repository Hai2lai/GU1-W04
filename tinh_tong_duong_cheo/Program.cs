internal class Program
{
    private static void Main(string[] args)
    {   
        Console.WriteLine("nhap gia tri cua hang");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("nhap gia tri cua cot");
        int m = int.Parse(Console.ReadLine());
        int [,] array = new int[n,m];
        Console.WriteLine("nhap cac phan tu trong mang");
        for(int i=0;i<array.GetLength(0);i++)
        {
            for(int j=0;j<array.GetLength(1);j++)
            {
                array[i,j]= int.Parse(Console.ReadLine());
            }
        }
        //in cac phan tu trong mang
        for(int i=0;i<n;i++)
        {
            Console.WriteLine();
            for(int j=0;j<m;j++)
            {
                Console.Write(array[i,j]+" ");
            }
        }
        int tong=0;
        for(int i=0;i<n;i++)
        {
            for(int j=0;j<m;j++)
            {
                if(i==j)
                {
                    tong += array[i,j];
                }
            }
        }
        Console.WriteLine();
        Console.WriteLine("vay gia tri duong cheo la : "+tong);
    }
}