using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatProrataSetDeclarationsRequest
{
    [JsonPropertyName("fiscalYear")]
    public required long FiscalYear { get; set; }

    [JsonPropertyName("percent")]
    public required string Percent { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
