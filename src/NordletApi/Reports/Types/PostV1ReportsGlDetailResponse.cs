using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsGlDetailResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("account")]
    public required PostV1ReportsGlDetailResponseAccount Account { get; set; }

    [JsonPropertyName("opening")]
    public required string Opening { get; set; }

    [JsonPropertyName("closing")]
    public required string Closing { get; set; }

    [JsonPropertyName("rows")]
    public IEnumerable<PostV1ReportsGlDetailResponseRowsItem> Rows { get; set; } =
        new List<PostV1ReportsGlDetailResponseRowsItem>();

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
