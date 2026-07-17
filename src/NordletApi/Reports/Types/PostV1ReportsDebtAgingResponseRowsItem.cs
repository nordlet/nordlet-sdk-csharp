using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsDebtAgingResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("partnerName")]
    public required string PartnerName { get; set; }

    [JsonPropertyName("current")]
    public required string Current { get; set; }

    [JsonPropertyName("d1to30")]
    public required string D1To30 { get; set; }

    [JsonPropertyName("d31to60")]
    public required string D31To60 { get; set; }

    [JsonPropertyName("d61to90")]
    public required string D61To90 { get; set; }

    [JsonPropertyName("over90")]
    public required string Over90 { get; set; }

    [JsonPropertyName("total")]
    public required string Total { get; set; }

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
