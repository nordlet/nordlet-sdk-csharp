using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsStateSalesGetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("from")]
    public required string From { get; set; }

    [JsonPropertyName("to")]
    public required string To { get; set; }

    [JsonPropertyName("states")]
    public IEnumerable<UsStateSalesGetDeclarationsResponseStatesItem> States { get; set; } =
        new List<UsStateSalesGetDeclarationsResponseStatesItem>();

    [JsonPropertyName("withoutState")]
    public required UsStateSalesGetDeclarationsResponseWithoutState WithoutState { get; set; }

    [JsonPropertyName("outsideUs")]
    public required UsStateSalesGetDeclarationsResponseOutsideUs OutsideUs { get; set; }

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
