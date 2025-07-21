namespace ToastTest2;
using CommunityToolkit.Maui.Alerts;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private async void OnCounterClicked(object? sender, EventArgs e)
	{

		CancellationTokenSource cancellationTokenSource = new();
		await Toast.Make($"Toast").Show(cancellationTokenSource.Token);
		/* count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text); */
	}
}
