public static class StringExtensions{
    public static int WordCount (this string s){
        return s.Split(new char[] {' ', '.', '?', '!', '-', ';', ':', ','}, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}