using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record UsIncomeTaxReturnGetDeclarationsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("form")]
    public required UsIncomeTaxReturnGetDeclarationsResponseForm Form { get; set; }

    [JsonPropertyName("scheme")]
    public required string Scheme { get; set; }

    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("page1")]
    public IEnumerable<UsIncomeTaxReturnGetDeclarationsResponsePage1Item> Page1 { get; set; } =
        new List<UsIncomeTaxReturnGetDeclarationsResponsePage1Item>();

    [JsonPropertyName("scheduleL")]
    public IEnumerable<UsIncomeTaxReturnGetDeclarationsResponseScheduleLItem> ScheduleL { get; set; } =
        new List<UsIncomeTaxReturnGetDeclarationsResponseScheduleLItem>();

    [JsonPropertyName("otherLines")]
    public IEnumerable<UsIncomeTaxReturnGetDeclarationsResponseOtherLinesItem> OtherLines { get; set; } =
        new List<UsIncomeTaxReturnGetDeclarationsResponseOtherLinesItem>();

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
