
namespace WidgetDemoApp;

public partial class MainPage : ContentPage
{
    int likeCount = 0;

    public MainPage()
    {
        InitializeComponent();

        SkillsCollection.ItemsSource = new List<string>
        {
            "C#",
            "Xamarin",
            ".NET",
            "Git",
            "Python",
            "Machine Learning"
        };
    }

    private void OnLikeClicked(object sender, EventArgs e)
    {
        likeCount++;

        LikeButton.Text = $"Like ({likeCount})";
    }

    private async void OnMessageClicked(object sender, EventArgs e)
    {
        await DisplayAlert(
            "Message",
            "Message button clicked!",
            "OK");
    }

    private async void OnPostCommentClicked(object sender, EventArgs e)
    {
        string comment = CommentEntry.Text;

        if (!string.IsNullOrWhiteSpace(comment))
        {
            await DisplayAlert(
                "Comment Posted",
                comment,
                "OK");

            CommentEntry.Text = "";
        }
        else
        {
            await DisplayAlert(
                "Error",
                "Please enter a comment.",
                "OK");
        }
    }

    private void OnAvailabilityToggled(object sender, ToggledEventArgs e)
    {
        if (e.Value)
        {
            AvailabilityLabel.Text = "Status: Available";
            AvailabilityLabel.TextColor = Colors.Green;
        }
        else
        {
            AvailabilityLabel.Text = "Status: Unavailable";
            AvailabilityLabel.TextColor = Colors.Red;
        }
    }
}
