class Point{
    private int x, y;
    public Point(int X, int Y){
        x = X;
        y = Y;
        
    }
    internal int[] GetXYPair(){
        int[] a = new int[2];
        a[0] = x;
        a[1] = y;
        return a;
    }
    protected internal double Distance(int x2, int y2){
        return Math.Sqrt(Math.Pow((x2 - x), 2) + Math.Pow((y2 - y), 2));
    }
    protected internal double Distance(Point point){
        return Math.Sqrt(Math.Pow((point.x - x), 2) + Math.Pow((point.y - y), 2));
    }
    public static explicit operator double (Point point){
        return Math.Sqrt(Math.Pow((point.x - 0), 2) + Math.Pow((point.y - 0), 2));
    }
}