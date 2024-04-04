namespace ProgramaNotes;

public partial class AboutPage : ContentPage
{
    public AboutPage()
    {
        InitializeComponent();
    }

    private void Confirm(object sender, EventArgs e)
    {
        var userName = nameEntry.Text;
        if (!string.IsNullOrWhiteSpace(userName))
        {
            welcomeLabel.Text = $"Seja bem vindo, {userName}!";
        }
    }
}