using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsWorkweeksListDeclarationsResponseEmployeesItemWeeksItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("start")]
    public required string Start { get; set; }

    [JsonPropertyName("end")]
    public required string End { get; set; }

    [JsonPropertyName("hours")]
    public required string Hours { get; set; }

    [JsonPropertyName("overtimeHours")]
    public required string OvertimeHours { get; set; }

    [JsonPropertyName("days")]
    public IEnumerable<UsWorkweeksListDeclarationsResponseEmployeesItemWeeksItemDaysItem> Days { get; set; } =
        new List<UsWorkweeksListDeclarationsResponseEmployeesItemWeeksItemDaysItem>();

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
