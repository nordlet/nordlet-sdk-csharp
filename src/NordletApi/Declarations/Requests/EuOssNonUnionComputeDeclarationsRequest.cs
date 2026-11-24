using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record EuOssNonUnionComputeDeclarationsRequest
{
    [JsonPropertyName("year")]
    public required long Year { get; set; }

    [JsonPropertyName("quarter")]
    public required long Quarter { get; set; }

    [JsonPropertyName("memberStateOfIdentification")]
    public required EuOssNonUnionComputeDeclarationsRequestMemberStateOfIdentification MemberStateOfIdentification { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
