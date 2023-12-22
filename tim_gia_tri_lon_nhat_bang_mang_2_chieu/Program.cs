using System.ComponentModel.DataAnnotations;

internal class Progtam
{
    public static void Main(string[] args)
    {
        /*
        int [,] array = new int[4,5]; //cách 1 
        int[,] aray = { {1,2,3},
                        {4,5,6},
                        {3,4,5},
                      };
        //leangth
        //hàng getlength(0),cột getlength(1);
        Console.WriteLine(aray.GetLength(0));
        Console.WriteLine(aray.GetLength(1));
        Console.WriteLine(array.GetLength(0));
        Console.WriteLine(array.GetLength(1));
        Console.WriteLine(aray.Length);
        */
        int[,] aray = { {1,2,3},
                        {4,5,6},
                        {3,4,5},
                      };
        int max = aray[0,0];
        for(int i=0;i<aray.GetLength(0);i++)
        {
            for(int j=0;j<aray.GetLength(1);j++)
            {
                if(aray[i,j]>max)
                {
                   max = aray[i,j];
                }
            }
        }
        Console.WriteLine("gia tri lon nhat trong mang 2 chieu la "+max);
    }
}
