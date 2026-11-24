using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EeEmploymentRegisterGenerateDeclarationsRequest
{
    [JsonPropertyName("contractId")]
    public required string ContractId { get; set; }

    [JsonPropertyName("event")]
    public required EeEmploymentRegisterGenerateDeclarationsRequestEvent Event { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
