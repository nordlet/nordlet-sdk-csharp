using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1BankStatementsImportResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("imported")]
    public required long Imported { get; set; }

    [JsonPropertyName("skipped")]
    public required long Skipped { get; set; }

    [JsonPropertyName("posted")]
    public required long Posted { get; set; }

    [JsonPropertyName("customersCreated")]
    public required long CustomersCreated { get; set; }

    [JsonPropertyName("invoicesCreated")]
    public required long InvoicesCreated { get; set; }

    [JsonPropertyName("invoicesLinked")]
    public required long InvoicesLinked { get; set; }

    [JsonPropertyName("creditNotesCreated")]
    public required long CreditNotesCreated { get; set; }

    [JsonPropertyName("authorizationsRecorded")]
    public required long AuthorizationsRecorded { get; set; }

    [JsonPropertyName("payoutsPosted")]
    public required long PayoutsPosted { get; set; }

    [JsonPropertyName("commissionsPosted")]
    public required long CommissionsPosted { get; set; }

    [JsonPropertyName("paymentsMatched")]
    public required long PaymentsMatched { get; set; }

    [JsonPropertyName("warnings")]
    public IEnumerable<string> Warnings { get; set; } = new List<string>();

    [JsonPropertyName("statements")]
    public IEnumerable<PostV1BankStatementsImportResponseStatementsItem> Statements { get; set; } =
        new List<PostV1BankStatementsImportResponseStatementsItem>();

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
