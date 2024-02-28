using System;

namespace LocalMaxima
{
	internal class LocalMaxima
	{
		static void Main(string[] args)
		{
			int matrixLength = 30;
			int[] matrix = new int[matrixLength];

			Random random = new Random();
			int maxValue = 101;

			for (int i = 0; i < matrixLength; i++)
			{
				matrix[i] = random.Next(maxValue);
				Console.Write(matrix[i] + "  ");
			}

			Console.Write("\nЛокальные максимумы: ");

			if (matrix[0] > matrix[1])
				Console.Write(matrix[0] + "  ");

			for (int i = 1; i < matrix.Length - 1; i++)
			{
				if (matrix[i] > matrix[i - 1] && matrix[i] > matrix[i + 1])
					Console.Write(matrix[i] + "  ");
			}

			if (matrix[matrixLength - 1] > matrix[matrixLength - 2])
				Console.Write(matrix[matrixLength - 1] + "  ");

			Console.WriteLine();
		}
	}
}
