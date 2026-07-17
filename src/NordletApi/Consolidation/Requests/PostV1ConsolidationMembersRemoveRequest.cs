using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationMembersRemoveRequest
{
    [JsonPropertyName("groupId")]
    public required string GroupId { get; set; }

    [JsonPropertyName("memberCompanyId")]
    public required string MemberCompanyId { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
