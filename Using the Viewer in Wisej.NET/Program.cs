using System;
using Wisej.Web;

namespace Using_the_Viewer_in_Wisej_NET
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		static void Main()
		{
			Application.Desktop = new MyDesktop();

			Window1 window = new Window1();
			window.Show();
		}
	}
}