using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MathNet.Numerics.LinearAlgebra;

namespace MATRIX_CALCULATOR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeMatrix(3, 3); // Tamaño inicial de las matrices (3x3)
        }

        private void InitializeMatrix(int rows, int columns)
        {
            // Configura las DataGridViews para matrices A, B y Resultado
            SetupDataGridView(dataGridView1, rows, columns);
            SetupDataGridView(dataGridView2, rows, columns);
            SetupDataGridView(dataGridViewResult, rows, columns);
        }

        private void SetupDataGridView(DataGridView dgv, int rows, int columns)
        {
            dgv.AllowUserToAddRows = false; // Deshabilita la adición automática de filas
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            for (int i = 0; i < columns; i++)
            {
                dgv.Columns.Add($"col{i}", $"Col {i + 1}");
                dgv.Columns[i].Width = 30;
            }

            for (int i = 0; i < rows; i++)
            {
                dgv.Rows.Add();
            }
        }

        private double[,] GetMatrixFromDataGridView(DataGridView dgv)
        {
            int rows = dgv.RowCount;
            int columns = dgv.ColumnCount;
            double[,] matrix = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    double value;
                    if (double.TryParse(dgv[j, i].Value?.ToString(), out value))
                    {
                        matrix[i, j] = value;
                    }
                    else
                    {
                        matrix[i, j] = 0; // Valor predeterminado
                    }
                }
            }

            return matrix;
        }

        private void DisplayResult(double[,] resultMatrix)
        {
            int rows = resultMatrix.GetLength(0);
            int columns = resultMatrix.GetLength(1);

            SetupDataGridView(dataGridViewResult, rows, columns);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewResult[j, i].Value = resultMatrix[i, j];
                }
            }
        }

        private void btnMultiply_Click_1(object sender, EventArgs e)
        {
            var matrixA = GetMatrixFromDataGridView(dataGridView1);
            var matrixB = GetMatrixFromDataGridView(dataGridView2);

            int rowsA = matrixA.GetLength(0);
            int columnsA = matrixA.GetLength(1);
            int columnsB = matrixB.GetLength(1);

            if (columnsA != matrixB.GetLength(0))
            {
                MessageBox.Show("El número de columnas de la primera matriz debe ser igual al número de filas de la segunda matriz.");
                return;
            }

            double[,] result = new double[rowsA, columnsB];

            for (int i = 0; i < rowsA; i++)
            {
                for (int j = 0; j < columnsB; j++)
                {
                    for (int k = 0; k < columnsA; k++)
                    {
                        result[i, j] += matrixA[i, k] * matrixB[k, j];
                    }
                }
            }

            DisplayResult(result);
        }

        private void btnSubtract_Click_1(object sender, EventArgs e)
        {
            var matrixA = GetMatrixFromDataGridView(dataGridView1);
            var matrixB = GetMatrixFromDataGridView(dataGridView2);

            int rows = matrixA.GetLength(0);
            int columns = matrixA.GetLength(1);
            double[,] result = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrixA[i, j] - matrixB[i, j];
                }
            }

            DisplayResult(result);
        }

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            var matrixA = GetMatrixFromDataGridView(dataGridView1);
            var matrixB = GetMatrixFromDataGridView(dataGridView2);

            int rows = matrixA.GetLength(0);
            int columns = matrixA.GetLength(1);
            double[,] result = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrixA[i, j] + matrixB[i, j];
                }
            }

            DisplayResult(result);
        }

        private void btnResize_Click_1(object sender, EventArgs e)
        {
            int rows = (int)numericUpDownRows.Value;
            int columns = (int)numericUpDownColumns.Value;
            InitializeMatrix(rows, columns);
        }

        private void btnMultiplyByScalar_Click(object sender, EventArgs e)
        {
            var matrixA = GetMatrixFromDataGridView(dataGridView1);
            int scalar = (int)numericUpDownScalar.Value;

            int rows = matrixA.GetLength(0);
            int columns = matrixA.GetLength(1);
            double[,] result = new double[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    result[i, j] = matrixA[i, j] * scalar;
                }
            }

            DisplayResult(result);
        }
        // Método para transponer una matriz
        private double[,] TransposeMatrix(double[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int columns = matrix.GetLength(1);
            double[,] transposedMatrix = new double[columns, rows];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    transposedMatrix[j, i] = matrix[i, j];
                }
            }

            return transposedMatrix;
        }

        //CALCULO DE LA INVERSA DE UNA MATRIZ
        private double[,] InverseMatrix(double[,] matrix)
        {
            int n = matrix.GetLength(0);
            double[,] result = new double[n, n];
            double[,] augmented = new double[n, 2 * n];

            // Crear la matriz aumentada (matriz original | matriz identidad)
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    augmented[i, j] = matrix[i, j];
                }
                augmented[i, i + n] = 1;
            }

            // Aplicar el método de Gauss-Jordan
            for (int i = 0; i < n; i++)
            {
                // Asegurarse de que el elemento diagonal no sea 0
                if (augmented[i, i] == 0)
                {
                    bool swapped = false;
                    for (int j = i + 1; j < n; j++)
                    {
                        if (augmented[j, i] != 0)
                        {
                            SwapRows(augmented, i, j);
                            swapped = true;
                            break;
                        }
                    }
                    if (!swapped)
                    {
                        MessageBox.Show("La matriz no tiene inversa.");
                        return null;
                    }
                }

                // Hacer que el elemento diagonal sea 1
                double diagonalValue = augmented[i, i];
                for (int j = 0; j < 2 * n; j++)
                {
                    augmented[i, j] /= diagonalValue;
                }

                // Hacer que los demás elementos en la columna sean 0
                for (int j = 0; j < n; j++)
                {
                    if (j != i)
                    {
                        double factor = augmented[j, i];
                        for (int k = 0; k < 2 * n; k++)
                        {
                            augmented[j, k] -= factor * augmented[i, k];
                        }
                    }
                }
            }

            // Extraer la inversa de la matriz aumentada
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i, j] = augmented[i, j + n];
                }
            }

            return result;
        }

        // Método para intercambiar filas
        private void SwapRows(double[,] matrix, int row1, int row2)
        {
            int n = matrix.GetLength(1);
            for (int i = 0; i < n; i++)
            {
                double temp = matrix[row1, i];
                matrix[row1, i] = matrix[row2, i];
                matrix[row2, i] = temp;
            }
        }


        private void btnInverse_Click(object sender, EventArgs e)
        {
            /*var matrixA = GetMatrixFromDataGridView(dataGridView1);

            int rows = matrixA.GetLength(0);
            int columns = matrixA.GetLength(1);

            if (rows != columns)
            {
                MessageBox.Show("La matriz debe ser cuadrada para calcular la inversa.");
                return;
            }

            var inverseMatrix = InverseMatrix(matrixA);
            if (inverseMatrix != null)
            {
                DisplayResult(inverseMatrix);
            }*/

            var matrixA = GetMatrixFromDataGridView(dataGridView1);

            int rows = matrixA.GetLength(0);
            int columns = matrixA.GetLength(1);

            if (rows != columns)
            {
                MessageBox.Show("La matriz debe ser cuadrada para calcular la inversa.");
                return;
            }

            var matrix = Matrix<double>.Build.DenseOfArray(matrixA);

            if (matrix.Determinant() == 0)
            {
                MessageBox.Show("La matriz no tiene inversa (determinante es 0).");
                return;
            }

            var inverseMatrix = matrix.Inverse();
            DisplayResult(inverseMatrix.ToArray());

        }

        private void btnTranspose_Click(object sender, EventArgs e)
        {
            var matrixA = GetMatrixFromDataGridView(dataGridView1);
            var transposedMatrix = TransposeMatrix(matrixA);
            DisplayResult(transposedMatrix);

        }
    }
}
