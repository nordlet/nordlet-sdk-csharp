using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankFeedsAccountsLinkRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("bankAccountId")]
    public string? BankAccountId { get; set; }

    [JsonPropertyName("createBankAccount")]
    public PostV1BankFeedsAccountsLinkRequestCreateBankAccount? CreateBankAccount { get; set; }

    [JsonPropertyName("syncFrom")]
    public string? SyncFrom { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
