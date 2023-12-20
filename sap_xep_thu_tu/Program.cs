class Program
{
    public static void Main(string[] args)
    {
        
        Console.WriteLine("can bao nhieu so : ");
        int n = int.Parse(Console.ReadLine());
        int[] array = new int[n];
        for(int i=0;i<n;i++)
        {   
            Console.Write($"array[{i}] ");
            array[i]= int.Parse(Console.ReadLine());
        }
        for(int i=0;i<n-1;i++)
        {
            for(int j=0;j<n-i-1;j++)
            {
                if(array[j]<array[j+1])
                {
                    int tam;
                    tam = array[j];
                    array[j]=array[j+1];
                    array[j+1]=tam;
                }
            }
        }
        Console.WriteLine("vay sau khi sap sep la :");
        for(int i=0;i<n;i++)
        {
            Console.Write(" "+array[i]);
        }
    }
}

