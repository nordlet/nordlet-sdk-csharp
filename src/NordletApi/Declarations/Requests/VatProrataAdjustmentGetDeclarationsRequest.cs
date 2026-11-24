using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatProrataAdjustmentGetDeclarationsRequest
{
    [JsonPropertyName("fiscalYear")]
    public required long FiscalYear { get; set; }

    [JsonPropertyName("definitivePercent")]
    public string? DefinitivePercent { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
