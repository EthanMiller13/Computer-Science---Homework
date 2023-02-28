class Program
{
    public static void Main(string[] args){
        Random r = new Random();
        Point p1 = new Point(r.Next(-10, 11), r.Next(-10, 11));
        Point p2 = new Point(r.Next(-10, 11), r.Next(-10, 11));
        double midX = (p1.X + p2.X)/2;
        double midY = (p1.Y + p2.Y)/2;
        Point midPoint = new Point(midX, midY);
        Console.WriteLine(p1.ToString());
        Console.WriteLine(p2.ToString());
        Console.WriteLine(midPoint.ToString());
    }

    public class Point{
        private double _x;
        public double X {
            get { return _x; }
            set { this._x = value; }
        }
        private double _y;
        public double Y {
            get { return _y; }
            set { this._y = value; }
        }

        public Point(double x, double y){
            this._x = x;
            this._y = y;
        }

        public string ToString(){
            return $"x={this._x} y={this._y}";
        }
        
    }
}