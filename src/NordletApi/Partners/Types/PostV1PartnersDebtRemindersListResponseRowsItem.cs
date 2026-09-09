using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1PartnersDebtRemindersListResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("sentTo")]
    public required string SentTo { get; set; }

    [JsonPropertyName("invoiceCount")]
    public required long InvoiceCount { get; set; }

    [JsonPropertyName("totalDue")]
    public required string TotalDue { get; set; }

    [JsonPropertyName("interestDue")]
    public required string InterestDue { get; set; }

    [JsonPropertyName("currency")]
    public required string Currency { get; set; }

    [JsonPropertyName("invoiceIds")]
    public IEnumerable<string> InvoiceIds { get; set; } = new List<string>();

    [JsonPropertyName("sentAt")]
    public required string SentAt { get; set; }

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
