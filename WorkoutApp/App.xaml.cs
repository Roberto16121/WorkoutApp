using WorkoutApp.XAML;
using WorkoutApp.Scripts;
using System.Diagnostics;
namespace WorkoutApp;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
        App.Current.MainPage = new NavigationPage(new AppShell());
        Load load = new();
        if(!load.DoesFileExist("Measurements.json"))
        {
            OpenPage(new MeasurementsPage());
        }
        
    }

    public async void OpenPage(Page page)
    {
        await App.Current.MainPage.Navigation.PushAsync(page);
    }

    public async void ClosePage()
    {
        if(MainPage.Navigation.NavigationStack.Count > 1)
            await App.Current.MainPage.Navigation.PopAsync();
    }
}