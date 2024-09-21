using System;

class MainClass{
    public static void Main(string[] args){
        Variable var = new Variable();
        var.DisplayVariable();
    
    }
}

class Variable(){
    private bool booleanVariable = true;
    private int intVariable = 10;
    private float floatVariable = 3.4f;
    private char charVariable = 'a';

    public void DisplayVariable(){
        Console.WriteLine(booleanVariable);
        Console.WriteLine(intVariable);
        Console.WriteLine(floatVariable);
        Console.WriteLine(charVariable);
    }

}
