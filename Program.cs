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
        List<int> lengths = new (){
            1000,5000, 10000, 50000, 100000, 500000,
            1000000, 2000000, 5000000
        };

        foreach(int len in lengths){
            List<uint> tests = GetRandonList(len);

            double result1 = EvenTest.Test(tests, EvenTest.IsEven);
            double result2 = EvenTest.Test(tests, EvenTest.IsEven2);
            Console.WriteLine($"Result to {len} in nanoseconds");
            Console.WriteLine($"Test 1\t\tTest 2");
            Console.WriteLine($"{result1}\t\t{result2}");
            Console.WriteLine("-----------------------");
        }
    }
}