using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankSettlementsImportRequest
{
    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("provider")]
    public PostV1BankSettlementsImportRequestProvider? Provider { get; set; }

    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
