class Program
{
    public static void Main(string[] args){
        Random random = new Random();
        for(int i = 0; i < 20; i++){
            int firstNum = random.Next(1, 101);
            int secondNum = random.Next(1, 101);
            Console.WriteLine($"\n({firstNum}, {secondNum})");
            
            if(firstNum <= secondNum){
                for(int j = firstNum; j <= secondNum; j++){
                    Console.Write(j + ", ");
                }
            }else if(firstNum >= secondNum){
                for(int j = secondNum; j <= firstNum; j++){
                    Console.Write(j + ", ");
                }
            }


        }
    }
}