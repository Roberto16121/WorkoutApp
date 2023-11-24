using WorkoutApp.Scripts;
using WorkoutApp.XAML;

namespace WorkoutApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();
        Load load = new();
        if (!load.DoesFileExist("Measurements.json"))
            OpenPage(new MeasurementsPage());
    }

    public async void OpenPage(ContentPage page)
    {
        await this.Navigation.PushAsync(page);
    }

    public async void ClosePage()
    {
        if (this.Navigation.NavigationStack.Count > 1)
            await this.Navigation.PopAsync();
    }
}