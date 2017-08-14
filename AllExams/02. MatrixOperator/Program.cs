namespace _02.MatrixOperator
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int rows = int.Parse(Console.ReadLine());

            List<List<int>> matrix = new List<List<int>>();

            for (int i = 0; i < rows; i++)
            {
                matrix.Add(Console.ReadLine().Split().Select(int.Parse).ToList());

            }
            Commands(matrix);
        }

        private static void Commands(List<List<int>> matrix)
        {
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split();
                string commandName = tokens[0];
                string firstParameter = tokens[1];
                string secondParameter = tokens[2];

                switch (commandName)
                {
                    case "swap":
                        Swap(matrix, firstParameter, secondParameter);
                        break;
                    case "insert":
                        Insert(matrix, firstParameter, secondParameter);
                        break;
                    case "remove":
                        Remove(matrix, firstParameter, secondParameter, int.Parse(tokens[3]));
                        break;
                }
                command = Console.ReadLine();
            }
            PrintMatrix(matrix);

        }

        private static void PrintMatrix(List<List<int>> matrix)
        {
            foreach (var row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }


        private static void Remove(List<List<int>> matrix, string type, string position, int index)
        {

            if (position == "row")
            {
                switch (type)
                {
                    case "positive":
                        matrix[index] = matrix[index].Where(n => n < 0).ToList();
                        break;
                    case "negative":
                        matrix[index] = matrix[index].Where(n => n >= 0).ToList();
                        break;
                    case "odd":
                        matrix[index] = matrix[index].Where(n => n % 2 == 0).ToList();
                        break;
                    case "even":
                        matrix[index] = matrix[index].Where(n => n % 2 != 0).ToList();
                        break;
                }
            }
            else
            {
                switch (type)
                {
                    case "positive":
                        for (int currentRow = 0; currentRow < matrix.Count; currentRow++)
                        {
                            if (index >= matrix[currentRow].Count)
                            {
                                continue;
                            }
                            if (matrix[currentRow][index] >= 0)
                            {
                                matrix[currentRow].RemoveAt(index);
                            }

                        }
                        break;
                    case "negative":
                        for (int currentRow = 0; currentRow < matrix.Count; currentRow++)
                        {
                            if (index >= matrix[currentRow].Count)
                            {
                                continue;
                            }
                            if (matrix[currentRow][index] < 0)
                            {
                                matrix[currentRow].RemoveAt(index);
                            }

                        }
                        break;
                    case "odd":
                        for (int currentRow = 0; currentRow < matrix.Count; currentRow++)
                        {
                            if (index >= matrix[currentRow].Count)
                            {
                                continue;
                            }
                            if (matrix[currentRow][index] % 2 != 0)
                            {
                                matrix[currentRow].RemoveAt(index);
                            }

                        }
                        break;
                    case "even":
                        for (int currentRow = 0; currentRow < matrix.Count; currentRow++)
                        {
                            if (index >= matrix[currentRow].Count)
                            {
                                continue;
                            }
                            if (matrix[currentRow][index] % 2 == 0)
                            {
                                matrix[currentRow].RemoveAt(index);
                            }

                        }
                        break;
                }

            }
        }

        private static void Insert(List<List<int>> matrix, string firstParameter, string secondParameter)
        {
            int rowIndex = int.Parse(firstParameter);
            int number = int.Parse(secondParameter);
            matrix[rowIndex].Insert(0, number);
        }

        private static void Swap(List<List<int>> matrix, string firstParameter, string secondParameter)
        {
            int firstRow = int.Parse(firstParameter);
            int secondRow = int.Parse(secondParameter);

            List<int> temporary = matrix[firstRow];
            matrix[firstRow] = matrix[secondRow];
            matrix[secondRow] = temporary;
        }
    }
}
