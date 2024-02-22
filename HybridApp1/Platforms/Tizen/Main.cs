using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace HybridApp1
{
	internal class Program : MauiApplication
	{
		protected override MauiApp CreateMauiApp() => Startup.Main();

		static void Main(string[] args)
		{
			var app = new Program();
			app.Run(args);
		}
	}
}