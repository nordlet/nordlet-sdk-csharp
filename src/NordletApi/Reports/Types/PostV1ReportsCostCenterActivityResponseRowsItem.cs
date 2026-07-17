using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsCostCenterActivityResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("accountCode")]
    public required string AccountCode { get; set; }

    [JsonPropertyName("accountName")]
    public required string AccountName { get; set; }

    [JsonPropertyName("debit")]
    public required string Debit { get; set; }

    [JsonPropertyName("credit")]
    public required string Credit { get; set; }

    [JsonPropertyName("net")]
    public required string Net { get; set; }

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
