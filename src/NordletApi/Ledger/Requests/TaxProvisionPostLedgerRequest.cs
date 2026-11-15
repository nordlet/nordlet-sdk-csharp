using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record TaxProvisionPostLedgerRequest
{
    [JsonPropertyName("fiscalYear")]
    public required long FiscalYear { get; set; }

    [JsonPropertyName("amount")]
    public string? Amount { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
