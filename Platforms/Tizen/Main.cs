using System;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace zadanie_19_01_2024_BETTER
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}
