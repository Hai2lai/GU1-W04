internal class Program
{
    public static void Main(string[] args)
    {
        string[] array = {"hung","huyen","hoang","hai"};
        string ten;
        Console.WriteLine("nhap ten ban muon tim : ");
        ten = Console.ReadLine();
        bool kiemtra = false;
        for (int i = 0; i < array.Length; i++)
        {
            if(array[i].Equals(ten))
            {
                Console.WriteLine($"co ten trong danh sach va o vi tri so {i+1}");
                kiemtra = true;
                break;
            }
        }
        if(kiemtra == false)
        {
            Console.WriteLine("khong co ten trong danh sach");
        }

    }
}
