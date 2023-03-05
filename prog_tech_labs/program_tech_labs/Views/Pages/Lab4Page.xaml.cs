using System.Collections.Generic;
using System.Linq;
using program_tech_labs.Models;
using Wpf.Ui.Controls;

namespace program_tech_labs.Views.Pages;

public partial class Lab4Page
{
    private readonly List<UrlInfo> _domains;
    public Lab4Page()
    {
        InitializeComponent();
        _domains = Lab4Model.GetDomainsInfo();
        Lab4Main();
    }

    private void Lab4Main()
    {
        foreach (var card in _domains.Select(domain => new Card
                 {
                     Content = domain
                 }))
        {
            DomainsListBox.Items.Add(card);
        }
    }
}