using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record SettlementsImportBankResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("format")]
    public required SettlementsImportBankResponseFormat Format { get; set; }

    [JsonPropertyName("imported")]
    public required long Imported { get; set; }

    [JsonPropertyName("updated")]
    public required long Updated { get; set; }

    [JsonPropertyName("skipped")]
    public required long Skipped { get; set; }

    [JsonPropertyName("skippedUnassigned")]
    public required long SkippedUnassigned { get; set; }

    [JsonPropertyName("skippedPayoutRows")]
    public required long SkippedPayoutRows { get; set; }

    [JsonPropertyName("skippedNotSettled")]
    public required long SkippedNotSettled { get; set; }

    [JsonPropertyName("batches")]
    public IEnumerable<SettlementsImportBankResponseBatchesItem> Batches { get; set; } =
        new List<SettlementsImportBankResponseBatchesItem>();

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
