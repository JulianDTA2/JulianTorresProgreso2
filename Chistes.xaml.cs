using System.Net.Http.Json;

namespace JulianTorresProgreso2;

public partial class Chistes : ContentPage
{
    public Chistes()
    {
        InitializeComponent();
        LoadJoke();
    }

    private async void LoadJoke()
    {
        try
        {
            var httpClient = new HttpClient();
            var joke = await httpClient.GetFromJsonAsync<Joke>("https://official-joke-api.appspot.com/random_joke");
            JokeLabel.Text = $"{joke.Setup}\n{joke.Punchline}";
        }
        catch
        {
            JokeLabel.Text = "Error al obtener el chiste.";
        }
    }

    private void DarOtroChiste_Clicked(object sender, EventArgs e)
    {
        LoadJoke();
    }
}

public class Joke
{
    public string Setup { get; set; }
    public string Punchline { get; set; }

}