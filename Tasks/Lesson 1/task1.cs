class MyAccessModifiers
{
    private int birthYear;
    protected string personalInfo;
    private protected string IdNumber;

    public MyAccessModifiers(int birth_Year, string Id_Number, string personal_Info)
    {
        birthYear = birth_Year;
        IdNumber = Id_Number;
        personalInfo = personal_Info;
    }

    public int Age
    {
        get { return (2022 - birthYear); }
    }
    static byte averageMiddleAge = 50;
    internal string Name
    {
        get;
        set;
    }
    public string NickName
    {
        get;
        internal set;
    }
    protected internal void HasLivedHalfOfLife()
    {

    }
    public static bool operator == (MyAccessModifiers a, MyAccessModifiers b)
    {
        return a.Name == b.Name && a.Age == b.Age && a.personalInfo == b.personalInfo;
    }
    public static bool operator != (MyAccessModifiers a, MyAccessModifiers b)
    {
        return a.Name != b.Name || a.Age != b.Age || a.personalInfo != b.personalInfo;
    }
    public override bool Equals(object? obj)
    {
    
        if (obj is MyAccessModifiers MyAccessModifiers) return true;
            
        else return false;
    }
    
    public override int GetHashCode() => Name.GetHashCode();
}
