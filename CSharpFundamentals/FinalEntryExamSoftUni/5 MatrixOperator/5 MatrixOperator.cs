using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_MatrixOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            List<List<int>> matrix = new List<List<int>>();

            for (int row = 0; row < rows; row++)
            {
                matrix.Add(Console.ReadLine().Split(' ').Select(int.Parse).ToList());
            }

            var input = Console.ReadLine();
            while (input != "end")
            {
                var info = input.Split(' ').ToList();
                if (input.Contains("remove"))
                {
                    var type = info[1];
                    var dimention = info[2];
                    var index = int.Parse(info[3]);
                    Remove(matrix, type, dimention, index);
                }
                else if (input.Contains("swap"))
                {
                    var row1 = int.Parse(info[1]);
                    var row2 = int.Parse(info[2]);
                    Swap(matrix, rows, row1, row2);
                }
                else if (input.Contains("insert"))
                {
                    var row = int.Parse(info[1]);
                    var num = int.Parse(info[2]);
                    matrix[row].Insert(0, num);
                }

                input = Console.ReadLine();
            }

            PrintTheMatrix(matrix);
        }

        private static void PrintTheMatrix(List<List<int>> matrix)
        {
            for (int i = 0; i < matrix.Count; i++)
            {
                Console.WriteLine(string.Join(" ", matrix[i]));
            }
        }

        public static void Swap(List<List<int>> matrix, int rows, int row1, int row2)
        {
            var temp = matrix[row1];
            matrix[row1] = matrix[row2];
            matrix[row2] = temp;
        }

        public static void Remove(List<List<int>> matrix, string type, string dimention, int index)
        {
            if (dimention == "row")
            {
                switch (type)
                {
                    case "even":
                        matrix[index] = matrix[index].Where(x => x % 2 != 0).ToList();
                        break;
                    case "odd":
                        matrix[index] = matrix[index].Where(x => x % 2 == 0).ToList();
                        break;
                    case "positive":
                        matrix[index] = matrix[index].Where(x => x < 0).ToList();
                        break;
                    case "negative":
                        matrix[index] = matrix[index].Where(x => x >= 0).ToList();
                        break;
                }
            }
            else
            {
                switch (type)
                {
                    case "even":
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            if (index >= matrix[i].Count)
                            {
                                continue;
                            }
                            if (matrix[i][index] % 2 == 0)
                            {
                                matrix[i].RemoveAt(index);
                            }
                        }
                        break;
                    case "odd":
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            if (index >= matrix[i].Count)
                            {
                                continue;
                            }
                            if (matrix[i][index] % 2 != 0)
                            {
                                matrix[i].RemoveAt(index);
                            }
                        }
                        break;
                    case "positive":
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            if (index >= matrix[i].Count)
                            {
                                continue;
                            }
                            if (matrix[i][index] >= 0)
                            {
                                matrix[i].RemoveAt(index);
                            }
                        }
                        break;
                    case "negative":
                        for (int i = 0; i < matrix.Count; i++)
                        {
                            if (index >= matrix[i].Count)
                            {
                                continue;
                            }
                            if (matrix[i][index] < 0)
                            {
                                matrix[i].RemoveAt(index);
                            }
                        }
                        break;

                }
            }
        }
        //    int row = num;
        //    if (type == "even")
        //    {
        //        for (int col = 0; col < matrix[row].Count; col++)
        //        {
        //            if (matrix[row][col] % 2 == 0)
        //            {
        //                matrix[row].Remove(matrix[row][col]);
        //                col--;
        //            }
        //        }
        //    }
        //    else if (type == "odd")
        //    {
        //        for (int col = 0; col < matrix[row].Count; col++)
        //        {
        //            if (matrix[row][col] % 2 != 0)
        //            {
        //                matrix[row].Remove(matrix[row][col]);
        //                col--;
        //            }
        //        }
        //    }
        //    else if (type == "positive")
        //    {
        //        for (int col = 0; col < matrix[row].Count; col++)
        //        {
        //            if (matrix[row][col] >= 0)
        //            {
        //                matrix[row].Remove(matrix[row][col]);
        //                col--;
        //            }
        //        }
        //    }
        //    else if (type == "negative")
        //    {
        //        for (int col = 0; col < matrix[row].Count; col++)
        //        {
        //            if (matrix[row][col] < 0)
        //            {
        //                matrix[row].Remove(matrix[row][col]);
        //                col--;
        //            }
        //        }
        //    }
        //}
        //if (dimention == "col")
        //{
        //    int col = num;
        //    if (type == "even")
        //    {
        //        for (int row = 0; row < rows; row++)
        //        {
        //            if (col < matrix[row].Count && matrix[row][col] % 2 == 0)
        //            {
        //                matrix[row].Remove(matrix[row][col]);
        //                row--;
        //            }
        //        }
        //    }
        //    else if (type == "odd")
        //    {
        //        for (int row = 0; row < rows; row++)
        //        {
        //            if (col < matrix[row].Count && matrix[row][col] % 2 != 0)
        //            {
        //                matrix[row].Remove(matrix[row][col]);
        //                row--;
        //            }
        //        }
        //    }
        //    else if (type == "positive")
        //    {
        //        for (int row = 0; row < rows; row++)
        //        {
        //            if (col < matrix[row].Count && matrix[row][col] >= 0)
        //            {
        //                matrix[row].Remove(matrix[row][col]);
        //                row--;
        //            }
        //        }
        //    }
        //    else if (type == "negative")
        //    {
        //        for (int row = 0; row < rows; row++)
        //        {
        //            if (col < matrix[row].Count && matrix[row][col] < 0)
        //            {
        //                matrix[row].Remove(matrix[row][col]);
        //                row--;
        //            }
        //        }
        //    }
        //}

    }
}

