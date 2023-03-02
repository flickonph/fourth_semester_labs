using System.Drawing.Printing;
using System.IO;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using program_tech_labs.Models;

namespace program_tech_labs.Views.Pages;

public partial class Lab1Page
{
    public Lab1Page()
    {
        InitializeComponent();
        Update();
        BaseTypesOperations();
    }

    private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
    {
        PrintDocument printDocument = new PrintDocument();
        printDocument.Print();
    }

    private void BaseTypesOperations()
    {
        var model = new Lab1Model(string.Empty);
        Lab1Model.LabOpt i = Lab1Model.LabOpt.Third;
        BaseTypeTextBlock.Text = model.LabStr + model.LabDouble + " " + model.LabDec[0] + " " + i;
    }

    private void Update()
    {
        Lorem.Text = File.ReadAllText("Assets/text.txt");
    }

    private void TestButton_OnMouseEnter(object sender, MouseEventArgs e)
    {
        TestButton.Content = "mouse here";
    }

    private void TestButton_OnClick(object sender, RoutedEventArgs e)
    {
        TestButton.Background = new SolidColorBrush(Colors.Red);
    }
}
