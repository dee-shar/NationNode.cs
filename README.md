# NationNode.cs
Web-API for [nationnode.vercel.app](https://nationnode.vercel.app/) access fast, reliable, and up-to-date country-specific data, from demographics to currencies, with seamless integration

## Example
```cs
using NationNodeApi;

namespace Application
{
    internal class Program
    {
        static async Task Main()
        {
            var api = new NationNode();
            string countryInfo = await api.GetCountry("Japan");
            Console.WriteLine(countryInfo);
        }
    }
}
```
