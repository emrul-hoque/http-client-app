namespace Demo.App
{
    using System.Text.Json;

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
            Console.WriteLine(response);
            WeatherRoot weather = JsonSerializer.Deserialize<WeatherRoot>(response);
             Console.WriteLine(">>>   " + weather.current.temperature);
        }
    }
}