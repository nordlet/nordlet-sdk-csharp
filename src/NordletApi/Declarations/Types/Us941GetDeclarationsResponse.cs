using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record Us941GetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("year")]
    public required double Year { get; set; }

    [JsonPropertyName("quarter")]
    public required double Quarter { get; set; }

    [JsonPropertyName("line1")]
    public required double Line1 { get; set; }

    [JsonPropertyName("line2")]
    public required string Line2 { get; set; }

    [JsonPropertyName("line3")]
    public required string Line3 { get; set; }

    [JsonPropertyName("line4")]
    public required bool Line4 { get; set; }

    [JsonPropertyName("line5a")]
    public required Us941GetDeclarationsResponseLine5A Line5A { get; set; }

    [JsonPropertyName("line5c")]
    public required Us941GetDeclarationsResponseLine5C Line5C { get; set; }

    [JsonPropertyName("line5d")]
    public required Us941GetDeclarationsResponseLine5D Line5D { get; set; }

    [JsonPropertyName("line5e")]
    public required string Line5E { get; set; }

    [JsonPropertyName("line6")]
    public required string Line6 { get; set; }

    [JsonPropertyName("line7")]
    public required string Line7 { get; set; }

    [JsonPropertyName("line10")]
    public required string Line10 { get; set; }

    [JsonPropertyName("line12")]
    public required string Line12 { get; set; }

    [JsonPropertyName("line13")]
    public string? Line13 { get; set; }

    [JsonPropertyName("line14")]
    public string? Line14 { get; set; }

    [JsonPropertyName("line15")]
    public string? Line15 { get; set; }

    [JsonPropertyName("line16")]
    public required Us941GetDeclarationsResponseLine16 Line16 { get; set; }

    [JsonPropertyName("scheduleB")]
    public IEnumerable<Us941GetDeclarationsResponseScheduleBItem> ScheduleB { get; set; } =
        new List<Us941GetDeclarationsResponseScheduleBItem>();

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
