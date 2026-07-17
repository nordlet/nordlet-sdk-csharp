using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1AccountMembersSetRoleRequest
{
    [JsonPropertyName("userId")]
    public required string UserId { get; set; }

    [JsonPropertyName("role")]
    public required PostV1AccountMembersSetRoleRequestRole Role { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
