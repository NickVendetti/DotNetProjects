// See https://aka.ms/new-console-template for more information
var apiCall = "https://www.google.com";

var client = new HttpClient();
var uri = new Uri(apiCall);

client.BaseAddress = uri;
var response = await client.GetAsync((string?)null);
string dataObjects = String.Empty;
if (response.IsSuccessStatusCode)
{
    // Parse the response body.
    dataObjects = await response.Content.ReadAsStringAsync();  
}

// all above works^^

// duplicate above process with new URL
var newCall = "https://www.github.com";

var newClient = new HttpClient();
var newUri = new Uri(newCall);

newClient.BaseAddress = newUri;
var newResponse = await newClient.GetAsync((string?)null);
string newDataObjects = String.Empty;
if (newResponse.IsSuccessStatusCode)
{
    // Parse the response body.
    newDataObjects = await newResponse.Content.ReadAsStringAsync();  
}
else
{
    newDataObjects = "error";
}
Console.WriteLine("Hello, World!");
Console.WriteLine(dataObjects);
Console.WriteLine(newDataObjects);