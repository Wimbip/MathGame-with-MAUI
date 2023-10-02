namespace MathGame.Maui;

public partial class PreviousGamePage : ContentPage
{

    public PreviousGamePage()
    {
        InitializeComponent();
        gamesList.ItemsSource = App.GameRepository.GetAllGames();
    }
    private void OnDelete(object sender, EventArgs e)
    {
        Button button = (Button)sender;

        App.GameRepository.Delete((int)button.BindingContext);

        gamesList.ItemsSource = App.GameRepository.GetAllGames();
    }
}