using Wisej.Hybrid;
using Wisej.Web;

namespace WisejHybridLocalApplication1
{
	public partial class Page1 : Page
	{
		public Page1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, System.EventArgs e)
		{
			if (Device.Valid)
			{

				var sysinfo = Device.Info.System.Platform;
				if (sysinfo == Wisej.Hybrid.Modules.System.DevicePlatform.MacCatalyst || sysinfo == Wisej.Hybrid.Modules.System.DevicePlatform.macOS)
				{
					Device.Popups.DisplayAlert("Welcome", "Hello from MacOS");
				}
				else
				{
					if (sysinfo == Wisej.Hybrid.Modules.System.DevicePlatform.WinUI)
					{
						Device.Popups.DisplayAlert("Welcome", "Hello from Windows");
					}
					//could add checks here for Android, iOs...
					else
					{
						Device.Popups.DisplayAlert("Welcome", "Hello from Wisej Hybrid");
					}
				}

			}
			//if the device is not valid- we are running in a web browser, not on a native device
			else
			{
				AlertBox.Show("Running from web browser");
			}


		}
	}
}
