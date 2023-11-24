
using System.Diagnostics;

namespace WorkoutApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
        this.Appearing += MainPage_Loaded;
    }

    private void MainPage_Loaded(object sender, EventArgs e)
    {
        App app = (App)App.Current;
        if(app.load.DoesFileExist("Measurements.json"))
        {
            WeightEntry entry = app.load.LoadMeasurements()[0];
            string unit = entry.Units == 0 ? "kg" : "lbs";
            WeightAndStepsUI.SetCurrentWeight(entry.Weight, unit);
            WeightAndStepsUI.SetCurrentDate(entry.Date);
        }
    }
}