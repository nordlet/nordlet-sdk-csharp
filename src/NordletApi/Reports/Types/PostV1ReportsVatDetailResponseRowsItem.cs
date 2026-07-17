using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsVatDetailResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("documentId")]
    public required string DocumentId { get; set; }

    [JsonPropertyName("documentNumber")]
    public required string DocumentNumber { get; set; }

    [JsonPropertyName("date")]
    public string? Date { get; set; }

    [JsonPropertyName("partnerName")]
    public required string PartnerName { get; set; }

    [JsonPropertyName("vatRatePercent")]
    public required string VatRatePercent { get; set; }

    [JsonPropertyName("net")]
    public required string Net { get; set; }

    [JsonPropertyName("vat")]
    public required string Vat { get; set; }

    [JsonPropertyName("gross")]
    public required string Gross { get; set; }

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
