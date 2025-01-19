using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice;
            string con = "y";
            Console.WriteLine("Tu khoa nao de ket thuc vong lap while:");
            Console.WriteLine("a. Quit");
            Console.WriteLine("b. Continued");
            Console.WriteLine("c. Break");
            Console.WriteLine("d. Exit");

            while (con == "y") {
                Console.WriteLine("Nhap vao cau tra loi: ");
                choice = Console.ReadLine();
                if(choice == "c")
                {
                    Console.WriteLine("Chuc mung ban tra loi dung ^^!");
                }else if(choice == "q" || choice == "e")
                {
                    Console.WriteLine("Ket thuc...");
                    break;
                }
                else
                {
                    Console.WriteLine("Khong dung");
                }

                Console.Write("Them luot nua? An 'y' de tiep tuc!");
                con = Console.ReadLine().ToString();
            }
        }
    }
}
