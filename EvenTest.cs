public static class EvenTest{
    public static bool IsEven(int x){
        return (x % 2) ==0;
    }
    public static bool IsEven2(int x){
        return (x & 1) == 0;
    }
    public static double Test(int x, Func<int,bool> isEven){
        DateTime start = DateTime.Now;
        isEven(x);
        DateTime end = DateTime.Now;
        return (end - start).TotalNanoseconds;
    }
}