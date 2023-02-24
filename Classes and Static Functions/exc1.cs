namespace Exc1
{
    class Program{
        public static void Main(string[] args)
        {
            Jumper jumper = new Jumper("324523");
            jumper.SetJump1(2.11);
            jumper.SetJump2(3.2);
            jumper.SetJump3(1.6);
            jumper.SetRecord(3.4);

            Console.WriteLine(jumper.ToString());
            Console.WriteLine("Avg: " + jumper.Avg());
            Console.WriteLine("EqualToLast: " + jumper.EqualToLast());
        }
    }
    
    public class Jumper{
        private string _id;
        private double _record;
        private double _jump1;
        private double _jump2;
        private double _jump3;
        
        public Jumper(string id){
            this._id = id;
            this._record = 0;
            this._jump1 = 0;
            this._jump2 = 0;
            this._jump3 = 0;
        }

        public string GetId(){
            return this._id;
        }
        
        public double GetRecord(){
            return this._record;
        }

        public double GetJump1(){
            return this._jump1;
        }

        public double GetJump2(){
            return this._jump2;
        }

        public double GetJump3(){
            return this._jump3;
        }

        public void SetId(string id){
            this._id = id;
        }

        public void SetRecord(double record){
            this._record = record;
        }

        public void SetJump1(double val){
            this._jump1 = val;
        }

        public void SetJump2(double val){
            this._jump2 = val;
        }

        public void SetJump3(double val){
            this._jump3 = val;
        }

        public override string ToString(){
            return $"Jumper(Id: {this._id}, Record: {this._record}, Jump1: {this._jump1}, Jump2: {this._jump2}, Jump3: {this._jump3})";
        }

        public double Avg(){
            return (this._jump1 + this._jump2 + this._jump3) / 3;
        }

        public bool EqualToLast(){
            return this._record == this._jump1 || this._record == this._jump2 || this._record == this._jump3;
        }
    }
}