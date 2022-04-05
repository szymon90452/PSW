namespace Program
{
    class Program
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Proszę podać wymiar macierzy kwadratowej: ");
            int matrixSize = int.Parse(Console.ReadLine());

            int[,] matrix = new int[matrixSize, matrixSize];
            int[,] matrix2 = new int[matrixSize, matrixSize];

            MatrixInput(matrix, matrixSize);

            MatrixInput(matrix2, matrixSize);

            MatrixAdd(matrix, matrix2, matrixSize);

            MatrixSubstract(matrix, matrix2 ,matrixSize);

            MatrixMultipification(matrix, matrix2, matrixSize);
        }
        static void MatrixDisplay(int[,] matrix,int matrixSize)
        {
            Console.WriteLine("Wyświetlam macierz");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    Console.Write(matrix[i, j] + " ");
                }
                Console.Write("\n");
            }
            Console.WriteLine();
        }

        static void MatrixInput(int[,] matrix, int matrixSize)
        {
            Random rnd = new Random();
            Console.WriteLine("Wypełniam macierz wartosciami...");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 11);
                }
            }
            MatrixDisplay(matrix, matrixSize);
        }

        static void MatrixAdd(int[,] matrix, int[,] matrix2, int matrixSize)
        {
            int[,] matrixResult = new int[matrixSize, matrixSize];
            Console.WriteLine("Dodawanie macierzy");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrixResult[i, j] = matrix[i, j] + matrix2[i, j];
                }
            }
            MatrixDisplay(matrixResult, matrixSize);
        }

        static void MatrixSubstract(int[,] matrix, int[,] matrix2, int matrixSize)
        {
            int[,] matrixResult = new int[matrixSize, matrixSize];
            Console.WriteLine("Odejmowanie macierzy");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    matrixResult[i, j] = matrix[i, j] - matrix2[i, j];
                }
            }
            MatrixDisplay(matrixResult, matrixSize);
        }

        static void MatrixMultipification(int[,] matrix, int[,] matrix2, int matrixSize)
        {
            int[,] matrixResult = new int[matrixSize, matrixSize];
            Console.WriteLine("Mnożenie macierzy");
            for (int i = 0; i < matrixSize; i++)
            {
                for (int j = 0; j < matrixSize; j++)
                {
                    int w = 0;
                    for (int k = 0; k < matrixSize; k++)
                        w += matrix[i, k] * matrix2[k, j];
                    matrixResult[i, j] = w;
                }

            }
            MatrixDisplay(matrixResult, matrixSize);
        }
    }
}