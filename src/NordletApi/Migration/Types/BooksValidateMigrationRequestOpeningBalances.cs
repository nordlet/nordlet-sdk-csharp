using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record BooksValidateMigrationRequestOpeningBalances : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("date")]
    public DateOnly? Date { get; set; }

    [JsonPropertyName("balancingAccountCode")]
    public string? BalancingAccountCode { get; set; }

    [JsonPropertyName("entries")]
    public IEnumerable<BooksValidateMigrationRequestOpeningBalancesEntriesItem> Entries { get; set; } =
        new List<BooksValidateMigrationRequestOpeningBalancesEntriesItem>();

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
