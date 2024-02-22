using Foundation;

namespace HybridApp1
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => Startup.Main();
	}
}