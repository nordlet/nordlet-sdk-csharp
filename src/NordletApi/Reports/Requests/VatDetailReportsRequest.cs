using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatDetailReportsRequest
{
    [JsonPropertyName("fromDate")]
    public required DateOnly FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required DateOnly ToDate { get; set; }

    [JsonPropertyName("side")]
    public VatDetailReportsRequestSide? Side { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
