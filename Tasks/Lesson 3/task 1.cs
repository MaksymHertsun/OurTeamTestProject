using System;

class CalcProgram{
    public delegate int CalcDelegate (int a, int b, char operation);

    CalcDelegate CalcDelegate = Calc;
    
    public static int Calc (int a, int b, char operation){
        if(operation == '+') return a + b;
        else if(operation == '-') return a - b;
        else if(operation == '*') return a * b;
        else if(operation == '/') {
            if (b == 0) return 0;
            else return a / b;
        }
        else return 0;
    }

    public CalcDelegate funcCalc = Calc;
}