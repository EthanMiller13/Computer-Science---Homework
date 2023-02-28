class Program
{
    public static void Main(string[] args){
        Point p1 = new Point(8, 6);
        Point p2 = new Point(8, 6);
        ComparePoints(p1, p2);
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

    public static void ComparePoints(Point p1, Point p2){
        if (p1.X == p2.X && p1.Y == p2.Y)
        {
            Console.WriteLine("Points are in the same location");
        }else{
            if(p1.X == p2.X){
                Console.WriteLine("Points are in the same column");
            }else if(p1.Y == p2.Y){
                Console.WriteLine("Points are in the same row");
            }else{
                Console.WriteLine("Points are not in the same column or row");
            }
        }
    }
    

}