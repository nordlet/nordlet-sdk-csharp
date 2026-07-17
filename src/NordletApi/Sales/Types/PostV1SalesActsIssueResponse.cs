using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record PostV1SalesActsIssueResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("partnerId")]
    public required string PartnerId { get; set; }

    [JsonPropertyName("type")]
    public required PostV1SalesActsIssueResponseType Type { get; set; }

    [JsonPropertyName("status")]
    public required PostV1SalesActsIssueResponseStatus Status { get; set; }

    [JsonPropertyName("series")]
    public required string Series { get; set; }

    [JsonPropertyName("fullNumber")]
    public string? FullNumber { get; set; }

    [JsonPropertyName("documentDate")]
    public required string DocumentDate { get; set; }

    [JsonPropertyName("saleInvoiceId")]
    public string? SaleInvoiceId { get; set; }

    [JsonPropertyName("transferredByName")]
    public string? TransferredByName { get; set; }

    [JsonPropertyName("transferredByTitle")]
    public string? TransferredByTitle { get; set; }

    [JsonPropertyName("acceptedByName")]
    public string? AcceptedByName { get; set; }

    [JsonPropertyName("acceptedByTitle")]
    public string? AcceptedByTitle { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("createdAt")]
    public required string CreatedAt { get; set; }

    [JsonPropertyName("updatedAt")]
    public required string UpdatedAt { get; set; }

    [JsonPropertyName("lines")]
    public IEnumerable<PostV1SalesActsIssueResponseLinesItem> Lines { get; set; } =
        new List<PostV1SalesActsIssueResponseLinesItem>();

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
