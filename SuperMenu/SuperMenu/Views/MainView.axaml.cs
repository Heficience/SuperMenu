using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace SuperMenu.Views;

public class MainView : UserControl
{
    public MainView()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
    
    public void monBouton_Click(object sender, RoutedEventArgs e)
    {
        // Change button text when button is clicked.
        var monBouton = (Button)sender;
        bienvenueOrNot = !bienvenueOrNot;
        if (bienvenueOrNot)
        {
            monBouton.Content = "Bienvenu, Chez Heficience !";
        }
        else
        {
            monBouton.Content = "Cliquez Ici !";
        }
            
    }
    public bool bienvenueOrNot { get; set; }
}