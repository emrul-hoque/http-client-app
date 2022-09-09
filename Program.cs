using Demo.App;
using System.Text.Json;


/*
**********************************************************************************************
* Weather API
* http://api.weatherstack.com/current?access_key=fe65220b9529a3245053e8d3f2356e63&query=dhaka    
**********************************************************************************************
* USER API:
* https://jsonplaceholder.typicode.com/users
*/

//var client = new HttpClient();
HttpClient client = new();

client.BaseAddress = new Uri("http://api.weatherstack.com/");

string API_KEY = "";

HttpResponseMessage response = await client.GetAsync($"/current?access_key={API_KEY}&query=dhaka");

// TODO: We want to read this API: https://jsonplaceholder.typicode.com/users

try
{
    if (response.IsSuccessStatusCode)
    {
          string result = await response.Content.ReadAsStringAsync();
        //Console.WriteLine(result);
        // File.WriteAllText( Path.Combine("./MyFolder", "MyWebPage.txt"), result);        
        MyUtil.OutputWeatherReponse(result);
    }
    else
    {
        Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
    }
}
catch (HttpRequestException e)
{
    Console.WriteLine("Message :{0} ", e.Message);

}
catch (Exception e)
{
    Console.WriteLine("Message :{0} ", e.Message);
}
finally
{

    Console.WriteLine("Finally - Done.");
}

