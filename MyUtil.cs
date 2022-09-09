namespace Demo.App
{
    using System.Text.Json;
    using Demo.App.Models.UserApi;
    using Demo.App.Models.WeatherApi;

    public static class MyUtil
    {
        public static void OutputUserResponse<T>(string response)
        {
            // Deserialization: Json -> Object
            // Serialization: Object -> Json
            var users = JsonSerializer.Deserialize<List<User>>(response);

            if (users != null)
            {
                foreach (var user in users)
                {
                    Console.WriteLine(">>> " + user.Name + " (" + user.Email + ")");
                    Console.WriteLine(">>> " + user.Address?.Street + ", " + user.Address?.City + "\n");
                }
            }
        }

        public static void OutputWeatherReponse(string response)
        {
            Console.WriteLine("\n" + response + "\n");

            WeatherRoot? weather = JsonSerializer.Deserialize<WeatherRoot>(response);

            if(weather is not null)
            {
                Console.WriteLine($">>> Location: {weather.Location?.Name}, Temperature: {weather.Current?.Temperature} with humidity {weather.Current?.Humidity} at {weather.Location?.LocalTime}");

                var weatherDescriptions = weather.Current?.WeatherDescriptions ?? new();

                foreach(var d in weatherDescriptions)
                {
                    Console.WriteLine($">>>>  {d}");
                }                
            }            
        }
    }
}