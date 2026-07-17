using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ReportsCostCenterItemsRequest
{
    [JsonPropertyName("fromDate")]
    public required string FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required string ToDate { get; set; }

    [JsonPropertyName("costCenterId")]
    public string? CostCenterId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
