namespace TapCounterApp.Pages;

public partial class MainPage : ContentPage
{
    private int _count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnTapButtonClicked(object sender, EventArgs e)
    {
        _count++;
        CountLabel.Text = _count.ToString();

        if (_count == 1)
            StatusLabel.Text = "First tap!";
        else if (_count < 10)
            StatusLabel.Text = $"You've tapped {_count} times.";
        else
            StatusLabel.Text = "You've tapped 10 or more times!";
    }
}
