using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatAccountsReportsResponseDocuments : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("outputVat")]
    public required string OutputVat { get; set; }

    [JsonPropertyName("ossVat")]
    public required string OssVat { get; set; }

    [JsonPropertyName("selfAssessedVat")]
    public required string SelfAssessedVat { get; set; }

    [JsonPropertyName("deductibleVat")]
    public required string DeductibleVat { get; set; }

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
