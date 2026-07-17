using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankStatementsImportRequest
{
    [JsonPropertyName("bankAccountId")]
    public required string BankAccountId { get; set; }

    [JsonPropertyName("format")]
    public PostV1BankStatementsImportRequestFormat? Format { get; set; }

    [JsonPropertyName("content")]
    public required string Content { get; set; }

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
