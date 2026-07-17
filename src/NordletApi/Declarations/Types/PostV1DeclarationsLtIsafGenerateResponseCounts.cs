using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtIsafGenerateResponseCounts : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("salesInvoices")]
    public required long SalesInvoices { get; set; }

    [JsonPropertyName("purchaseInvoices")]
    public required long PurchaseInvoices { get; set; }

    [JsonPropertyName("customers")]
    public required long Customers { get; set; }

    [JsonPropertyName("suppliers")]
    public required long Suppliers { get; set; }

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
