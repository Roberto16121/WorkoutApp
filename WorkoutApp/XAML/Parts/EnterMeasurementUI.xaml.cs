namespace WorkoutApp.XAML.Parts;

public partial class EnterMeasurementUI : ContentView
{
	public EnterMeasurementUI()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		App app = (App)Application.Current;
		app.OpenPage(new MeasurementsPage());
    }
}