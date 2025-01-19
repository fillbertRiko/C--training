using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InRaMang
{
    internal class Program
    {
        static void Main(string[] args)
        {
            printArr();
            Console.ReadLine();
        }

        static void printArr()
        {
            int i, j;
            int[,] tArr = new int[5, 5];
            for (i = 0; i < 5; i++) //Khởi gán các giá trị tới mảng 2 chiều
                for (j = 0; j < 5; j++)
                {
                    if (i == 0)
                        tArr[i, j] = j + 1; //Điền vào hàng đầu tiên
                    else if (i > 0 && j == 0)
                        tArr[i, j] = tArr[i - 1, 4] + 1; //lấy giá trị của ô sau cùng trong hàng trước 
                    else
                        tArr[i, j] = tArr[i, j - 1] + 1; //Điền vào các ô tiếp theo
                }
            for (i=0;i<5;i++)
            {
                for(j=0;j<5;j++)
                {
                    Console.WriteLine("{0}\t",tArr[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}
