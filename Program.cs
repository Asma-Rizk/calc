using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

static class Calc
{ 
public static int CalcNumber (this int first_num, int secund_num, string operation)
    {
        if (operation == "sum")
            return first_num + secund_num;
        else if (operation == "sub")
            return first_num - secund_num;
        else if (operation == "mul")
            return first_num * secund_num;
        else if (operation=="div")
            if (secund_num == 0)
            {
                Console.WriteLine("Error");
            }
        return first_num / secund_num;
    }

}
class calc
{
    static void Main()
    {
        int x = 10, y = 5;
        Console.WriteLine("Add: " + x.CalcNumber(y, "add"));
        Console.WriteLine("Sub: " + x.CalcNumber(y, "sub"));
        Console.WriteLine("Mul: " + x.CalcNumber(y, "mul"));
        Console.WriteLine("Div: " + x.CalcNumber(y, "div"));
    }
}