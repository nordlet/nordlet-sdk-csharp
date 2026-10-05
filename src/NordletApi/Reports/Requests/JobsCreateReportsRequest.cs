using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record JobsCreateReportsRequest
{
    [JsonPropertyName("reportType")]
    public required string ReportType { get; set; }

    [JsonPropertyName("params")]
    public Dictionary<string, object?>? Params { get; set; }

    [JsonPropertyName("formats")]
    public IEnumerable<JobsCreateReportsRequestFormatsItem>? Formats { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
