using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sapXepMang1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 1, 2, 5, 15, 3, 9, 10, 12, 15, 8 };

            bubbleSort(arr,10);

            for(int i=0;i<10;i++)
            {
                Console.Write(arr[i] + "  ");
            }

            Console.ReadLine();
        }

        static void bubbleSort(int[] dataset, int n)
        {
            for(int i=0;i<n;i++)
            {
                for(int j=n-1;j>i;j--)
                {
                    if(dataset[j] < dataset[j-1])
                    {
                        int temp = dataset[j];
                        dataset[j] = dataset[j-1];
                        dataset[j-1] = temp;
                    }
                }
            }
        }
    }
}
