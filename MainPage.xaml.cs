namespace WidgetDemoMaui;

public partial class MainPage : ContentPage
{
    private int _likeCount = 0;

    public List<string> Skills { get; } = new()
    {
        "C#", ".NET MAUI", ".NET", "Git", "XAML", "SQL", "Android"
    };

    public MainPage()
    {
        InitializeComponent();
        BindingContext = this;
    }

    private void OnLikeClicked(object sender, EventArgs e)
    {
        _likeCount++;
        LikeButton.Text = $"Like ({_likeCount})";
    }

    private async void OnMessageClicked(object sender, EventArgs e)
    {
        Spinner.IsVisible = true;
        Spinner.IsRunning = true;
        await Task.Delay(800);
        Spinner.IsRunning = false;
        Spinner.IsVisible = false;

        string comment = string.IsNullOrWhiteSpace(CommentEntry.Text)
            ? "(no comment entered)" : CommentEntry.Text;

        await DisplayAlertAsync("Message Sent", $"Your message: {comment}", "OK");
        CommentEntry.Text = string.Empty;
    }

    private void OnAvailableToggled(object sender, ToggledEventArgs e)
    {
        StatusLabel.Text = e.Value ? "Status: Available" : "Status: Not available";
        StatusLabel.TextColor = e.Value ? Color.FromArgb("#2E7D32") : Color.FromArgb("#C62828");
    }
}
