using System;
using System.IO;
using System.Reflection;
using program_tech_labs.Views.Pages;
using Wpf.Ui.Appearance;

namespace program_tech_labs;

public partial class MainWindow
{
    public MainWindow()
    {
        DataContext = this;

        Watcher.Watch(this);

        InitializeComponent();

        Loaded += (_, _) => RootNavigation.Navigate(typeof(Lab1Page));
        Version();
    }

    private void Version()
    {
        DateTime buildDate = 
            new FileInfo(Assembly.GetExecutingAssembly().Location).LastWriteTime;
        Bar.Title += 
            " " + Assembly.GetExecutingAssembly().GetName().Version + " " + buildDate;
    }
}
