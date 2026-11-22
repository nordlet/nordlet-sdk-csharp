using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsDeUnemploymentGetDeclarationsResponseUc8APagesItemRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("line")]
    public required double Line { get; set; }

    [JsonPropertyName("socialSecurityNumber")]
    public string? SocialSecurityNumber { get; set; }

    [JsonPropertyName("firstInitial")]
    public required string FirstInitial { get; set; }

    [JsonPropertyName("middleInitial")]
    public string? MiddleInitial { get; set; }

    [JsonPropertyName("lastName")]
    public required string LastName { get; set; }

    [JsonPropertyName("grossCoveredWages")]
    public required string GrossCoveredWages { get; set; }

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
