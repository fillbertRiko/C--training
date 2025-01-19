using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SapXepMangGiamDan
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 23, 2, 3, 34, 6, 1, 24, 45, 78, 8 }; //tập dữ liệu chưa sắp xếp
            bubblesort(arr, 10); //gọi thủ tục sắp xếp nổi bọt
            int i;
            for (i = 0; i < 10; i++)
                Console.Write(arr[i] + "\t"); //in ra kết quả theo thứ tự tăng dần
            Console.ReadLine();
        }
        ///Thuật toán nổi bọt
        static void bubblesort(int[] dataset, int n)
        {
            int i, j;
            for (i = 0; i < n; i++)
                for (j = n - 1; j > i; j--)
                    if (dataset[j] > dataset[j - 1])
                    {
                        int temp = dataset[j-1];
                        dataset[j-1] = dataset[j];
                        dataset[j] = temp;
                    }
        }
    }
}
