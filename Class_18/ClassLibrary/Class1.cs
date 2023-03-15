namespace ClassLibrary
{
    public class Triangle
    {
        public int sidea;
        public int sideb;
        public int sidec;

        public Triangle(int sideA, int sideB, int sideC)
        {
            this.sidea = sideA;
            this.sideb = sideB;
            this.sidec = sideC;
        }

        public bool allSidesChecker()
        {
            if (sidea == null)
            {
                return false;
            }
            else if (sideb == null)
            {
                return false;
            }
            else if (sidec == null)
            {
                return false;
            }
            return true;
        }

        public int PerimetrOfTriangle(int sideA, int sideB, int sideC)
        {
            return sideA + sideB + sideC;
        }

        public double SquareOfTriangle(int sideA, int sideB, int sideC)
        {
            double perimetr = Convert.ToDouble(PerimetrOfTriangle(sideA, sideB, sideC));
            double square = Convert.ToDouble(Math.Sqrt(perimetr * (perimetr - sideA) * (perimetr - sideB) * (perimetr - sideC)));
            return square;
        }

        public string TypeOfTriangle(int sideA, int sideB, int sideC)
        {
            string triangleType = "";
            if (sideA != sideB && sideA != sideC && sideB != sideC)
            {
                triangleType = "разносторонний";
            }
            else if (sideA == sideB && sideA == sideC)
            {
                triangleType = "равносторонний";
            }
            else if (sideA == sideB || sideA == sideC || sideB == sideC)
            {
                triangleType = "равнобердренный";
            }
            return triangleType;
        }
    }

    public class Rectangle
    {
        public int sidelength;
        public int sidewidth;


        public Rectangle(int sideLength, int sideWidth)
        {
            this.sidelength = sideLength;
            this.sidewidth = sideWidth;
        }

        public int PerimetrOfRectangle(int sideLength, int sideWidth)
        {
            return (sideLength + sideWidth) * 2;
        }
        public int SquareOfRectangle(int sideLength, int sideWidth)
        {
            return sideLength * sideWidth;
        }
    }

    public class Furniture
    {
        public string type;
        public string color;
        public decimal cost;
        public double size;
        public bool In_Stok;

        public Furniture(string type, string color, decimal cost, bool In_Stok, double size)
        {
            this.type = type;
            this.color = color;
            this.cost = cost;
            this.In_Stok = In_Stok;
            this.size = size;
        }

        public bool Check(bool In_Stok)
        {
            if (!In_Stok)
            {
                return false;
            }
            return true;
        }

        public void AddToStok()
        {
            In_Stok = true;
        }

        public void RemoveFromStok()
        {
            In_Stok = false;
        }

    }
}