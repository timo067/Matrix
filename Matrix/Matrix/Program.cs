Console.WriteLine("Choose one");
Console.WriteLine("1: Addition");
Console.WriteLine("2: Subtraction");
Console.WriteLine("3: Multiply");
Console.WriteLine("4: Division");
Console.WriteLine("Enter your choice");
int choice = int.Parse(Console.ReadLine());

switch (choice)
{
    case 1:
        Console.WriteLine("First matrix");
        double[,] matrix1 = new double[3, 3];

        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                matrix1[i, j] = int.Parse(Console.ReadLine());
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

        Console.WriteLine("Second matrix");
        double[,] secondMatrix1 = new double[3, 3];

        for (int k = 0; k < secondMatrix1.GetLength(0); k++)
        {
            for (int l = 0; l < matrix1.GetLength(1); l++)
            {
                secondMatrix1[k, l] = int.Parse(Console.ReadLine());
            }
        }

        for (int k = 0; k < secondMatrix1.GetLength(0); k++)
        {
            for (int l = 0; l < secondMatrix1.GetLength(1); l++)
            {
                Console.Write(secondMatrix1[k, l] + "\t");
            }
            Console.WriteLine();
        }

        double[,] resultMatrix1 = new double[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix1[i, j] = matrix1[i, j] + secondMatrix1[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("Final result");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultMatrix1[i, j] + "\t");
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
                resultMatrix2[i, j] = matrix2[i, j] - secondMatrix2[i, j];
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
        Console.WriteLine("First matrix");
        double[,] matrix3 = new double[3, 3];

        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                Console.Write(matrix3[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Second matrix");
        double[,] secondMatrix3 = new double[3, 3];

        for (int k = 0; k < secondMatrix3.GetLength(0); k++)
        {
            for (int l = 0; l < secondMatrix3.GetLength(1); l++)
            {
                secondMatrix3[k, l] = int.Parse(Console.ReadLine());
            }
        }

        for (int k = 0; k < secondMatrix3.GetLength(0); k++)
        {
            for (int l = 0; l < secondMatrix3.GetLength(1); l++)
            {
                Console.Write(secondMatrix3[k, l] + "\t");
            }
            Console.WriteLine();
        }

        double[,] resultMatrix3 = new double[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix3[i, j] = matrix3[i, j] * secondMatrix3[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("Final result");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultMatrix3[i, j] + "\t");
            }
            Console.WriteLine();
        }
        break;

    case 4:
        Console.WriteLine("First matrix");
        double[,] matrix4 = new double[3, 3];

        for (int i = 0; i < matrix4.GetLength(0); i++)
        {
            for (int j = 0; j < matrix4.GetLength(1); j++)
            {
                matrix4[i, j] = int.Parse(Console.ReadLine());
            }
        }

        for (int i = 0; i < matrix4.GetLength(0); i++)
        {
            for (int j = 0; j < matrix4.GetLength(1); j++)
            {
                Console.Write(matrix4[i, j] + "\t");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Second matrix");
        double[,] secondMatrix4 = new double[3, 3];

        for (int k = 0; k < secondMatrix4.GetLength(0); k++)
        {
            for (int l = 0; l < secondMatrix4.GetLength(1); l++)
            {
                secondMatrix4[k, l] = int.Parse(Console.ReadLine());
            }
        }

        for (int k = 0; k < secondMatrix4.GetLength(0); k++)
        {
            for (int l = 0; l < secondMatrix4.GetLength(1); l++)
            {
                Console.Write(secondMatrix4[k, l] + "\t");
            }
            Console.WriteLine();
        }

        double[,] resultMatrix4 = new double[3, 3];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                resultMatrix4[i, j] = matrix4[i, j] / secondMatrix4[i, j];
            }
            Console.WriteLine();
        }

        Console.WriteLine("Final result");

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 3; j++)
            {
                Console.Write(resultMatrix4[i, j] + "\t");
            }
            Console.WriteLine();
        }
        break;
}