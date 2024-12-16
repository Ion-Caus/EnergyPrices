using System.Net.Http.Json;
using System.Globalization;
using EnergyPrices.Models;

namespace EnergyPrices.Services;

// TODO: Call it NrgiClient
public class PriceService(HttpClient httpClient)
{
    private readonly HttpClient _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));

    public async Task<NrgiPrices?> GetPricesAsync(DateOnly date, string region)
    {
        var formattedDate = date.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        var proxyUrl = "https://cors-anywhere.herokuapp.com/";
        var url = $"https://nrgi.dk/api/common/pricehistory?region={region}&date={formattedDate}&includeGrid=true";
        var proxiedUrl = proxyUrl + url;

        return await _httpClient.GetFromJsonAsync<NrgiPrices>(proxiedUrl);
    }
}