using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Calc" in code, svc and config file together.
public class Calc : ICalc
{
    public double AddNumbers(double number1, double number2)
    {
        return 10.0;
    }

    public double DivisionNumbers(double number1, double number2)
    {
        return 10.1;
    }

    public double MultiplyNumbers(double number1, double number2)
    {
        return 10.2;
    }

    public double SubstractNumbers(double number1, double number2)
    {
        return 10.2;
    }
}
