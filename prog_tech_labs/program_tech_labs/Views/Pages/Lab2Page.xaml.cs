using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using program_tech_labs.Models;
using Wpf.Ui.Controls;

namespace program_tech_labs.Views.Pages;

public partial class Lab2Page
{
    public Lab2Page()
    {
        InitializeComponent();
        InitListBox();
    }
    
    private void InitListBox()
    {
        var gases = Lab2Model.Gases();
        foreach (var gas in gases)
        {
            var card = new Card();
            card.Content = gas.ToString();
            card.Content += $"\nVci(calc): {Lab2Model.Vci(gas.W, gas.Tc, gas.Pc):0.00}";
            AllGases.Items.Add(card);
        }
    }

    private void ButtonCalculate_OnClick(object sender, RoutedEventArgs e)
    {
        var gases = Lab2Model.Gases();
        List<double> results = new List<double>();

        for (int i = 0; i < gases.Count; i++)
        {
            for (int j = 0; j < gases.Count; j++)
            {
                var vci = Math.Pow(gases[i].Vci, 1.0 / 3);
                var vcj = Math.Pow(gases[j].Vci, 1.0 / 3);
                results.Add(gases[i].Y*gases[j].Y*Math.Pow(vci + vcj, 3));
            }
        }
        
        var res = 1.0 / 8 * results.Sum();
        Res.Text = $"{res:0.00}";
    }
}
