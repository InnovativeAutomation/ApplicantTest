namespace ApplicantTest.Client.Pages;
public partial class Weather
{
    private WeatherForecast[]? mForecasts;

    protected override async Task OnInitializedAsync()
    {
        // Set the seed for random
        var random = new Random(1234);

        // Simulate asynchronous loading to demonstrate a loading indicator
        await Task.Delay(500);

        // Get start date
        var startDate = DateOnly.FromDateTime(DateTime.Now);

        // Get summaries
        var summaries = new[] { "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching" };
        mForecasts = Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = startDate.AddDays(index),
            TemperatureC = random.Next(-20, 55),
            Summary = summaries[random.Next(summaries.Length)]
        }).ToArray();
    }
}