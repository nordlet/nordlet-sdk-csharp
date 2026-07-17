using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CashOrdersCreateRequest
{
    [JsonPropertyName("type")]
    public required PostV1CashOrdersCreateRequestType Type { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("purpose")]
    public required string Purpose { get; set; }

    [JsonPropertyName("counterAccountCode")]
    public required string CounterAccountCode { get; set; }

    [JsonPropertyName("cashAccountCode")]
    public string? CashAccountCode { get; set; }

    [JsonPropertyName("series")]
    public string? Series { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
