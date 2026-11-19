using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record GbVatObligationsListDeclarationsResponseObligationsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("periodKey")]
    public required string PeriodKey { get; set; }

    [JsonPropertyName("start")]
    public required string Start { get; set; }

    [JsonPropertyName("end")]
    public required string End { get; set; }

    [JsonPropertyName("due")]
    public required string Due { get; set; }

    [JsonPropertyName("status")]
    public required GbVatObligationsListDeclarationsResponseObligationsItemStatus Status { get; set; }

    [JsonPropertyName("received")]
    public string? Received { get; set; }

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
