namespace Exc3{
    class Program{
        public static void Main(string[] args){
            Console.Write("Eleven Graders: ");
            int elevenGraders = int.Parse(Console.ReadLine());
            Console.Write("Twelve Graders: ");
            int twelveGraders = int.Parse(Console.ReadLine());
            int busses;
            int studentSum = elevenGraders+twelveGraders;
            if(studentSum % 50 == 0){
                busses = studentSum/50;
            }else{
                busses = studentSum/50 + 1;
            }

            Console.WriteLine($"{busses} busses are needed for {studentSum} students.");
        }
    }
}