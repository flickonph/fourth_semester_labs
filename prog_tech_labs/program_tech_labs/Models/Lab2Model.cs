using System.Collections.Generic;

namespace program_tech_labs.Models;

public static class Lab2Model
{
    public static double Vci(double w, double tci, double pci)
    {
        return (0.2905 - 0.085 * w) * 82.04 * tci / pci;
    }
    
    public static List<Gas> Gases()
    {
        List<Gas> gases = new List<Gas>();
        gases.Add(new Gas(
            "CO", 
            93.1, 
            0.049, 
            132.9, 
            34.5, 
            0.1));
        gases.Add(new Gas(
            "CO2", 
            94.0,
            0.225,
            304.2,
            72.8,
            0.4));
        gases.Add(new Gas(
            "CH4", 
            99.0,
            0.008,
            190.6,
            45.4,
            0.5));
        return gases;
    }
}

public struct Gas
{
    public Gas(string name, double vci, double w, double tc, double pc, double y)
    {
        Name = name;
        Vci = vci;
        W = w;
        Tc = tc;
        Pc = pc;
        Y = y;
    }

    public override string ToString()
    {
        return $"Name: {Name}\n" +
               $"Vci: {Vci}, cm^3/mol\n" +
               $"W: {W}\n" +
               $"Tc: {Tc}, K\n" +
               $"Pc: {Pc}, atm\n" +
               $"Y: {Y} ({Y*100}%)";
    }

    public string Name { get; set; }
    
    public double Vci { get; set; }

    public double W { get; set; }

    public double Tc { get; set; }

    public double Pc { get; set; }
    
    public double Y { get; set; }
}