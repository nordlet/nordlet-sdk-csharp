using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsDeUnemploymentGetDeclarationsResponseUc8A : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("pages")]
    public IEnumerable<UsDeUnemploymentGetDeclarationsResponseUc8APagesItem> Pages { get; set; } =
        new List<UsDeUnemploymentGetDeclarationsResponseUc8APagesItem>();

    [JsonPropertyName("line32")]
    public required string Line32 { get; set; }

    [JsonPropertyName("line33")]
    public required string Line33 { get; set; }

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
