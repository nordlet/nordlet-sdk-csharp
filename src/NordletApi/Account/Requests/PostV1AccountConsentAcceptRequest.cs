using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountConsentAcceptRequest
{
    [JsonPropertyName("acceptTerms")]
    public required bool AcceptTerms { get; set; }

    [JsonPropertyName("acceptDpa")]
    public required bool AcceptDpa { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
