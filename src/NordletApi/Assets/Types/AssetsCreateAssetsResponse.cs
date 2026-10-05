using global::System.Text.Json;
using global::System.Text.Json.Serialization;
using NordletApi.Core;

namespace NordletApi;

[Serializable]
public record AssetsCreateAssetsResponse : IJsonOnDeserialized
{
    [JsonExtensionData]
    private readonly IDictionary<string, JsonElement> _extensionData =
        new Dictionary<string, JsonElement>();

    [JsonPropertyName("id")]
    public required string Id { get; set; }

    [JsonPropertyName("groupId")]
    public required string GroupId { get; set; }

    [JsonPropertyName("code")]
    public required string Code { get; set; }

    [JsonPropertyName("name")]
    public required string Name { get; set; }

    [JsonPropertyName("acquisitionDate")]
    public required DateOnly AcquisitionDate { get; set; }

    [JsonPropertyName("depreciationStartDate")]
    public required DateOnly DepreciationStartDate { get; set; }

    [JsonPropertyName("acquisitionCost")]
    public required string AcquisitionCost { get; set; }

    [JsonPropertyName("salvageValue")]
    public required string SalvageValue { get; set; }

    [JsonPropertyName("usefulLifeMonths")]
    public required long UsefulLifeMonths { get; set; }

    [JsonPropertyName("totalCost")]
    public required string TotalCost { get; set; }

    [JsonPropertyName("accumulatedDepreciation")]
    public required string AccumulatedDepreciation { get; set; }

    [JsonPropertyName("netBookValue")]
    public required string NetBookValue { get; set; }

    [JsonPropertyName("depreciatedMonths")]
    public required long DepreciatedMonths { get; set; }

    [JsonPropertyName("totalLifeMonths")]
    public required long TotalLifeMonths { get; set; }

    [JsonPropertyName("status")]
    public required AssetsCreateAssetsResponseStatus Status { get; set; }

    [JsonPropertyName("notes")]
    public string? Notes { get; set; }

    [JsonPropertyName("documents")]
    public IEnumerable<AssetsCreateAssetsResponseDocumentsItem>? Documents { get; set; }

    [JsonPropertyName("inputVatAmount")]
    public string? InputVatAmount { get; set; }

    [JsonPropertyName("inputVatFirstUseDate")]
    public DateOnly? InputVatFirstUseDate { get; set; }

    [JsonPropertyName("inputVatDeductiblePercent")]
    public string? InputVatDeductiblePercent { get; set; }

    [JsonPropertyName("inputVatRealEstate")]
    public required bool InputVatRealEstate { get; set; }

    [JsonPropertyName("inputVatUseChanges")]
    public IEnumerable<AssetsCreateAssetsResponseInputVatUseChangesItem> InputVatUseChanges { get; set; } =
        new List<AssetsCreateAssetsResponseInputVatUseChangesItem>();

    [JsonPropertyName("disposalDate")]
    public DateOnly? DisposalDate { get; set; }

    [JsonPropertyName("disposalReason")]
    public AssetsCreateAssetsResponseDisposalReason? DisposalReason { get; set; }

    [JsonPropertyName("disposalProceeds")]
    public string? DisposalProceeds { get; set; }

    [JsonPropertyName("disposalJournalTransactionId")]
    public string? DisposalJournalTransactionId { get; set; }

    [JsonPropertyName("createdAt")]
    public required DateTime CreatedAt { get; set; }

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
