using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsGeneralJournalResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("total")]
    public required long Total { get; set; }

    [JsonPropertyName("page")]
    public required long Page { get; set; }

    [JsonPropertyName("pageSize")]
    public required long PageSize { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1ReportsGeneralJournalResponseRowsItem> Rows { get; set; } =
        new List<PostV1ReportsGeneralJournalResponseRowsItem>();

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
