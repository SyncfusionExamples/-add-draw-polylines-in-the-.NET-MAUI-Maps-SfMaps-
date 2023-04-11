namespace MapPolylines;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new AppShell();

		Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MDAxQDMyMzEyZTMxMmUzMjM0RlRxZ0NURG8wT3NPRkNhbDQ1RE1aRERTWlVqTzFZOXZISGNUWnBDK2J4VT0=");
	}
}
