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

            List<int> nums = new List<int>();
            List<int> nums2 = new List<int>();

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

            foreach (var num in nums2)
            {
                Console.WriteLine(num);
            }

            Console.ReadKey();
        }
    }
}
