using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItTfrRevaluationComputeDeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("foiPreviousDecember")]
    public required string FoiPreviousDecember { get; set; }

    [JsonPropertyName("foiDecember")]
    public required string FoiDecember { get; set; }

    [JsonPropertyName("funds")]
    public IEnumerable<ItTfrRevaluationComputeDeclarationsRequestFundsItem> Funds { get; set; } =
        new List<ItTfrRevaluationComputeDeclarationsRequestFundsItem>();

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
