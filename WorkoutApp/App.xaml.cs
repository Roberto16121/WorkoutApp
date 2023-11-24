using WorkoutApp.Scripts;
using WorkoutApp.XAML;

namespace WorkoutApp;

public partial class App : Application
{
    public Save save { get; } = new();
    public Load load { get; } = new();

    public App()
    {
        InitializeComponent();
        App.Current.MainPage = new WeightChartPage();  
    }

    
}