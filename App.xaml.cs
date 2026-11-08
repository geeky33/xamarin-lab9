namespace WidgetDemoMaui;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState activationState)
    {
        var nav = new NavigationPage(new MainPage())
        {
            BarBackgroundColor = Color.FromArgb("#2196F3"),
            BarTextColor = Colors.White
        };
        return new Window(nav);
    }
}
