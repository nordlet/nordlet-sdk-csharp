using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record ItTfrAccrualPostDeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("month")]
    public required long Month { get; set; }

    [JsonPropertyName("includePaymentTypes")]
    public IEnumerable<string>? IncludePaymentTypes { get; set; }

    [JsonPropertyName("expenseAccountCode")]
    public required string ExpenseAccountCode { get; set; }

    [JsonPropertyName("fundAccountCode")]
    public string? FundAccountCode { get; set; }

    [JsonPropertyName("payableAccountCode")]
    public string? PayableAccountCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
