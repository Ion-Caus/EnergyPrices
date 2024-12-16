using System.Text.Json.Serialization;

namespace EnergyPrices.Models;

public class NrgiPrices
{
    [JsonPropertyName("prices")]
    public List<Price> Prices { get; set; }

    [JsonPropertyName("priceType")]
    public string PriceType { get; set; }

    [JsonPropertyName("region")]
    public string Region { get; set; }

    [JsonPropertyName("date")]
    public DateOnly Date { get; set; }

    [JsonPropertyName("currentPrice")]
    public int CurrentPrice { get; set; }

    [JsonPropertyName("averagePrice")]
    public int AveragePrice { get; set; }

    [JsonPropertyName("lowestPrice")]
    public int LowestPrice { get; set; }

    [JsonPropertyName("highestPrice")]
    public int HighestPrice { get; set; }
}