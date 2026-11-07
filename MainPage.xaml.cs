
namespace WidgetDemoApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void OnProfileButtonClicked(
        object sender, EventArgs e)
    {
        await DisplayAlert(
            "Profile",
            "Welcome to Afreen's Dashboard!",
            "OK");
    }
}
