using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankStatementsImportResponseStatementsItem : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("statementId")]
    public string? StatementId { get; set; }

    [JsonPropertyName("iban")]
    public string? Iban { get; set; }

    [JsonPropertyName("fromDate")]
    public string? FromDate { get; set; }

    [JsonPropertyName("toDate")]
    public string? ToDate { get; set; }

    [JsonPropertyName("openingBalance")]
    public string? OpeningBalance { get; set; }

    [JsonPropertyName("closingBalance")]
    public string? ClosingBalance { get; set; }

    [JsonPropertyName("transactionCount")]
    public required long TransactionCount { get; set; }

    [JsonIgnore]
    public ReadOnlyAdditionalProperties AdditionalProperties { get; private set; } = new();

    void IJsonOnDeserialized.OnDeserialized() =>
        AdditionalProperties.CopyFromExtensionData(_extensionData);

    /// <inheritdoc />
    public override string ToString()
    {
        return JsonUtils.Serialize(this);
    }
}
