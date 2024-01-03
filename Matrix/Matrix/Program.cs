Console.WriteLine("Choose one");
Console.WriteLine("1: Multiply by number");
Console.WriteLine("2: Addition");
Console.WriteLine("3: Determinant");
Console.WriteLine("Enter your choice");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("The number you want to multiply");
        double[,] matrix1 = new double[3, 3];
        double multiply = double.Parse(Console.ReadLine());
        Console.WriteLine("First matrix");
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i, j] = int.Parse(Console.ReadLine());
                matrix1[i, j] = matrix1[i, j] * multiply;
            }
        }

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                Console.Write(matrix1[i, j] + "\t");
            }
            Console.WriteLine();
        }

        break;

    case 2:
        Console.WriteLine("First matrix");
        double[,] matrix2 = new double[3, 3];

        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                matrix2[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < matrix2.GetLength(0); i++)
        {
            for (int j = 0; j < matrix2.GetLength(1); j++)
            {
                Console.Write(matrix2[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Second matrix");
        double[,] secondMatrix2 = new double[3, 3];

        for (int k = 0; k < secondMatrix2.GetLength(0); k++)
        {
            for (int l = 0; l < secondMatrix2.GetLength(1); l++)
            {
                secondMatrix2[k, l] = int.Parse(Console.ReadLine());
            }
        }

        for (int k = 0; k < secondMatrix2.GetLength(0); k++)
        {
            for (int l = 0; l < secondMatrix2.GetLength(1); l++)
            {
                Console.Write(secondMatrix2[k, l] + "\t");
            }
            Console.WriteLine();
        }

        double[,] resultMatrix2 = new double[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix2[i, j] = matrix2[i, j] + secondMatrix2[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("Final result");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultMatrix2[i, j] + "\t");
            }
            Console.WriteLine();
        }
        break;

    case 3:
        Console.WriteLine("Matrix");
        double[,] matrix3 = new double[3, 3];

        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = int.Parse(Console.ReadLine());
            }
        }

        double determinant = matrix3[0, 0] * (matrix3[1, 1] * matrix3[2, 2] - matrix3[1, 2] * matrix3[2, 1])
                        - matrix3[0, 1] * (matrix3[1, 0] * matrix3[2, 2] - matrix3[1, 2] * matrix3[2, 0])
                        + matrix3[0, 2] * (matrix3[1, 0] * matrix3[2, 1] - matrix3[1, 1] * matrix3[2, 0]);

        Console.WriteLine($"Determinant: {determinant}");
        break;
}