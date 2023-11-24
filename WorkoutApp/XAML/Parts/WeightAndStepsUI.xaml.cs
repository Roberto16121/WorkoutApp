namespace WorkoutApp.XAML.Parts;

public partial class WeightAndStepsUI : ContentView
{
	public WeightAndStepsUI()
	{
		InitializeComponent();
	}

	public void SetCurrentWeight(double weight, string Unit)
	{
        CurrentWeight.Text = weight.ToString() + $" {Unit}";
    }
	public void SetCurrentDate(DateTime date)
	{
        CurrentWeightDate.Text = date.ToString("dd/MM/yy");
    }
}