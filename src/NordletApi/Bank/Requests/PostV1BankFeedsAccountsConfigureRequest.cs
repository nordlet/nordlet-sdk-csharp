using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankFeedsAccountsConfigureRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("importTemplateId")]
    public string? ImportTemplateId { get; set; }

    [JsonPropertyName("syncSchedule")]
    public PostV1BankFeedsAccountsConfigureRequestSyncSchedule? SyncSchedule { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
