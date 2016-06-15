using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayManipulator
{
    class ArrayManipulator
    {
        static void Main(string[] args)
        {
            var nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            var input = Console.ReadLine().Split(' ');

            while (!input.Contains("print"))
            {
                if (input.Contains("addMany"))
                {
                    AddMany(nums, input);
                }
                else if (input.Contains("add"))
                {
                    Add(nums, input);
                }
                else if (input.Contains("contains"))
                {
                    Contains(nums, input);
                }
                else if (input.Contains("remove"))
                {
                    Remove(nums, input);
                }
                else if (input.Contains("shift"))
                {
                    Shift(nums, input);
                }
                else if (input.Contains("sumPairs"))
                {
                    SumPairs(nums);
                }
                input = Console.ReadLine().Split(' ');
            }

            Console.Write("[" + string.Join(", ", nums) + "]");
        }

        public static void AddMany(List<int> nums, string[] input)
        {
            int pos = int.Parse(input[1]);
            List<int> elementsToAdd = input.Skip(2).Select(int.Parse).ToList();
            nums.InsertRange(pos, elementsToAdd);
        }

        public static void Add(List<int> nums, string[] input)
        {
            int pos = int.Parse(input[1]);
            int element = int.Parse(input[2]);
            nums.Insert(pos, element);
        }

        public static void Remove(List<int> nums, string[] input)
        {
            int pos = int.Parse(input[1]);
            nums.RemoveAt(pos);
        }

        public static void Contains(List<int> nums, string[] input)
        {
            int element = int.Parse(input[1]);
            int index = nums.IndexOf(element);
            Console.WriteLine(index);
        }

        private static void Shift(List<int> nums, string[] input)
        {
            int pos = int.Parse(input[1]);
            int temp = 0;
            for (int i = 0; i < pos; i++)
            {
                temp = nums[0];
                nums.Remove(nums[0]);
                nums.Add(temp);
            }
        }

        public static void SumPairs(List<int> nums)
        {
            int size = nums.Count / 2;
            for (int i = 0; i < size; i++)
            {
                nums[i] += nums[i + 1];
                nums.RemoveAt(i + 1);
            }
        }
    }
}
