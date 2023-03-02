using System;
using System.Collections.Generic;
using System.Windows.Media;
using program_tech_labs.Models;
using Wpf.Ui.Controls;

namespace program_tech_labs.Views.Pages;

public partial class Lab3Page
{
    public Lab3Page()
    {
        InitializeComponent(); 
        Lab3ResInit();
    }

    private void Lab3ResInit()
    {
        var results = Lab3Model.FuncMain();
        List<string> errors = new List<string>();
        int counter = 0;
        foreach (var res in results)
        {
            Card card = new Card
            {
                Content = $"#{counter}: x = {res.X:0.0000}, y = {res.Y:0.0000}"
            };
            if (res.IsNormal == false)
            {
                card.Background = new SolidColorBrush(Colors.Red);
                errors.Add($"Result #{counter} is abnormal");
            }
            ResBox.Items.Add(card);
            counter++;
        }

        Exception e = new Exception("No user unhandled exceptions occured.");
        var uiMessageBox = new MessageBox();
        if (errors.Count > 0)
        {
            string errorMsg = string.Empty;
            foreach (var t in errors)
            {
                errorMsg += $"{t}\n";
            }

            uiMessageBox.Content = errorMsg;
        }
        else
        {
            uiMessageBox.Content = e.Message;
        }
        uiMessageBox.ShowFooter = false;
        uiMessageBox.Show();
    }
}