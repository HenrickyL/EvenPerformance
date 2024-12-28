public class Program{

    private static List<uint> GetRandonList(int size){
        List<uint> list = new();
        Random random = new Random();
        for(int i = 0; i < size; i++){
            list.Add((uint)random.Next());
        }
        return list;
    }

    public static void Main(){
        List<uint> tests = GetRandonList(1000);


        double result1 = EvenTest.Test(tests, EvenTest.IsEven);
        double result2 = EvenTest.Test(tests, EvenTest.IsEven2);
        
        Console.WriteLine($"Result to {1000} in nanoseconds");
        Console.WriteLine($"Test 1\t\tTest 2");
        Console.WriteLine($"{result1}\t\t{result2}");
    }
}