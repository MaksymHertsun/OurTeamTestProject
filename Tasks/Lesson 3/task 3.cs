using System.Collections.Generic;
class ListProgram
{
    public static List<int> ListWithPositive (List<int> elements){
        Predicate<int> del = delegate (int a) {
            if (a>0 && a<=10) return true;
            else return false;
        };
        return elements.FindAll(del);
    }
     
}