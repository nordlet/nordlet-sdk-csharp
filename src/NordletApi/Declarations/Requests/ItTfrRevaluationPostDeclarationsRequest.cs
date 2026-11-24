using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItTfrRevaluationPostDeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("foiPreviousDecember")]
    public required string FoiPreviousDecember { get; set; }

    [JsonPropertyName("foiDecember")]
    public required string FoiDecember { get; set; }

    [JsonPropertyName("funds")]
    public IEnumerable<ItTfrRevaluationPostDeclarationsRequestFundsItem> Funds { get; set; } =
        new List<ItTfrRevaluationPostDeclarationsRequestFundsItem>();

    [JsonPropertyName("expenseAccountCode")]
    public required string ExpenseAccountCode { get; set; }

    [JsonPropertyName("fundAccountCode")]
    public required string FundAccountCode { get; set; }

    [JsonPropertyName("taxAccountCode")]
    public required string TaxAccountCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
