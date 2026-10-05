using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PaymentsExportPayrollRequest
{
    [JsonPropertyName("runId")]
    public required string RunId { get; set; }

    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("executionDate")]
    public DateOnly? ExecutionDate { get; set; }

    [JsonPropertyName("locale")]
    public PaymentsExportPayrollRequestLocale? Locale { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
