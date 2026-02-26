// Multidimensional Arrays in Java

public class MultiDimensionalArrays {
    public static void main(String[] args) {
        // 2D Array Declaration and Initialization
        int[][] matrix = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };
        
        // Alternative declaration
        int[][] arr = new int[3][3];
        
        // Accessing elements
        System.out.println("Element at [1][2]: " + matrix[1][2]);
        
        // Iterating through 2D array
        for (int i = 0; i < matrix.length; i++) {
            for (int j = 0; j < matrix[i].length; j++) {
                System.out.print(matrix[i][j] + " ");
            }
            System.out.println();
        }
        
        // Enhanced for loop
        for (int[] row : matrix) {
            for (int element : row) {
                System.out.print(element + " ");
            }
            System.out.println();
        }
        
        // 3D Array
        int[][][] cube = new int[2][3][4];
        
        // Jagged array (different row lengths)
        int[][] jaggedArray = {
            {1, 2},
            {3, 4, 5},
            {6, 7, 8, 9}
        };
    }
}