using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record FeedsAccountsLinkBankRequest
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("bankAccountId")]
    public string? BankAccountId { get; set; }

    [JsonPropertyName("createBankAccount")]
    public FeedsAccountsLinkBankRequestCreateBankAccount? CreateBankAccount { get; set; }

    [JsonPropertyName("syncFrom")]
    public DateOnly? SyncFrom { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
