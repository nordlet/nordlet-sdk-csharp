using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationReportRequest
{
    [JsonPropertyName("groupId")]
    public required string GroupId { get; set; }

    [JsonPropertyName("fromDate")]
    public required string FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required string ToDate { get; set; }

    [JsonPropertyName("category")]
    public PostV1ConsolidationReportRequestCategory? Category { get; set; }

    [JsonPropertyName("eliminations")]
    public IEnumerable<PostV1ConsolidationReportRequestEliminationsItem>? Eliminations { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
