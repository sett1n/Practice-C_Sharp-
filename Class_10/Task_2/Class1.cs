using System;

public class Matrix : IComparable<Matrix>
{
    private int[,] _data;

    public int Rows => _data.GetLength(0);
    public int Columns => _data.GetLength(1);

    public Matrix(int rows, int columns)
    {
        _data = new int[rows, columns];
    }

    public int this[int row, int column]
    {
        get { return _data[row, column]; }
        set { _data[row, column] = value; }
    }

    public void Resize(int rows, int columns)
    {
        int[,] newData = new int[rows, columns];
        int minRows = Math.Min(rows, Rows);
        int minCols = Math.Min(columns, Columns);

        for (int i = 0; i < minRows; i++)
        {
            for (int j = 0; j < minCols; j++)
            {
                newData[i, j] = _data[i, j];
            }
        }

        _data = newData;
    }

    public void Print()
    {
        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                Console.Write(_data[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    public void PrintSubMatrix(int row, int column, int rows, int columns)
    {
        for (int i = row; i < row + rows; i++)
        {
            for (int j = column; j < column + columns; j++)
            {
                Console.Write(_data[i, j] + "\t");
            }

            Console.WriteLine();
        }
    }

    public int CompareTo(Matrix other)
    {
        if (Rows != other.Rows || Columns != other.Columns)
        {
            throw new ArgumentException("Матрицы должны иметь одинаковый размер для сравнения");
        }

        int sumThis = 0;
        int sumOther = 0;

        for (int i = 0; i < Rows; i++)
        {
            for (int j = 0; j < Columns; j++)
            {
                sumThis += _data[i, j];
                sumOther += other[i, j];
            }
        }

        return sumThis.CompareTo(sumOther);
    }

    public static bool operator >(Matrix matrix1, Matrix matrix2)
    {
        return matrix1.CompareTo(matrix2) > 0;
    }

    public static bool operator <(Matrix matrix1, Matrix matrix2)
    {
        return matrix1.CompareTo(matrix2) < 0;
    }

    public static bool operator >=(Matrix matrix1, Matrix matrix2)
    {
        return matrix1.CompareTo(matrix2) >= 0;
    }

    public static bool operator <=(Matrix matrix1, Matrix matrix2)
    {
        return matrix1.CompareTo(matrix2) <= 0;
    }
}