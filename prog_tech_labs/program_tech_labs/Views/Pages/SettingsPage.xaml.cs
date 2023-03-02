using System.Windows;
using Wpf.Ui.Appearance;

namespace program_tech_labs.Views.Pages;

public partial class SettingsPage
{
    public SettingsPage()
    {
        InitializeComponent();

        if (Theme.GetAppTheme() == ThemeType.Dark)
            DarkThemeRadioButton.IsChecked = true;
        else
            LightThemeRadioButton.IsChecked = true;
    }

    private void OnLightThemeRadioButtonChecked(object sender, RoutedEventArgs e)
    {
        Theme.Apply(ThemeType.Light);
    }

    private void OnDarkThemeRadioButtonChecked(object sender, RoutedEventArgs e)
    {
        Theme.Apply(ThemeType.Dark);
    }
}
