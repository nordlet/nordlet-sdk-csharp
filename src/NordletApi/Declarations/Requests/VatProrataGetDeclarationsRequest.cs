using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record VatProrataGetDeclarationsRequest
{
    [JsonPropertyName("fiscalYear")]
    public required long FiscalYear { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
