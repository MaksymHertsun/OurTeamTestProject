abstract class Car{
    internal string mark;
    internal int prodYear;
    public virtual void ShowInfo(){
        Console.WriteLine($"Mark : {mark},\nProducted in {prodYear}");
    }
}
class SportCar : Car{
    private int maxSpeed;
    public SportCar(string Mark, int ProdYear, int MaxSpeed){
        mark = Mark;
        prodYear = ProdYear;
        maxSpeed = MaxSpeed;
    }
    public override void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"Maximum speed is {maxSpeed}");
    }
}
class Lory : Car{
    private double loadCapacity;
    public Lory(string Mark, int ProdYear, double LoadCapacity){
        mark = Mark;
        prodYear = ProdYear;
        loadCapacity = LoadCapacity;
    }
    public override void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"The load capacity is {loadCapacity}");
    }
}