using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1DeclarationsLtSdFfdataRequest
{
    [JsonPropertyName("type")]
    public required PostV1DeclarationsLtSdFfdataRequestType Type { get; set; }

    [JsonPropertyName("fromDate")]
    public required string FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public required string ToDate { get; set; }

    [JsonPropertyName("managerFullName")]
    public string? ManagerFullName { get; set; }

    [JsonPropertyName("preparatorDetails")]
    public string? PreparatorDetails { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
