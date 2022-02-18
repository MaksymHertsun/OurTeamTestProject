class Employee{
    internal string name;
    private DateTime hiringDate;
    public Employee (string Name, DateTime HiringDate){
        name = Name;
        hiringDate = HiringDate;
    }
    public int Experience(){
        DateTime now = DateTime.Now;
        if ((hiringDate.Month < now.Month) || (hiringDate.Month == now.Month && hiringDate.Day < now.Day)) return now.Year - hiringDate.Year;
        else return now.Year - hiringDate.Year - 1;
    }
    public virtual void ShowInfo(){
        Console.WriteLine($"{name} has {Experience()} years of experience");
    }
}
class Developer : Employee{
    private string programmingLanguage;
    public Developer(string Name, DateTime HiringDate, string ProgrammingLanguage):base(Name, HiringDate){
        programmingLanguage = ProgrammingLanguage;
    }
    public override void ShowInfo(){
        base.ShowInfo();
        Console.WriteLine($"{name} is {programmingLanguage} programmer");
    }
}
class Tester : Employee{
    private bool isAuthomation;
    public Tester(string Name, DateTime HiringDate, bool IsAuthomation):base(Name,HiringDate){
        isAuthomation = IsAuthomation;
    }
    public override void ShowInfo(){
        if (isAuthomation) Console.WriteLine($"{name} is authomated tester and has {Experience()} year(s) of experience");
        else Console.WriteLine($"{name} is manual tester and has {Experience()} year(s) of experience");
    }
}