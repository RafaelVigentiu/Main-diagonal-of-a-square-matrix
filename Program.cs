namespace Ex6 {
    internal class Program {
        static void Main(string[] args) {
            int[,] matrix = new int[5, 5];
            int value = 1;

            // Fill matrix with sequential values.
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(0); j++) {
                    matrix[i, j] = value++;
                }
            }

            //Print diagonal elements.
            for (int i = 0; i < matrix.GetLength(0); i++) {
                Console.WriteLine(matrix[i, i]);
            }
        }
    }
}
