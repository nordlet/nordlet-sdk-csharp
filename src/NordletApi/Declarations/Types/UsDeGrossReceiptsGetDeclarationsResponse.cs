using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsDeGrossReceiptsGetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("from")]
    public required string From { get; set; }

    [JsonPropertyName("to")]
    public required string To { get; set; }

    [JsonPropertyName("activity")]
    public required string Activity { get; set; }

    [JsonPropertyName("grossReceipts")]
    public required string GrossReceipts { get; set; }

    [JsonPropertyName("excludedReceipts")]
    public required string ExcludedReceipts { get; set; }

    [JsonPropertyName("deduction")]
    public required string Deduction { get; set; }

    [JsonPropertyName("taxableReceipts")]
    public required string TaxableReceipts { get; set; }

    [JsonPropertyName("rate")]
    public required string Rate { get; set; }

    [JsonPropertyName("tax")]
    public required string Tax { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

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
