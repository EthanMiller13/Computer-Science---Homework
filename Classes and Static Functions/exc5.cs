namespace Exc5{
    class Program{
        public static void Main(string[] args){
            long number = 52329742182255;
            int digit = 5;
            Console.WriteLine($"Number: {number}, Digit: {digit}" + "\n" + digCount(number, digit));
        }
        public static int digCount(long num, int digit){
            int count = 0;
            while(num > 0){
                if(num % 10 == digit){
                    count++;
                }
                num /= 10;
            }
            return count;
        }
    }
}