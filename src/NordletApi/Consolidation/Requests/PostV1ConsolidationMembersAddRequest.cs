using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1ConsolidationMembersAddRequest
{
    [JsonPropertyName("groupId")]
    public required string GroupId { get; set; }

    [JsonPropertyName("memberCompanyId")]
    public required string MemberCompanyId { get; set; }

    [JsonPropertyName("ownershipPercent")]
    public double? OwnershipPercent { get; set; }

    [JsonPropertyName("method")]
    public PostV1ConsolidationMembersAddRequestMethod? Method { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
