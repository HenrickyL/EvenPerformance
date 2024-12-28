public static class EvenTest{
    public static bool IsEven(uint x){
        return (x % 2) ==0;
    }
    public static bool IsEven2(uint x){
        return (x & 1) == 0;
    }
    public static double Test(List<uint> tests, Func<uint,bool> isEven){
        double sum = 0;
        foreach(uint test in tests){
            DateTime start = DateTime.Now;
                isEven(test);
            DateTime end = DateTime.Now;
            double time = (end - start).TotalNanoseconds;
            sum += time;
        }
        return sum / tests.Count;
    }
}