using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using testAvalonia.ViewModels;
using testAvalonia.Views;
using System;

namespace testAvalonia;

public partial class App : Application
{
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new MainWindowViewModel(),
                };
            }

            Console.WriteLine("Hello Torizon!");
            base.OnFrameworkInitializationCompleted();
        }
}
