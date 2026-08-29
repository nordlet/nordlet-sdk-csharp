using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ProjectsReportResponseRowsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("projectId")]
    public required string ProjectId { get; set; }

    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("status")]
    public required PostV1ProjectsReportResponseRowsItemStatus Status { get; set; }

    [JsonPropertyName("revenue")]
    public required string Revenue { get; set; }

    [JsonPropertyName("costs")]
    public required string Costs { get; set; }

    [JsonPropertyName("profit")]
    public required string Profit { get; set; }

    [JsonPropertyName("totalHours")]
    public required string TotalHours { get; set; }

    [JsonPropertyName("billableHours")]
    public required string BillableHours { get; set; }

    [JsonPropertyName("billedHours")]
    public required string BilledHours { get; set; }

    [JsonPropertyName("unbilledHours")]
    public required string UnbilledHours { get; set; }

    [JsonPropertyName("unbilledAmount")]
    public required string UnbilledAmount { get; set; }

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
