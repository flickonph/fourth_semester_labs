using System;
using System.Collections.Generic;

namespace program_tech_labs.Models;

public static class Lab3Model
{
    private static double Func1(double x)
    {
        var localRes = double.NaN;
        try
        {
            localRes = Math.Atan(x);
            return localRes;
        }
        catch (Exception)
        {
            return localRes;
        }
    }

    private static double Func2(double x)
    {
        var localRes = double.NaN;
        try
        {
            localRes = Math.Exp(-0.1 * x);
            return localRes;
        }
        catch (Exception)
        {
            return localRes;
        }
    }

    private static double Func3(double x)
    {
        var localRes = double.NaN;
        try
        {
            localRes = Math.Log(Math.Atan(Math.Pow(-x, 2)), Math.Abs(x));
            return localRes;
        }
        catch (Exception)
        {
            return localRes;
        }
    }

    private static double Func4(double x)
    {
        var localRes = 0.0;
        for (var j = 1; j <= 1000000; j++)
        {
            try
            {
                localRes += 1 / (x + Math.Sqrt(j));
            }
            catch (Exception)
            {
                return double.NaN;
            }
        }

        return localRes;
    }

    public static List<Result> FuncMain()
    {
        var xiCollection = new List<double>();
        var results = new List<Result>();
        for (double i = -5; i <= 10; i += 2.5)
        {
            xiCollection.Add(i);
        }

        foreach (var xi in xiCollection)
        {
            bool flag = true;

            var localRes = Func1(xi) + Func2(xi) + Func3(xi) + Func4(xi);
            if (double.IsNaN(localRes) || double.IsInfinity(localRes) || double.IsNegativeInfinity(localRes))
            {
                flag = false;
            }
            results.Add(new Result(xi, localRes, flag));
        }

        return results;
    }
}

public struct Result
{
    public Result(double x, double y, bool isNormal)
    {
        X = x;
        Y = y;
        IsNormal = isNormal;
    }
    
    public double X { get; }
    public double Y { get; }
    public bool IsNormal { get; }
}