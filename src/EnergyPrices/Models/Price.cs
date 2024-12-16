using System.Text.Json.Serialization;

namespace EnergyPrices.Models;

public class Price
{
    [JsonPropertyName("localTime")]
    public DateTime LocalTime { get; set; }

    [JsonPropertyName("isPrediction")]
    public bool IsPrediction { get; set; }

    [JsonPropertyName("kwPrice")]
    public int KwPrice { get; set; }

    [JsonPropertyName("totalGrid")]
    public int TotalGrid { get; set; }

    [JsonPropertyName("totalRetail")]
    public int TotalRetail { get; set; }

    [JsonPropertyName("totalPriceInclVat")]
    public int TotalPriceInclVat { get; set; }

    [JsonPropertyName("priceInclVat")]
    public int PriceInclVat { get; set; }

    [JsonPropertyName("isHighestPrice")]
    public bool IsHighestPrice { get; set; }

    [JsonPropertyName("isLowestPrice")]
    public bool IsLowestPrice { get; set; }
}