using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsJobsCreateResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("reportType")]
    public required string ReportType { get; set; }

    [JsonPropertyName("params")]
    public required object Params { get; set; }

    [JsonPropertyName("formats")]
    public IEnumerable<string> Formats { get; set; } = new List<string>();

    [JsonPropertyName("status")]
    public required PostV1ReportsJobsCreateResponseStatus Status { get; set; }

    [JsonPropertyName("error")]
    public string? Error { get; set; }

    [JsonPropertyName("outputs")]
    public IEnumerable<PostV1ReportsJobsCreateResponseOutputsItem>? Outputs { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("startedAt")]
    public string? StartedAt { get; set; }

    [JsonPropertyName("finishedAt")]
    public string? FinishedAt { get; set; }

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
