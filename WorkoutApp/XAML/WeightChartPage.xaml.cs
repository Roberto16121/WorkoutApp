using Microcharts;
using SkiaSharp;
namespace WorkoutApp.XAML;

public partial class WeightChartPage : ContentPage
{
    int offset = 20;
    ChartEntry[] entries = new[]
    {
        new ChartEntry(100.0f/20.0f)
        {
            Label = "January",
            ValueLabel = "100",
            Color = SKColor.Parse("#266489")
        },
        new ChartEntry(98.0f/20.0f)
		{
            Label = "February",
            ValueLabel = "98",
            Color = SKColor.Parse("#68B9C0")
        },
        new ChartEntry(96.0f/20.0f)
        {
            Label = "March",
            ValueLabel = "96",
            Color = SKColor.Parse("#90D585")
        }
    };
	public WeightChartPage()
	{
		InitializeComponent();
        chartView.Chart = new LineChart()
        {
            ValueLabelOption = ValueLabelOption.TopOfElement,
            Entries = entries,
            LineSize = 8,
            PointMode = PointMode.Circle,
            PointSize = 18,
            LabelOrientation = Orientation.Horizontal,
            ValueLabelOrientation = Orientation.Horizontal,
        };
        chartView.Chart.LabelTextSize = 32;
	}
}