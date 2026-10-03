using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsEeEmploymentRegisterSendRequest
{
    [JsonPropertyName("contractId")]
    public required string ContractId { get; set; }

    [JsonPropertyName("event")]
    public required PostV1DeclarationsEeEmploymentRegisterSendRequestEvent Event { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
