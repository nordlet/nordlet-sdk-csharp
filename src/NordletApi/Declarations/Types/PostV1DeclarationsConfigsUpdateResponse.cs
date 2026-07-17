using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsConfigsUpdateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("system")]
    public required string System { get; set; }

    [JsonPropertyName("country")]
    public required string Country { get; set; }

    [JsonPropertyName("title")]
    public required string Title { get; set; }

    [JsonPropertyName("fields")]
    public IEnumerable<PostV1DeclarationsConfigsUpdateResponseFieldsItem> Fields { get; set; } =
        new List<PostV1DeclarationsConfigsUpdateResponseFieldsItem>();

    [JsonPropertyName("endpoints")]
    public IEnumerable<PostV1DeclarationsConfigsUpdateResponseEndpointsItem>? Endpoints { get; set; }

    [JsonPropertyName("values")]
    public Dictionary<string, string> Values { get; set; } = new Dictionary<string, string>();

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
