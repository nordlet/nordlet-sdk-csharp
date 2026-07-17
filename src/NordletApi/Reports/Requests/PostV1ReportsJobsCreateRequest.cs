using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsJobsCreateRequest
{
    [JsonPropertyName("reportType")]
    public required string ReportType { get; set; }

    [JsonPropertyName("params")]
    public Dictionary<string, object?>? Params { get; set; }

    [JsonPropertyName("formats")]
    public IEnumerable<PostV1ReportsJobsCreateRequestFormatsItem>? Formats { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
