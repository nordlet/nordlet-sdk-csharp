using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record LvEmployeeNoticeGenerateDeclarationsRequest
{
    [JsonPropertyName("contractId")]
    public required string ContractId { get; set; }

    [JsonPropertyName("event")]
    public required LvEmployeeNoticeGenerateDeclarationsRequestEvent Event { get; set; }

    [JsonPropertyName("endCode")]
    public LvEmployeeNoticeGenerateDeclarationsRequestEndCode? EndCode { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
