using WorkoutApp.XAML;

namespace WorkoutApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        App.Current.MainPage = new MeasurementsPage();
        //MainPage = new AppShell();
    }
}