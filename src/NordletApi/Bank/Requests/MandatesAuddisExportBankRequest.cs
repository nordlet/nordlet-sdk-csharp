using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record MandatesAuddisExportBankRequest
{
    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("mandateIds")]
    public IEnumerable<string>? MandateIds { get; set; }

    [JsonPropertyName("processingDate")]
    public DateOnly? ProcessingDate { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
