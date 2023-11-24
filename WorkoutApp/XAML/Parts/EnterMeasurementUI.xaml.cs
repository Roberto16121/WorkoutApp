namespace WorkoutApp.XAML.Parts;

public partial class EnterMeasurementUI : ContentView
{
	public EnterMeasurementUI()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		AppShell shell = (AppShell)App.Current.MainPage;
		shell.OpenPage(new MeasurementsPage());
    }
}