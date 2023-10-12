namespace Modelo
{
    public class Punto
    {
        private int _x;
        private int _y;

        public Punto(int X, int Y)
        {
            _x = X;
            _y = Y;
        }

        public override string ToString()
        {
            return String.Format($" x = {_x}, y = {_y} ");
        }
    }
}