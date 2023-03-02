using System;

namespace program_tech_labs.Models;

public class Lab1Model
{
    private string _labStr = "BaseString";
    private const double _labDouble = 2.0;
    private decimal[] _labDec = { 1, 2, 3 };

    public Lab1Model(string s)
    {
        LabStr = s == string.Empty ? _labStr : s;
        LabDouble = _labDouble;
        LabDec = _labDec;
    }

    public string LabStr { get; set; }
    public double LabDouble { get; }
    public decimal[] LabDec { get; set; }
    
    public enum LabOpt : int
    {
        First = 1,
        Second = 2,
        Third = 3,
    } // Can't inherit double
}