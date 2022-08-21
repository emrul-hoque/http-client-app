
// var client = new HttpClient();
HttpClient client = new();
// client.BaseAddress = new Uri("http://localhost:5000/");

HttpResponseMessage response = await client.GetAsync("https://www.google.com");

try
{
    if (response.IsSuccessStatusCode)
    {
        string result = await response.Content.ReadAsStringAsync();
        Console.WriteLine(result);
    }
    else
    {
        Console.WriteLine("{0} ({1})", (int)response.StatusCode, response.ReasonPhrase);
    }
}
catch (HttpRequestException e)
{
    Console.WriteLine("Message :{0} ", e.Message);

}catch(Exception e)
{ 
    Console.WriteLine("Message :{0} ", e.Message);
}finally{

    Console.WriteLine("Finally - Done.");
}

