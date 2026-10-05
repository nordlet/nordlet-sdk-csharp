using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GlDetailReportsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("account")]
    public required GlDetailReportsResponseAccount Account { get; set; }

    [JsonPropertyName("opening")]
    public required string Opening { get; set; }

    [JsonPropertyName("closing")]
    public required string Closing { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<GlDetailReportsResponseRowsItem> Rows { get; set; } =
        new List<GlDetailReportsResponseRowsItem>();

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
