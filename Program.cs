namespace Assignment2{
    public class Assignment2{
        public static void Main(string[] args){
            Console.WriteLine(Sum(10,2));
            Swap(172,999);
        }


        public static int Sum(int  a, int b){
            return a+b;
        }

        public static void Swap(int  a, int b){
            b = a+b;
            a = b-a;
            b -= a;
            Console.WriteLine("After swap a = {0} and b = {1}",a,b);

        }
    }
}
