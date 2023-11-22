using CommunityToolkit.Maui.Core.Platform;
using System.Diagnostics;

namespace WorkoutApp.XAML;

public partial class MeasurementsPage : ContentPage
{
	public MeasurementsPage()
	{
		InitializeComponent();
		MeasurementPicker.SelectedIndex= 0;
	}

	void ChangeUnits_Event(object sender, EventArgs e)
	{
		ChangeTextUnits(MeasurementPicker.SelectedIndex);
	}

	void ChangeTextUnits(int i)
	{
		string weight;
		string height;
		if(i==0)
		{
			weight="kg";
			height="cm";
		}
		else
		{
            weight="lbs";
            height="in";
        }
		WeightUnits.Text = weight;
		BicepsUnits.Text = height;
        ChestUnits.Text = height;
        WaistUnits.Text = height;
        HipsUnits.Text = height;
        ThighsUnits.Text = height;
        CalvesUnits.Text = height;
        NeckUnits.Text = height;
        ForearmsUnits.Text = height;
	}

    void SaveMeasurements_Event(object sender, EventArgs e)
    {
        if(MeasurementEntry.Text == null || MeasurementEntry.Text.Length < 1)
        {
            ErrorText.Text = "Weight is required";
            return;
        }
        else
        {
            ErrorText.Text = "";
            //Save Measurements
        }
    }

    void GoBack_Event(object sender, EventArgs e)
    {
        //Navigation.PopModalAsync();
    }

    /// <summary>
    /// Validate Input for Measurement Entry
    /// </summary>
    private void MeasurementEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
		if(e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 5)
            MeasurementEntry.Text = e.NewTextValue.Remove(0, 1);
		if(e.NewTextValue.Length == 5)
			MeasurementEntry.HideKeyboardAsync(CancellationToken.None);
    }
	void BicesEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
            BicepsEntry.Text = e.NewTextValue.Remove(0, 1);
        if (e.NewTextValue.Length == 4)
            BicepsEntry.HideKeyboardAsync(CancellationToken.None);
    }

	void ChestEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
            ChestEntry.Text = e.NewTextValue.Remove(0, 1);
        if (e.NewTextValue.Length == 4)
            ChestEntry.HideKeyboardAsync(CancellationToken.None);
    }

	void WaistEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
            WaistEntry.Text = e.NewTextValue.Remove(0, 1);
        if (e.NewTextValue.Length == 4)
            WaistEntry.HideKeyboardAsync(CancellationToken.None);
    }

	void HipsEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
            HipsEntry.Text = e.NewTextValue.Remove(0, 1);
        if (e.NewTextValue.Length == 4)
            HipsEntry.HideKeyboardAsync(CancellationToken.None);
    }

	void ThighsEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
            ThighsEntry.Text = e.NewTextValue.Remove(0, 1);
        if (e.NewTextValue.Length == 4)
            ThighsEntry.HideKeyboardAsync(CancellationToken.None);
    }

	void CalvesEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
            CalvesEntry.Text = e.NewTextValue.Remove(0, 1);
        if (e.NewTextValue.Length == 4)
            CalvesEntry.HideKeyboardAsync(CancellationToken.None);
    }

	void NeckEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
            NeckEntry.Text = e.NewTextValue.Remove(0, 1);
        if (e.NewTextValue.Length == 4)
            NeckEntry.HideKeyboardAsync(CancellationToken.None);
    }

	void ForearmsEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
            ForearmsEntry.Text = e.NewTextValue.Remove(0, 1);
        if (e.NewTextValue.Length == 4)
            ForearmsEntry.HideKeyboardAsync(CancellationToken.None);
    }

}