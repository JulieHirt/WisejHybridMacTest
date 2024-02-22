using Foundation;
using Wisej.Hybrid.Native;

namespace HybridApp1
{
	[Register("AppDelegate")]
	public class AppDelegate : HybridUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => Startup.Main();
	}
}