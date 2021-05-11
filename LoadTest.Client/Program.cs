using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

var threads = 4;
var iterationCount = 1 << 14;
var httpClient = new HttpClient();

await Task.WhenAll(Enumerable.Range(0, threads).Select(async _ =>
{
    var password = 0;

    while (true)
    {
        Console.WriteLine(await httpClient.GetStringAsync($"https://p-e-onl-loadtest.azurewebsites.net/encode?iterationCount={iterationCount}&password={password++}"));
    }
}));

