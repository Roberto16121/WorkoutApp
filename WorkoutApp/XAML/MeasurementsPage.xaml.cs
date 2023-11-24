using CommunityToolkit.Maui.Core.Platform;
using System.Diagnostics;
using WorkoutApp.Scripts;

namespace WorkoutApp.XAML;

public partial class MeasurementsPage : ContentPage
{
    WeightEntry entry = new();
	public MeasurementsPage()
	{
		InitializeComponent();
        App app = (App)App.Current;
        Load load = app.load;
        if (load.DoesFileExist("Measurements.json"))
        {
            WeightEntry entry = load.LoadMeasurements()[0];
            if(entry.Units == 0)
                MeasurementPicker.SelectedIndex = 0;
            else
                MeasurementPicker.SelectedIndex = 1;
        }
        else MeasurementPicker.SelectedIndex = 0;
        entry.Date = DateTime.Now;
	}

	void ChangeUnits_Event(object sender, EventArgs e)
	{
		ChangeTextUnits(MeasurementPicker.SelectedIndex);
        entry.Units = MeasurementPicker.SelectedIndex;
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
            App app = (App)App.Current;
            Save save = app.save;
            save.SaveMeasurements(entry);
            AppShell shell = (AppShell)App.Current.MainPage;
            shell.ClosePage();
        }
    }



    /// <summary>
    /// Validate Input for Measurement Entry
    /// </summary>
    private void MeasurementEntry_TextChanged(object sender, TextChangedEventArgs e)
    {
        if(e.NewTextValue == null || e.NewTextValue.Length <= 1)
            return;

        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 5)
        {
            MeasurementEntry.Text = "0";
            entry.Weight = 0;
            return;
        }
		if(e.NewTextValue.Length == 5)
            _ = MeasurementEntry.HideKeyboardAsync(CancellationToken.None);

        entry.Weight = double.Parse(MeasurementEntry.Text);
    }
	void BicesEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue == null || e.NewTextValue.Length <= 1)
            return;
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
        {
            BicepsEntry.Text = "0";
            entry.Biceps = 0;
            return;
        }
        if (e.NewTextValue.Length == 4)
            BicepsEntry.HideKeyboardAsync(CancellationToken.None);

        entry.Biceps = double.Parse(BicepsEntry.Text);
    }

	void ChestEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue == null || e.NewTextValue.Length <= 1)
            return;
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
        {
            ChestEntry.Text = "0";
            entry.Chest = 0;
            return;
        }
        if (e.NewTextValue.Length == 4)
            ChestEntry.HideKeyboardAsync(CancellationToken.None);

        entry.Chest = double.Parse(ChestEntry.Text);
    }

	void WaistEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue == null || e.NewTextValue.Length <= 1)
            return;
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
        {
            WaistEntry.Text = "0";
            entry.Waist = 0;
            return;
        }
        if (e.NewTextValue.Length == 4)
            WaistEntry.HideKeyboardAsync(CancellationToken.None);

        entry.Waist = double.Parse(WaistEntry.Text);
    }

	void HipsEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue == null || e.NewTextValue.Length <= 1)
            return;
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
        {
            HipsEntry.Text = "0";
            entry.Hips = 0;
            return;
        }
        if (e.NewTextValue.Length == 4)
            HipsEntry.HideKeyboardAsync(CancellationToken.None);

        entry.Hips = double.Parse(HipsEntry.Text);
    }

	void ThighsEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue == null || e.NewTextValue.Length <= 1)
            return;
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
        {
            ThighsEntry.Text = "0";
            entry.Thighs = 0;
            return;
        }
        if (e.NewTextValue.Length == 4)
            ThighsEntry.HideKeyboardAsync(CancellationToken.None);

        entry.Thighs = double.Parse(ThighsEntry.Text);
    }

	void CalvesEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue == null || e.NewTextValue.Length <= 1)
            return;
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
        {
            CalvesEntry.Text = "0";
            entry.Calves = 0;
            return;
        }
        if (e.NewTextValue.Length == 4)
            CalvesEntry.HideKeyboardAsync(CancellationToken.None);

        entry.Calves = double.Parse(CalvesEntry.Text);
    }

	void NeckEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue == null || e.NewTextValue.Length <= 1)
            return;
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
        {
            NeckEntry.Text = "0";
            entry.Neck = 0;
            return;
        }
        if (e.NewTextValue.Length == 4)
            NeckEntry.HideKeyboardAsync(CancellationToken.None);

        entry.Neck = double.Parse(NeckEntry.Text);
    }

	void ForearmsEntry_TextChanged(object sender, TextChangedEventArgs e)
	{
        if (e.NewTextValue == null || e.NewTextValue.Length <= 1)
            return;
        if (e.NewTextValue.StartsWith("0") && e.NewTextValue.Length <= 4)
        {
            ForearmsEntry.Text = "0";
            entry.Forearms = 0;
            return;
        }
        if (e.NewTextValue.Length == 4)
            ForearmsEntry.HideKeyboardAsync(CancellationToken.None);

        entry.Forearms = double.Parse(ForearmsEntry.Text);
    }

}