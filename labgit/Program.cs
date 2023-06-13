using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace labgit
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inFile = new StreamReader("numbers.txt");

            var text = inFile.ReadToEnd();
            string[] numbers = text.Split(' ');

            List<double> nums = new List<double>();
            List<double> nums2 = new List<double>();

            foreach (var num in numbers)
            {
                try
                {
                    nums.Add(Convert.ToInt32(num));
                }
                catch (Exception e)
                {

                }
            }


            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] > 0 && nums[i] % 2 == 0)
                {
                    nums2.Add(nums[i]);
                }
            }

            int count = 0;
            foreach (var num in nums2)
            {
                if (Convert.ToInt32(Math.Sqrt(num)) * Convert.ToInt32(Math.Sqrt(num)) == num)
                {
                    count++;
                    Console.WriteLine(num + " - квадрат");
                }
                Console.WriteLine(num);
            }

            Console.WriteLine("Кол-во квадратов: " + count);






            Console.ReadKey();
        }

    }
}
