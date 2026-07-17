using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankStatementsImportResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("imported")]
    public required long Imported { get; set; }

    [JsonPropertyName("skipped")]
    public required long Skipped { get; set; }

    [JsonPropertyName("statements")]
    public IEnumerable<PostV1BankStatementsImportResponseStatementsItem> Statements { get; set; } =
        new List<PostV1BankStatementsImportResponseStatementsItem>();

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
