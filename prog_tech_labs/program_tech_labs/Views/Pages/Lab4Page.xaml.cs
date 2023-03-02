using System.Windows.Controls;
using program_tech_labs.Models;

namespace program_tech_labs.Views.Pages;

public partial class Lab4Page
{
    public Lab4Page()
    {
        InitializeComponent();
        Lab4Model.GetTopLevelDomains();
    }

    public static void Lab4Main()
    {
        
    }
}