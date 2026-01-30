namespace TapCounterApp;

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

        // Update the big count label
        CountLabel.Text = _count.ToString();

        // Update status label
        if (_count == 1)
        {
            StatusLabel.Text = "First tap!";
        }
        else if (_count < 10)
        {
            StatusLabel.Text = $"You’ve tapped {_count} times.";
        }
        else
        {
            StatusLabel.Text = "You’ve tapped 10 or more times!";
        }
    }
}
