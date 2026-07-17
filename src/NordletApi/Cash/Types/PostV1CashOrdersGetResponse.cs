using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1CashOrdersGetResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("type")]
    public required PostV1CashOrdersGetResponseType Type { get; set; }

    [JsonPropertyName("series")]
    public required string Series { get; set; }

    [JsonPropertyName("number")]
    public required long Number { get; set; }

    [JsonPropertyName("fullNumber")]
    public required string FullNumber { get; set; }

    [JsonPropertyName("date")]
    public required string Date { get; set; }

    [JsonPropertyName("partnerId")]
    public string? PartnerId { get; set; }

    [JsonPropertyName("employeeId")]
    public string? EmployeeId { get; set; }

    [JsonPropertyName("amount")]
    public required string Amount { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("purpose")]
    public required string Purpose { get; set; }

    [JsonPropertyName("cashAccountCode")]
    public required string CashAccountCode { get; set; }

    [JsonPropertyName("counterAccountCode")]
    public required string CounterAccountCode { get; set; }

    [JsonPropertyName("journalTransactionId")]
    public string? JournalTransactionId { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
